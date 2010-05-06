using System;

namespace TimeSpanExtensions
{
  public class TimeSpanExtSecond : TimeSpanExt
  {
    public decimal Value { get; private set; }

    public TimeSpanExtSecond(int value) { Value = value; }
    public TimeSpanExtSecond(float value) { Value = (Decimal)value; }
    public TimeSpanExtSecond(double value) { Value = (Decimal)value; }
    public TimeSpanExtSecond(decimal value) { Value = value; }

	public override DateTime AddTo(DateTime dt)
	{
        return dt.AddSeconds(Convert.ToDouble(Value * scalar));
    }

	public override DateTime SubtractFrom(DateTime dt)
	{
        return dt.AddSeconds(Convert.ToDouble(-(Value * scalar)));
    }
  }
}
