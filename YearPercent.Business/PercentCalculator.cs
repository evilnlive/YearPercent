namespace YearPercent.Business
{
    using System;

    using YearPercent.Business.Interfaces;

    public class PercentCalculator : IPercentCalculator
    {
        private readonly IDateProvider _dateProvider;

        private readonly ISecondsCalculator _secondsCalculator;

        public PercentCalculator(IDateProvider dateProvider, ISecondsCalculator secondsCalculator)
        {
            _dateProvider = dateProvider;

            _secondsCalculator = secondsCalculator;
        }

        public double PercentOfCurrentYearRightNow()
        {
            int numberOfSecondsIntoTheYear = _secondsCalculator.NumberOfSecondsIntoTheYear(_dateProvider.Now);
            int totalNumberOfSecondsInCurrentYear = _secondsCalculator.TotalNumberOfSecondsInYear(
                _dateProvider.Now.Year);

            return Math.Round(numberOfSecondsIntoTheYear / (double)totalNumberOfSecondsInCurrentYear * 100, 1);
        }
    }
}