using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RoutereetView
{
    class MapView
    {
        private PictureBox pictureBoxMap;
        private Bitmap baseCanvas;
        private CoordinateList coordinateList;
        private int picWidth;
        private int picHeight;
        private double maxLongitude;
        private double minLongitude;
        private double maxLatitude;
        private double minLatitude;

        private int PointSize = 10;

        double xMagnification;
        double yMagnification;
        int currentIndex;

        public MapView(PictureBox pictureBoxMap)
        {
            this.pictureBoxMap = pictureBoxMap;
            picWidth = pictureBoxMap.Width;
            picHeight = pictureBoxMap.Height;
        }

        public void DrawMap(CoordinateList coordinateList)
        {
            currentIndex = 0;
            this.coordinateList = coordinateList;
            maxLongitude = coordinateList.MaxLongitude;
            minLongitude = coordinateList.MinLongitude;
            maxLatitude = coordinateList.MaxLatitude;
            minLatitude = coordinateList.MinLatitude;

            xMagnification = (double)picWidth / (maxLongitude - minLongitude);
            yMagnification = (double)picHeight / (maxLatitude - minLatitude);

            Bitmap newCanvas = new Bitmap(picWidth, picHeight);
            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                DrawMapGraph(g);
            }
            pictureBoxMap.Image = newCanvas;
            baseCanvas = newCanvas;
        }

        private void DrawMapGraph(Graphics g)
        {
            g.FillRectangle(Brushes.White, 0, 0, picWidth, picHeight);
            Point pt1 = Point.Empty;
            Point pt2 = Point.Empty;

            int i = 0;
            foreach (Coordinate coord in coordinateList.Iter())
            {
                pt2 = ConvertCoordinateToPixelPoint(coord);
                if (!pt1.IsEmpty)
                {
                    g.DrawLine(Pens.Blue, pt1, pt2);
                }
                pt1 = pt2;
                ++i;
            }
        }

        private Point ConvertCoordinateToPixelPoint(Coordinate coordinate)
        {
            int xResult = (int)(xMagnification * (coordinate.Longitude - minLongitude));
            int yResult = picHeight - (int)(yMagnification * (coordinate.Latitude - minLatitude)) - 1;
            return new Point(xResult, yResult);
        }

        private Coordinate ConvertPixelPointToCoordinate(Point pt)
        {
            Coordinate coordinate = new Coordinate();
            coordinate.Longitude = pt.X / xMagnification + minLongitude;
            coordinate.Latitude = (picHeight - pt.Y - 1) / yMagnification + minLatitude;
            return coordinate;
        }

        public void DrawCurrentPoint(int index)
        {
            Tuple<Coordinate, Coordinate> tpl = coordinateList.GetTupleAtIndex(index);

            Bitmap newCanvas = new Bitmap(baseCanvas);
            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                Point pt = ConvertCoordinateToPixelPoint(tpl.Item1);
                g.FillEllipse(Brushes.Red, pt.X - PointSize / 2, pt.Y - PointSize / 2, PointSize, PointSize);
            }
            pictureBoxMap.Image = newCanvas;
        }

        public int OnClickAndReturnIndex(Point pt)
        {
            Bitmap newCanvas = new Bitmap(baseCanvas);
            Coordinate coordinate = ConvertPixelPointToCoordinate(pt);
            int index = coordinateList.GetNearestIndex(coordinate.Longitude, coordinate.Latitude);
            DrawCurrentPoint(index);
            return index;
        }
    }
}
