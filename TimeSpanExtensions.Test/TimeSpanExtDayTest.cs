using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtDayTest and is intended
    ///to contain all TimeSpanExtDayTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtDayTest
  {

    [TestMethod()]
    public void TimeSpanExtDay_create()
    {
      int testInt = 3;
      float testFloat = 3.5F;
      double testDouble = 3.79;
      decimal testDecimal = 3.1415M;

      Assert.AreEqual(testInt, (int)(new TimeSpanExtDay(testInt)).Value);
      Assert.AreEqual(testFloat, (float)(new TimeSpanExtDay(testFloat)).Value);
      Assert.AreEqual(testDouble, (Double)(new TimeSpanExtDay(testDouble)).Value);
      Assert.AreEqual(testDecimal, (new TimeSpanExtDay(testDecimal)).Value);
    }

    [TestMethod()]
    public void TimeSpanExtDayTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 2.521186343M;
      TimeSpanExtDay edt = new TimeSpanExtDay(value);
      DateTime expected = new DateTime(2000, 1, 3, 12, 30, 30, 500);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);    
    }

    [TestMethod()]
    public void TimeSpanExtDayTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2000, 1, 3, 12, 30, 30, 500);
      Decimal value = 2.521186343M;
      TimeSpanExtDay edt = new TimeSpanExtDay(value);
      DateTime expected = new DateTime(2000, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual); 
    }

    [TestMethod()]
    public void TimeSpanExtDayTest_leap_year()
    {
      DateTime dt = new DateTime(2000, 2, 28);
      Decimal value = 1M;
      TimeSpanExtDay edt = new TimeSpanExtDay(value);
      DateTime expected = new DateTime(2000, 2, 29);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);    
    }

    [TestMethod()]
    public void TimeSpanExtDayTest_non_leap_year()
    {
      DateTime dt = new DateTime(2001, 2, 28);
      Decimal value = 1M;
      TimeSpanExtDay edt = new TimeSpanExtDay(value);
      DateTime expected = new DateTime(2001, 3, 1);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);   
    }

	[TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtDay edt = new TimeSpanExtDay(1);
	  TimeSpanExtDay edt2 = new TimeSpanExtDay(2);
      DateTime expected = new DateTime(2000, 1, 4);

	  TimeSpanExt composite = edt + edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtDay edt = new TimeSpanExtDay(3);
	  TimeSpanExtDay edt2 = new TimeSpanExtDay(2);
      DateTime expected = new DateTime(2000, 1, 2);

	  TimeSpanExt composite = edt - edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

  }
}
