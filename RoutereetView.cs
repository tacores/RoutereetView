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
                KmlLoaderImpl loader = new KmlLoaderImpl();
                coordinateList = loader.load(fileContent);

                labelMaxAltitude.Text = coordinateList.MaxAltitude.ToString();
                labelMinAltitude.Text = coordinateList.MinAltitude.ToString();
                altitudeView.DrawAltitude(coordinateList);
            }
        }

        private void pictureBoxAltitude_Click(object sender, EventArgs e)
        {
            pictureBoxStreetView.Image = null;

            Point pt = pictureBoxAltitude.PointToClient(new Point(MousePosition.X, MousePosition.Y));
            altitudeView.OnClick(pt);
            int currentIndex = altitudeView.GetCurrentIndex();
            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex);
            double heading = GpsCalculator.Heading(tpl.Item1, tpl.Item2);

            StreetViewAPI api = new StreetViewAPI(new HttpImpl());
            Bitmap bitmap = api.GetImage(tpl.Item1, heading);
            pictureBoxStreetView.Image = bitmap;
        }
    }
}
