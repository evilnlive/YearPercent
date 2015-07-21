namespace YearPercent.Business.Interfaces
{
    using System;

    public interface IDateProvider
    {
        DateTime Now { get; }
    }
}