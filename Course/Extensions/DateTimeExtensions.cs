using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        public static string TimeElapse(this DateTime obj)
        {
            TimeSpan duration = DateTime.Now.Subtract(obj);

            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
