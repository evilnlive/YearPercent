namespace YearPercent.Business.Tests
{
    using System;

    using FakeItEasy;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using YearPercent.Business.Interfaces;

    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CanGetPercentageOfCurrentYear()
        {
            var dateProviderFake = A.Fake<IDateProvider>();
            var secondsCalculatorFake = A.Fake<ISecondsCalculator>();

            A.CallTo(() => dateProviderFake.Now).Returns(new DateTime(2015, 4, 15));

            A.CallTo(() => secondsCalculatorFake.NumberOfSecondsIntoTheYear(dateProviderFake.Now))
                .Returns(8985600);
            
            A.CallTo(() => secondsCalculatorFake.TotalNumberOfSecondsInYear(dateProviderFake.Now.Year))
                .Returns(31536000);

            var percentCalculator = new PercentCalculator(dateProviderFake, secondsCalculatorFake);

            double percent = percentCalculator.PercentOfCurrentYearRightNow();

            Assert.AreEqual(28.5, percent);
        }
    }
}