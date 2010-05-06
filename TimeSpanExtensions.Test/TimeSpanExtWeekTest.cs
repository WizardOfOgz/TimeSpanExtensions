using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtWeekTest and is intended
    ///to contain all TimeSpanExtWeekTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtWeekTest
  {

    [TestMethod()]
    public void TimeSpanExtWeek_create()
    {
      int testInt = 3;
      Assert.AreEqual(testInt, (new TimeSpanExtWeek(testInt)).Value);
    }

    [TestMethod()]
    public void TimeSpanExtWeekTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      int value = 2;
      TimeSpanExtWeek edt = new TimeSpanExtWeek(value);
      DateTime expected = new DateTime(2000, 1, 15);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);   
    }

    [TestMethod()]
    public void TimeSpanExtWeekTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2000, 1, 15);
      int value = 2;
      TimeSpanExtWeek edt = new TimeSpanExtWeek(value);
      DateTime expected = new DateTime(2000, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

	[TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtWeek edt = new TimeSpanExtWeek(1);
	  TimeSpanExtWeek edt2 = new TimeSpanExtWeek(2);
      DateTime expected = new DateTime(2000, 1, 22);

	  TimeSpanExt composite = edt + edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtWeek edt = new TimeSpanExtWeek(3);
	  TimeSpanExtWeek edt2 = new TimeSpanExtWeek(2);
      DateTime expected = new DateTime(2000, 1, 8);

	  TimeSpanExt composite = edt - edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

  }
}
