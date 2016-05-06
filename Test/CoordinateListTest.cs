using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoutereetView;

namespace Test
{
    [TestClass]
    public class CoordinateListTest
    {
        private CoordinateList sut;

        [TestInitialize]
        public void SetUp()
        {
            sut = new CoordinateList();
        }

        [TestMethod]
        public void TestCountIsZeroInitially()
        {
            Assert.AreEqual(0, sut.Count);
        }

        [TestMethod]
        public void TestCountIsOneAfterAdd()
        {
            sut.Add(new Coordinate());

            Assert.AreEqual(1, sut.Count);
        }

        [TestMethod]
        public void TestIter()
        {
            Coordinate coordinate = new Coordinate();
            sut.Add(coordinate);

            foreach(Coordinate it in sut.Iter())
            {
                Assert.AreEqual(coordinate, it);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMaxLongitude()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Longitude = 1000;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Longitude = 999;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            Assert.AreEqual(1000, sut.MaxLongitude);
        }

        [TestMethod]
        public void TestMinLongitude()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Longitude = 1000;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Longitude = -999;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            Assert.AreEqual(-999, sut.MinLongitude);
        }

        [TestMethod]
        public void TestMaxLatitude()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Latitude = 1000;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Latitude = 999;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            Assert.AreEqual(1000, sut.MaxLatitude);
        }

        [TestMethod]
        public void TestMinLatitude()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Latitude = 1000;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Latitude = -999;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            Assert.AreEqual(-999, sut.MinLatitude);
        }

        [TestMethod]
        public void TestMaxAltitude()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Altitude = 1000;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Altitude = 999;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            Assert.AreEqual(1000, sut.MaxAltitude);
        }

        [TestMethod]
        public void TestMinAltitude()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Altitude = 1000;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Altitude = -999;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            Assert.AreEqual(-999, sut.MinAltitude);
        }

        [TestMethod]
        public void TestGetTupleAtIndex()
        {
            Coordinate coordinate1 = new Coordinate();
            Coordinate coordinate2 = new Coordinate();
            sut.Add(coordinate1);
            sut.Add(coordinate2);

            Tuple<Coordinate, Coordinate> t = sut.GetTupleAtIndex(0);

            Assert.AreEqual(coordinate1, t.Item1);
            Assert.AreEqual(coordinate2, t.Item2);
        }

        [TestMethod]
        public void TestGetTupleAtIndex_ThrowArgumentOutOfRange()
        {
            Coordinate coordinate1 = new Coordinate();
            Coordinate coordinate2 = new Coordinate();
            sut.Add(coordinate1);
            sut.Add(coordinate2);

            try
            {
                sut.GetTupleAtIndex(1);
            }
            catch(ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestGetNearest1()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Longitude = -10;
            coordinate1.Latitude = -10;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Longitude = 10;
            coordinate2.Latitude = 10;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            int index = sut.GetNearestIndex(-1, -1);
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void TestGetNearest2()
        {
            Coordinate coordinate1 = new Coordinate();
            coordinate1.Longitude = -10;
            coordinate1.Latitude = -10;
            Coordinate coordinate2 = new Coordinate();
            coordinate2.Longitude = 10;
            coordinate2.Latitude = 10;

            sut.Add(coordinate1);
            sut.Add(coordinate2);

            int index = sut.GetNearestIndex(1, 1);
            Assert.AreEqual(1, index);
        }
    }
}
