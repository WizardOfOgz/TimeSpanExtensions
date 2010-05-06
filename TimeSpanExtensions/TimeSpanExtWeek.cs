using System;

namespace TimeSpanExtensions
{
  public class TimeSpanExtWeek : TimeSpanExt
  {
    public int Value { get; private set; }

    public TimeSpanExtWeek(int value) { Value = value; }


	public override DateTime AddTo(DateTime dt)
	{
      return dt.AddDays(Convert.ToDouble(7 * scalar * Value));

	}

	public override DateTime SubtractFrom(DateTime dt)
	{
	  return dt.AddDays(Convert.ToDouble(-(7 * scalar * Value)));
	}
  }
}
