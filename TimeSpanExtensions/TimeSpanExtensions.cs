using System;

namespace TimeSpanExtensions
{
  public static class TimeSpanExtensions
  {
    public static TimeSpanExtYear Year(this int numYears) { return new TimeSpanExtYear(numYears); }
    public static TimeSpanExtYear Years(this int numYears) { return Year(numYears); }

    public static TimeSpanExtMonth Month(this int numMonths) { return new TimeSpanExtMonth(numMonths); }
    public static TimeSpanExtMonth Months(this int numMonths) { return Month(numMonths); }
    
    public static TimeSpanExtWeek Week(this int numWeeks) { return new TimeSpanExtWeek(numWeeks); }
    public static TimeSpanExtWeek Weeks(this int numWeeks) { return Week(numWeeks); }

    public static TimeSpanExtDay Day(this int numDays) { return new TimeSpanExtDay(numDays); }
    public static TimeSpanExtDay Day(this float numDays) { return new TimeSpanExtDay(numDays); }
    public static TimeSpanExtDay Day(this Double numDays) { return new TimeSpanExtDay(numDays); }
    public static TimeSpanExtDay Day(this Decimal numDays) { return new TimeSpanExtDay(numDays); }
    public static TimeSpanExtDay Days(this int numDays) { return Day(numDays); }
    public static TimeSpanExtDay Days(this float numDays) { return Day(numDays); }
    public static TimeSpanExtDay Days(this Double numDays) { return Day(numDays); }
    public static TimeSpanExtDay Days(this Decimal numDays) { return Day(numDays); }

    public static TimeSpanExtHour Hour(this int numHours) { return new TimeSpanExtHour(numHours); }
    public static TimeSpanExtHour Hour(this float numHours) { return new TimeSpanExtHour(numHours); }
    public static TimeSpanExtHour Hour(this Double numHours) { return new TimeSpanExtHour(numHours); }
    public static TimeSpanExtHour Hour(this Decimal numHours) { return new TimeSpanExtHour(numHours); }
    public static TimeSpanExtHour Hours(this int numHours) { return Hour(numHours); }
    public static TimeSpanExtHour Hours(this float numHours) { return Hour(numHours); }
    public static TimeSpanExtHour Hours(this Double numHours) { return Hour(numHours); }
    public static TimeSpanExtHour Hours(this Decimal numHours) { return Hour(numHours); }

    public static TimeSpanExtMinute Minute(this int numMinutes) { return new TimeSpanExtMinute(numMinutes); }
    public static TimeSpanExtMinute Minute(this float numMinutes) { return new TimeSpanExtMinute(numMinutes); }
    public static TimeSpanExtMinute Minute(this Double numMinutes) { return new TimeSpanExtMinute(numMinutes); }
    public static TimeSpanExtMinute Minute(this Decimal numMinutes) { return new TimeSpanExtMinute(numMinutes); }
    public static TimeSpanExtMinute Minutes(this int numMinutes) { return Minute(numMinutes); }
    public static TimeSpanExtMinute Minutes(this float numMinutes) { return Minute(numMinutes); }
    public static TimeSpanExtMinute Minutes(this Double numMinutes) { return Minute(numMinutes); }
    public static TimeSpanExtMinute Minutes(this Decimal numMinutes) { return Minute(numMinutes); }
    
    public static TimeSpanExtSecond Second(this int numSeconds) { return new TimeSpanExtSecond(numSeconds); }
    public static TimeSpanExtSecond Second(this float numSeconds) { return new TimeSpanExtSecond(numSeconds); }
    public static TimeSpanExtSecond Second(this Double numSeconds) { return new TimeSpanExtSecond(numSeconds); }
    public static TimeSpanExtSecond Second(this Decimal numSeconds) { return new TimeSpanExtSecond(numSeconds); }
    public static TimeSpanExtSecond Seconds(this int numSeconds) { return Second(numSeconds); }
    public static TimeSpanExtSecond Seconds(this float numSeconds) { return Second(numSeconds); }
    public static TimeSpanExtSecond Seconds(this Double numSeconds) { return Second(numSeconds); }
    public static TimeSpanExtSecond Seconds(this Decimal numSeconds) { return Second(numSeconds); }

    public static TimeSpanExtMillisecond Millisecond(this int numMilliseconds) { return new TimeSpanExtMillisecond(numMilliseconds); }
    public static TimeSpanExtMillisecond Milliseconds(this int numMilliseconds) { return Millisecond(numMilliseconds); }
  }
}
