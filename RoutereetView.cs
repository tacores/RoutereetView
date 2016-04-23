using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutereetView
{
    public partial class RoutereetView : Form
    {
        private CoordinateList coordinateList;
        private AltitudeView altitudeView;
        private int currentIndex;
        private double heading;

        public RoutereetView()
        {
            InitializeComponent();
            altitudeView = new AltitudeView(pictureBoxAltitude);
        }

        private void buttonOpenKml_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "KMLファイル(*.kml)|*.kml";
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(ofd.FileName);
                LoadKml(fileContent);
                altitudeView.DrawAltitude(coordinateList);
            }
        }

        private void LoadKml(string fileContent)
        {
            KmlLoaderImpl loader = new KmlLoaderImpl();
            coordinateList = loader.load(fileContent);

            labelMaxAltitude.Text = coordinateList.MaxAltitude.ToString();
            labelMinAltitude.Text = coordinateList.MinAltitude.ToString();
        }

        private void pictureBoxAltitude_Click(object sender, EventArgs e)
        {
            Point pt = pictureBoxAltitude.PointToClient(new Point(MousePosition.X, MousePosition.Y));
            altitudeView.OnClick(pt);
            currentIndex = altitudeView.GetCurrentIndex();

            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex);
            heading = GpsCalculator.Heading(tpl.Item1, tpl.Item2);
            DrawStreetViewAtIndex(tpl.Item1);

        }

        private void DrawStreetViewAtIndex(Coordinate coordinate)
        {
            StreetViewAPI api = new StreetViewAPI(new HttpImpl());
            Bitmap bitmap = api.GetImage(coordinate, heading);
            pictureBoxStreetView.Image = bitmap;
        }

        private void buttonTrunRight_Click(object sender, EventArgs e)
        {
            TurnStreetView(45);
        }

        private void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            TurnStreetView(360 - 45);
        }

        private void TurnStreetView(double angle)
        {
            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex);
            heading = (heading + angle) % 360;
            DrawStreetViewAtIndex(tpl.Item1);
        }

        private void buttonGoAhead_Click(object sender, EventArgs e)
        {
            ++currentIndex;
            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex + 1);
            heading = GpsCalculator.Heading(tpl.Item1, tpl.Item2);
            DrawStreetViewAtIndex(tpl.Item1);
        }
    }
}
