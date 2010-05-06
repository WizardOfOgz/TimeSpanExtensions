using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtHourTest and is intended
    ///to contain all TimeSpanExtHourTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtHourTest
  {

    [TestMethod()]
    public void TimeSpanExtHour_create()
    {
      int testInt = 3;
      float testFloat = 3.5F;
      double testDouble = 3.79;
      decimal testDecimal = 3.1415M;

      Assert.AreEqual(testInt, (int)(new TimeSpanExtHour(testInt)).Value);
      Assert.AreEqual(testFloat, (float)(new TimeSpanExtHour(testFloat)).Value);
      Assert.AreEqual(testDouble, (Double)(new TimeSpanExtHour(testDouble)).Value);
      Assert.AreEqual(testDecimal, (new TimeSpanExtHour(testDecimal)).Value);
    }

    [TestMethod()]
    public void TimeSpanExtHourTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 25.5101M;
      TimeSpanExtHour edt = new TimeSpanExtHour(value);
      DateTime expected = new DateTime(2000, 1, 2, 1, 30, 36, 360);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtHourTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2000, 1, 2, 1, 30, 36, 360);
      Decimal value = 25.5101M;
      TimeSpanExtHour edt = new TimeSpanExtHour(value);
      DateTime expected = new DateTime(2000, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

	[TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtHour edt = new TimeSpanExtHour(1);
	  TimeSpanExtHour edt2 = new TimeSpanExtHour(2);
      DateTime expected = new DateTime(2000, 1, 1, 3, 0, 0, 0);

	  TimeSpanExt composite = edt + edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtHour edt = new TimeSpanExtHour(3);
	  TimeSpanExtHour edt2 = new TimeSpanExtHour(2);
      DateTime expected = new DateTime(2000, 1, 1, 1, 0, 0, 0);

	  TimeSpanExt composite = edt - edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}
  }
}
