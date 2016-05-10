using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RoutereetView
{
    class AltitudeView
    {
        private PictureBox pictureBoxAltitude;
        private Bitmap baseCanvas;
        private CoordinateList coordinateList;
        private int picWidth;
        private int picHeight;
        private int maxAltitude;
        private int minAltitude;
        double xMagnification;
        double yMagnification;

        public AltitudeView(PictureBox pictureBoxAltitude)
        {
            this.pictureBoxAltitude = pictureBoxAltitude;
            picWidth = pictureBoxAltitude.Width;
            picHeight = pictureBoxAltitude.Height;
        }

        public void DrawAltitude(CoordinateList coordinateList)
        {
            this.coordinateList = coordinateList;
            maxAltitude = (int)coordinateList.MaxAltitude;
            minAltitude = (int)coordinateList.MinAltitude;
            xMagnification = (double)picWidth / coordinateList.Count;
            yMagnification = (double)picHeight / (maxAltitude - minAltitude);

            Bitmap newCanvas = new Bitmap(picWidth, picHeight);
            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                DrawAltitudeGraph(g);
            }
            pictureBoxAltitude.Image = newCanvas;
            baseCanvas = newCanvas;
        }

        private void DrawAltitudeGraph(Graphics g)
        {
            g.FillRectangle(Brushes.White, 0, 0, picWidth, picHeight);
            Point pt1 = Point.Empty;
            Point pt2 = Point.Empty;

            int i = 0;
            foreach (Coordinate coord in coordinateList.Iter())
            {
                pt2 = ConvertAltitudeToPixelPoint(i, (int)coord.Altitude);
                if(!pt1.IsEmpty)
                {
                    g.DrawLine(Pens.Blue, pt1, pt2);
                }
                pt1 = pt2;
                ++i;
            }
        }

        private Point ConvertAltitudeToPixelPoint(int x, int y)
        {
            int xResult = (int)(xMagnification * x);
            int yResult = picHeight - (int)(yMagnification * y) - 1;
            return new Point(xResult, yResult);
        }

        public int OnClickAndReturnIndex(Point pt)
        {
            Bitmap newCanvas = new Bitmap(baseCanvas);
            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                g.DrawLine(Pens.Red, new Point(pt.X, 0), new Point(pt.X, picHeight - 1));
            }
            pictureBoxAltitude.Image = newCanvas;
            int index = (int)((double)pt.X / xMagnification);
            return index;
        }

        public void DrawLine(int index)
        {
            Bitmap newCanvas = new Bitmap(baseCanvas);
            using (Graphics g = Graphics.FromImage(newCanvas))
            {
                int x = (int)(xMagnification * index);
                g.DrawLine(Pens.Red, new Point(x, 0), new Point(x, picHeight - 1));
            }
            pictureBoxAltitude.Image = newCanvas;
        }
    }
}
