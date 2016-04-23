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
        public void TestLoadCoordinates_LF()
        {
            string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <kml xmlns=""http://www.opengis.net/kml/2.2"" xmlns:gx=""http://www.google.com/kml/ext/2.2"">
                <Placemark>
                    <LineString>
                        <coordinates>
                        134.1754575,34.48808388888889,2
                        134.182555,34.484685,4
                        </coordinates>
                    </LineString>
                </Placemark>
                </kml>";
            xml = xml.Replace("\r\n", "\n");

            CoordinateList list = sut.load(xml);

            System.Collections.IEnumerator enumerator = list.Iter().GetEnumerator();
            enumerator.MoveNext();
            Coordinate coordinate1 = (Coordinate)enumerator.Current;
            enumerator.MoveNext();
            Coordinate coordinate2 = (Coordinate)enumerator.Current;

            Assert.AreEqual(134.1754575, coordinate1.Longitude);
            Assert.AreEqual(34.48808388888889, coordinate1.Latitude);
            Assert.AreEqual(2, coordinate1.Altitude);

            Assert.AreEqual(134.182555, coordinate2.Longitude);
            Assert.AreEqual(34.484685, coordinate2.Latitude);
            Assert.AreEqual(4, coordinate2.Altitude);
        }

        [TestMethod]
        public void TestLoadCoordinates_CRLF()
        {
            string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <kml xmlns=""http://www.opengis.net/kml/2.2"" xmlns:gx=""http://www.google.com/kml/ext/2.2"">
                <Placemark>
                    <LineString>
                        <coordinates>
                        134.1754575,34.48808388888889,2
                        134.182555,34.484685,4
                        </coordinates>
                    </LineString>
                </Placemark>
                </kml>";

            CoordinateList list = sut.load(xml);

            System.Collections.IEnumerator enumerator = list.Iter().GetEnumerator();
            enumerator.MoveNext();
            Coordinate coordinate1 = (Coordinate)enumerator.Current;
            enumerator.MoveNext();
            Coordinate coordinate2 = (Coordinate)enumerator.Current;

            Assert.AreEqual(134.1754575, coordinate1.Longitude);
            Assert.AreEqual(34.48808388888889, coordinate1.Latitude);
            Assert.AreEqual(2, coordinate1.Altitude);

            Assert.AreEqual(134.182555, coordinate2.Longitude);
            Assert.AreEqual(34.484685, coordinate2.Latitude);
            Assert.AreEqual(4, coordinate2.Altitude);
        }

        [TestMethod]
        public void TestLoadCoordinates_NameSpace()
        {
            string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                <kml xmlns=""ANY_NAMESPACE"" xmlns:gx=""http://www.google.com/kml/ext/2.2"">
                    <coordinates>
                    134.1754575,34.48808388888889,2
                    </coordinates>
                </kml>";

            CoordinateList list = sut.load(xml);

            System.Collections.IEnumerator enumerator = list.Iter().GetEnumerator();
            enumerator.MoveNext();
            Coordinate coordinate1 = (Coordinate)enumerator.Current;

            Assert.AreEqual(134.1754575, coordinate1.Longitude);
            Assert.AreEqual(34.48808388888889, coordinate1.Latitude);
            Assert.AreEqual(2, coordinate1.Altitude);
        }
    }
}
