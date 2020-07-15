using System;

namespace GuardProject.Common
{
    public class DateTimeHelper: IDateTimeHelper
    {
        public DateTime CurrentTimeStamp()
        {
            return DateTime.Now;
        }
    }
}