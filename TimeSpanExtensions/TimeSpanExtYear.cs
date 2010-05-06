using System;

namespace TimeSpanExtensions
{
  public class TimeSpanExtYear : TimeSpanExt
  {
    public int Value { get; private set; }

    public TimeSpanExtYear(int value) { Value = value; }

	public override DateTime AddTo(DateTime dt)
	{
      return dt.AddYears((int)(scalar * Value));
	}

	public override DateTime SubtractFrom(DateTime dt)
	{
      return dt.AddYears(-((int)(scalar * Value)));
	}
  }
}
