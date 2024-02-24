using System.Globalization;

namespace Elias.Common
{
    public static class DateToShamsi
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar persian = new PersianCalendar();
            return persian.GetYear(date) + "/" + persian.GetMonth(date).ToString("00") + "/" + persian.GetDayOfMonth(date).ToString("00");
        }
    }
}
