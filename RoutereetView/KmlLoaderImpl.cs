using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutereetView
{
    public class KmlLoaderImpl : KmlLoader
    {
        public CoordinateList load(string fileContent)
        {
            CoordinateList list = new CoordinateList();

            XNamespace ns = GetKmlNameSpace(fileContent);

            XDocument doc = XDocument.Parse(fileContent);
            string coordinates = "";
            foreach(var ele in doc.Descendants(ns + "coordinates"))
            {
                coordinates = ele.Value.Trim();
            }
            SetCoordinates(list, coordinates);
            return list;
        }

        private XNamespace GetKmlNameSpace(string fileContent)
        {
            XElement root = XElement.Parse(fileContent);
            return root.GetDefaultNamespace();
        }

        private void SetCoordinates(CoordinateList list, string coordinates)
        {
            string[] lines = coordinates.Split(new string[] { " ", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                Coordinate coordinate = new Coordinate();
                string[] colms = line.Split(new string[] { "," }, StringSplitOptions.None);
                coordinate.Longitude = Double.Parse(colms[0]);
                coordinate.Latitude = Double.Parse(colms[1]);
                coordinate.Altitude = Double.Parse(colms[2]);

                list.Add(coordinate);
            }
        }
    }
}
