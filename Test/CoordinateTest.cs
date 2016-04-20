using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoutereetView;

namespace Test
{
    [TestClass]
    public class CoordinateTest
    {
        private Coordinate sut;

        [TestInitialize]
        public void SetUp()
        {
            sut = new Coordinate();
        }

        [TestMethod]
        public void TestSetGetLongitude()
        {
            sut.Longitude = 3.33333;

            Assert.AreEqual(3.33333, sut.Longitude);
        }

        [TestMethod]
        public void TestSetGetLatitude()
        {
            sut.Latitude = 2.22222;

            Assert.AreEqual(2.22222, sut.Latitude);
        }

        [TestMethod]
        public void TestSetGetAltitude()
        {
            sut.Altitude = 1.11111;

            Assert.AreEqual(1.11111, sut.Altitude);
        }
    }
}
