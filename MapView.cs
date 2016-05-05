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

            xMagnification = (double)picWidth / (maxLatitude - minLatitude);
            yMagnification = (double)picHeight / (maxLongitude - minLongitude);

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
            int x = (int)(xMagnification * (coordinate.Latitude - minLatitude));
            int y = (int)(yMagnification * (coordinate.Longitude - minLongitude)) - 1;
            int xResult = y;
            int yResult = picHeight - x;
            return new Point(xResult, yResult);
        }
    }
}
