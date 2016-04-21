using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutereetView
{
    public class GpsCalculator
    {
        /// <summary>
        /// fromからtoへの方角（度）を返す
        /// </summary>
        /// <param name="from">GPS座標</param>
        /// <param name="to">GPS座標</param>
        /// <returns>方角（度）</returns>
        public static double Heading(Coordinate from, Coordinate to)
        {
            double deltaL = D2R(to.Longitude - from.Longitude);
            double X = Math.Cos(D2R(to.Latitude)) * Math.Sin(deltaL);
            double Y = Math.Cos(D2R(from.Latitude)) * Math.Sin(D2R(to.Latitude))
                - Math.Sin(D2R(from.Latitude)) * Math.Cos(D2R(to.Latitude)) * Math.Cos(deltaL);
            double beta = Math.Atan2(X, Y);
            return beta * (180.0 / Math.PI);    // Radian to Degree
        }

        /// <summary>
        /// Degree to Radian
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        private static double D2R(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
