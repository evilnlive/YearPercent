namespace YearPercent.Business
{
    using System;

    using YearPercent.Business.Interfaces;

    public class SecondsCalculator : ISecondsCalculator
    {
        public int TotalNumberOfSecondsInYear(int year)
        {
            var firstDayOfTheYear = new DateTime(year, 1, 1);
            var lastDayOfTheYear = firstDayOfTheYear.AddYears(1);
            
            return (int)(lastDayOfTheYear - firstDayOfTheYear).TotalSeconds;
        }

        public int NumberOfSecondsIntoTheYear(DateTime dateTime)
        {
            return (int)(dateTime - new DateTime(dateTime.Year, 1, 1)).TotalSeconds;
        }
    }
}