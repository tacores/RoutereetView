using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoutereetView;

namespace Test
{
    /// <summary>
    /// KmlLoaderTest の概要の説明
    /// </summary>
    [TestClass]
    public class KmlLoaderTest
    {
        private KmlLoaderImpl sut;

        [TestInitialize]
        public void SetUp()
        {
            sut = new KmlLoaderImpl();
        }

        [TestMethod]
        public void TestLoad()
        {
            string xml = @"<?xml version=""1.0"" encoding=""UTF - 8""?>
                <kml xmlns = ""http://www.opengis.net/kml/2.2"" xmlns: gx = ""http://www.google.com/kml/ext/2.2"" >
                <Placemark>
                    <LineString>
                        <coordinates>
                        134.1754575,34.48808388888889,2
                        </coordinates>
                    </LineString>
                </Placemark>
                </kml>";

            CoordinateList list = sut.load(xml);

            System.Collections.IEnumerator enumerator = list.Iter().GetEnumerator();
            enumerator.MoveNext();
            Coordinate coordinate = (Coordinate)enumerator.Current;

            Assert.AreEqual(134.1754575, coordinate.Latitude);
            Assert.AreEqual(34.48808388888889, coordinate.Longitude);
            Assert.AreEqual(2, coordinate.Altitude);
        }
    }
}
