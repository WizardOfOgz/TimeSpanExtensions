using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtYearTest and is intended
    ///to contain all TimeSpanExtYearTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtYearTest
  {

    [TestMethod()]
    public void TimeSpanExtYearTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      int value = 3;
      TimeSpanExtYear edt = new TimeSpanExtYear(value);
      DateTime expected = new DateTime(2003, 1, 1);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtYearTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2003, 3, 1);
      int value = 3;
      TimeSpanExtYear edt = new TimeSpanExtYear(value);
      DateTime expected = new DateTime(2000, 3, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

	[TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtYear edt = new TimeSpanExtYear(1);
	  TimeSpanExtYear edt2 = new TimeSpanExtYear(2);
      DateTime expected = new DateTime(2003, 1, 1);

	  TimeSpanExt composite = edt + edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtYear edt = new TimeSpanExtYear(3);
	  TimeSpanExtYear edt2 = new TimeSpanExtYear(2);
      DateTime expected = new DateTime(2001, 1, 1);

	  TimeSpanExt composite = edt - edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}
  }
}
