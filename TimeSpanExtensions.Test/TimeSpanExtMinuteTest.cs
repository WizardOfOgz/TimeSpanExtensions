using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtMinuteTest and is intended
    ///to contain all TimeSpanExtMinuteTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtMinuteTest
  {

    [TestMethod()]
    public void TimeSpanExtMinute_create()
    {
      int testInt = 3;
      float testFloat = 3.5F;
      double testDouble = 3.79;
      decimal testDecimal = 3.1415M;

      Assert.AreEqual(testInt, (int)(new TimeSpanExtMinute(testInt)).Value);
      Assert.AreEqual(testFloat, (float)(new TimeSpanExtMinute(testFloat)).Value);
      Assert.AreEqual(testDouble, (Double)(new TimeSpanExtMinute(testDouble)).Value);
      Assert.AreEqual(testDecimal, (new TimeSpanExtMinute(testDecimal)).Value);
    }

    [TestMethod()]
    public void TimeSpanExtMinuteTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 1470.505M;
      TimeSpanExtMinute edt = new TimeSpanExtMinute(value);
      DateTime expected = new DateTime(2000, 1, 2, 0, 30, 30, 300);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMinuteTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2000, 1, 2, 0, 30, 30, 300);
      Decimal value = 1470.505M;
      TimeSpanExtMinute edt = new TimeSpanExtMinute(value);
      DateTime expected = new DateTime(2000, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }
	
	[TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1);
      TimeSpanExtMinute edt = new TimeSpanExtMinute(1);
	  TimeSpanExtMinute edt2 = new TimeSpanExtMinute(2);
      DateTime expected = new DateTime(2000, 1, 1, 0, 3, 0);

	  TimeSpanExt composite = edt + edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtMinute edt = new TimeSpanExtMinute(3);
	  TimeSpanExtMinute edt2 = new TimeSpanExtMinute(2);
      DateTime expected = new DateTime(2000, 1, 1, 0, 1, 0);

	  TimeSpanExt composite = edt - edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}
  }
}
