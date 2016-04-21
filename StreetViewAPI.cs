using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace RoutereetView
{
    /// <summary>
    /// 
    /// </summary>
    public class StreetViewAPI
    {
        private Http http;

        public StreetViewAPI(Http http)
        {
            this.http = http;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coordinate"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        public Bitmap GetImage(Coordinate coordinate, double heading)
        {
            string url = "https://maps.googleapis.com/maps/api/streetview?size=300x300";
            url += "&location=" + coordinate.Longitude.ToString() + "," + coordinate.Latitude.ToString();
            url += "&heading=" + heading.ToString();
            url += "&key=" + "keykey";

            byte[] data = http.Download(url);
            Bitmap bitmap = null;
            using (MemoryStream ms = new MemoryStream(data))
            {
                bitmap = new Bitmap(ms);
            }
            return bitmap;
        }
    }
}
