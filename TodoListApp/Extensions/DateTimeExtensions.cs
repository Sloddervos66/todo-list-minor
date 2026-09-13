namespace TodoListApp.Extensions;

public static class DateTimeExtensions
{
    extension(DateTime value)
    {
        public DateTime ToQuarterHour()
        {
            var minutes = (int)Math.Round(
                value.Minute / 15.0,
                MidpointRounding.AwayFromZero) * 15;

            return new DateTime(
                value.Year,
                value.Month,
                value.Day,
                value.Hour,
                0,
                0,
                value.Kind
            ).AddMinutes(minutes);
        }

        public bool IsQuarterHour()
        {
            return value.Minute % 15 == 0 &&
                   value is { Second: 0, Microsecond: 0 };
        }
    }
}