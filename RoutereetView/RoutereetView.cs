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
    /// <summary>
    /// メインフォーム
    /// </summary>
    public partial class RoutereetView : Form
    {
        private CoordinateList coordinateList;
        private AltitudeView altitudeView;
        private MapView mapView;
        private int currentIndex;
        private double heading;

        public RoutereetView()
        {
            InitializeComponent();
            altitudeView = new AltitudeView(pictureBoxAltitude);
            mapView = new MapView(pictureBoxMap);
        }

        /// <summary>
        /// Open KML ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                mapView.DrawMap(coordinateList);
            }
        }

        /// <summary>
        /// KML読み込み
        /// </summary>
        /// <param name="fileContent"></param>
        private void LoadKml(string fileContent)
        {
            KmlLoaderImpl loader = new KmlLoaderImpl();
            coordinateList = loader.load(fileContent);

            labelMaxAltitude.Text = coordinateList.MaxAltitude.ToString();
            labelMinAltitude.Text = coordinateList.MinAltitude.ToString();
        }

        /// <summary>
        /// 高度ビュークリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAltitude_Click(object sender, EventArgs e)
        {
            Point pt = pictureBoxAltitude.PointToClient(new Point(MousePosition.X, MousePosition.Y));
            currentIndex = altitudeView.OnClickAndReturnIndex(pt);

            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex);
            heading = GpsCalculator.Heading(tpl.Item1, tpl.Item2);
            DrawStreetView(tpl.Item1);

            mapView.DrawCurrentPoint(currentIndex);
        }

        /// <summary>
        /// マップビュークリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMap_MouseClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            currentIndex = mapView.OnClickAndReturnIndex(pt);

            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex);
            heading = GpsCalculator.Heading(tpl.Item1, tpl.Item2);
            DrawStreetView(tpl.Item1);
            altitudeView.DrawLine(currentIndex);
        }

        /// <summary>
        /// ストリートビュー表示
        /// </summary>
        /// <param name="coordinate"></param>
        private void DrawStreetView(Coordinate coordinate)
        {
            StreetViewAPI api = new StreetViewAPI(new HttpImpl());
            Bitmap bitmap = api.GetImage(coordinate, heading);
            pictureBoxStreetView.Image = bitmap;
        }

        /// <summary>
        /// 右回転ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrunRight_Click(object sender, EventArgs e)
        {
            TurnStreetView(45);
        }

        /// <summary>
        /// 左回転ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            TurnStreetView(360 - 45);
        }

        /// <summary>
        /// ストリートビュー回転
        /// </summary>
        /// <param name="angle">回転する角度</param>
        private void TurnStreetView(double angle)
        {
            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex);
            heading = (heading + angle) % 360;
            DrawStreetView(tpl.Item1);
        }

        /// <summary>
        /// 進むボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoAhead_Click(object sender, EventArgs e)
        {
            ++currentIndex;
            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex + 1);
            heading = GpsCalculator.Heading(tpl.Item1, tpl.Item2);
            DrawStreetView(tpl.Item1);
            altitudeView.DrawLine(currentIndex);
            mapView.DrawCurrentPoint(currentIndex);
        }

        /// <summary>
        /// 戻るボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            --currentIndex;
            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(currentIndex + 1);
            heading = GpsCalculator.Heading(tpl.Item1, tpl.Item2);
            DrawStreetView(tpl.Item1);
            altitudeView.DrawLine(currentIndex);
            mapView.DrawCurrentPoint(currentIndex);
        }
    }
}
