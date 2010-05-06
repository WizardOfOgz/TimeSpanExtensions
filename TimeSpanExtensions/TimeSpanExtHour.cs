using System;

namespace TimeSpanExtensions
{
  public class TimeSpanExtHour : TimeSpanExt
  {
    public decimal Value { get; private set; }

    public TimeSpanExtHour(int value) { Value = value; }
    public TimeSpanExtHour(float value) { Value = (Decimal)value; }
    public TimeSpanExtHour(double value) { Value = (Decimal)value; }
    public TimeSpanExtHour(decimal value) { Value = value; }

	public override DateTime AddTo(DateTime dt)
	{
      return dt.AddHours(Convert.ToDouble(Value * scalar));
	}

	public override DateTime SubtractFrom(DateTime dt)
	{
        return dt.AddHours(Convert.ToDouble(-(Value * scalar)));
	}
  }
}
