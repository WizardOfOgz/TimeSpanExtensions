using System;

namespace TimeSpanExtensions
{
  public class TimeSpanExtDay : TimeSpanExt
  {
    public decimal Value { get; private set; }

    public TimeSpanExtDay(int value) { Value = value; }
    public TimeSpanExtDay(float value) { Value = (Decimal)value; }
    public TimeSpanExtDay(double value) { Value = (Decimal)value; }
    public TimeSpanExtDay(decimal value) { Value = value; }

	public override DateTime AddTo(DateTime dt)
	{
      return dt.AddDays(Convert.ToDouble(Value * scalar));
	}

	public override DateTime SubtractFrom(DateTime dt)
	{
      return dt.AddDays(Convert.ToDouble(-(Value * scalar)));
	}
  }
}
