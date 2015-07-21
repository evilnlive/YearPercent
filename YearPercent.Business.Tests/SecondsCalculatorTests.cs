namespace YearPercent.Business.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SecondsCalculatorTests
    {
        [TestMethod]
        public void CanGetNumberOfSecondsInAYear()
        {
            var cal = new SecondsCalculator();

            int secs = cal.TotalNumberOfSecondsInYear(2015);

            Assert.AreEqual(31536000, secs);
        }

        [TestMethod]
        public void CanGetNumberOfSecondsOfCurrentYear()
        {
            var cal = new SecondsCalculator();

            int secs = cal.NumberOfSecondsIntoTheYear(new DateTime(2015, 4, 15));

            Assert.AreEqual(8985600, secs);
        }
    }
}