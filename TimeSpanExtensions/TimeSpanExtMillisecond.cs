using System;

namespace TimeSpanExtensions
{
  public class TimeSpanExtMillisecond : TimeSpanExt
  {
    public int Value { get; private set; }

    public TimeSpanExtMillisecond(int value) { Value = value; }

	public override DateTime AddTo(DateTime dt)
	{
        return dt.AddMilliseconds(Convert.ToDouble(Value * scalar));
    }

	public override DateTime SubtractFrom(DateTime dt)
	{
        return dt.AddMilliseconds(Convert.ToDouble(-(Value * scalar)));
    }
  }
}
