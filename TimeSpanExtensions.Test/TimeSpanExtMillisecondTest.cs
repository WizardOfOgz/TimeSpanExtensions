using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtMillisecondTest and is intended
    ///to contain all TimeSpanExtMillisecondTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtMillisecondTest
  {

    [TestMethod()]
    public void TimeSpanExtMillisecond_create()
    {
      int testInt = 3;
      Assert.AreEqual(testInt, (new TimeSpanExtMillisecond(testInt)).Value);
    }

    [TestMethod()]
    public void TimeSpanExtMillisecondTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      int value = 2222;
      TimeSpanExtMillisecond edt = new TimeSpanExtMillisecond(value);
      DateTime expected = new DateTime(2000, 1, 1, 0, 0, 2, 222);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMillisecondTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 2, 222);
      int value = 2222;
      TimeSpanExtMillisecond edt = new TimeSpanExtMillisecond(value);
      DateTime expected = new DateTime(2000, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

	[TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtMillisecond edt = new TimeSpanExtMillisecond(1);
	  TimeSpanExtMillisecond edt2 = new TimeSpanExtMillisecond(2);
      DateTime expected = new DateTime(2000, 1, 1, 0, 0, 0, 3);

	  TimeSpanExt composite = edt + edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtMillisecond edt = new TimeSpanExtMillisecond(3);
	  TimeSpanExtMillisecond edt2 = new TimeSpanExtMillisecond(2);
      DateTime expected = new DateTime(2000, 1, 1, 0, 0, 0, 1);

	  TimeSpanExt composite = edt - edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}
  }
}
