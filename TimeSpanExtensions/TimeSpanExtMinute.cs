using System;

namespace TimeSpanExtensions
{
  public class TimeSpanExtMinute : TimeSpanExt
  {
    public decimal Value { get; private set; }

    public TimeSpanExtMinute(int value) { Value = value; }
    public TimeSpanExtMinute(float value) { Value = (Decimal)value; }
    public TimeSpanExtMinute(double value) { Value = (Decimal)value; }
    public TimeSpanExtMinute(decimal value) { Value = value; }

	public override DateTime AddTo(DateTime dt)
	{
      return dt.AddMinutes(Convert.ToDouble(Value * scalar));
	}

	public override DateTime SubtractFrom(DateTime dt)
    {
        return dt.AddMinutes(Convert.ToDouble(-(Value * scalar)));
	}
  }
}
