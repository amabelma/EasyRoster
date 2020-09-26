using System;

namespace Utilities
{
    public class DateTimeHelper: IDateTimeHelper
    {
        public DateTime CurrentTimeStamp()
        {
            return DateTime.Now;
        }
    }
}