using System;

namespace TimeSpanExtensions
{
    public class TimeSpanExtMonth : TimeSpanExt
    {
        public int Value { get; private set; }

        public TimeSpanExtMonth(int value) { Value = value; }


        public override DateTime AddTo(DateTime dt)
        {
            return dt.AddMonths((int)(scalar * Value));
        }

        public override DateTime SubtractFrom(DateTime dt)
        {
            return dt.AddMonths(-(int)(scalar * Value));
        }
    }
}
