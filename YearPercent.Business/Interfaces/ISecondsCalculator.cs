namespace YearPercent.Business.Interfaces
{
    using System;

    public interface ISecondsCalculator
    {
        int TotalNumberOfSecondsInYear(int year);

        int NumberOfSecondsIntoTheYear(DateTime dateTime);
    }
}