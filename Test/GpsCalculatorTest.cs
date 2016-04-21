using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoutereetView;

namespace Test
{
    /// <summary>
    /// GpsCalculatorTest の概要の説明
    /// </summary>
    [TestClass]
    public class GpsCalculatorTest
    {
        [TestMethod]
        public void TesHeading()
        {
            // http://www.igismap.com/formula-to-find-bearing-or-heading-angle-between-two-points-latitude-longitude/
            Coordinate from = new Coordinate();
            from.Latitude = 39.099912;
            from.Longitude = -94.581213;

            Coordinate to = new Coordinate();
            to.Latitude = 38.627089;
            to.Longitude = -90.200203;

            double heading = GpsCalculator.Heading(from, to);

            Assert.IsTrue(96.50 < heading && heading < 96.52,
                "expected : 96.51 result : " + heading.ToString()); //96.51
        }
    }
}
