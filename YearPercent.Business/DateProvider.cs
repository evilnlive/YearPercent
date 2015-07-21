namespace YearPercent.Business
{
    using System;

    using YearPercent.Business.Interfaces;

    public class DateProvider : IDateProvider
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}