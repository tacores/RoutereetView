﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutereetView
{
    /// <summary>
    /// GPSの座標を表現するクラス
    /// </summary>
    public class Coordinate
    {
        private double longitude;
        private double latitude;
        private double altitude;

        /// <summary>
        /// 緯度
        /// </summary>
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        /// <summary>
        /// 経度
        /// </summary>
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        /// <summary>
        /// 高度
        /// </summary>
        public double Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }
    }
}
