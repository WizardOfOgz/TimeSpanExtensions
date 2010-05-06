using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtMonthTest and is intended
    ///to contain all TimeSpanExtMonthTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtMonthTest
  {

    [TestMethod()]
    public void TimeSpanExtMonth_create()
    {
      int testInt = 3;
      Assert.AreEqual(testInt, (new TimeSpanExtMonth(testInt)).Value);
    }

    [TestMethod()]
    public void TimeSpanExtMonthTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      int value = 2;
      TimeSpanExtMonth edt = new TimeSpanExtMonth(value);
      DateTime expected = new DateTime(2000, 3, 1);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMonthTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2000, 3, 1);
      int value = 2;
      TimeSpanExtMonth edt = new TimeSpanExtMonth(value);
      DateTime expected = new DateTime(2000, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMonthTest_should_result_in_last_day_of_the_month_for_day_that_is_out_of_upper_range_for_the_resulting_month()
    {
      DateTime dt = new DateTime(2000, 3, 31);
      int value = 1;
      TimeSpanExtMonth edt = new TimeSpanExtMonth(value);
      DateTime expected = new DateTime(2000, 2, 29);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);

      TimeSpanExtMonth edt2 = new TimeSpanExtMonth(1);
      expected = new DateTime(2000, 4, 30);
      actual = dt + edt2;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMonthTest_across_year_boundary_forward()
    {
      DateTime dt = new DateTime(2000, 1, 31);
      int value = 49;
      TimeSpanExtMonth edt = new TimeSpanExtMonth(value);
      DateTime expected = new DateTime(2004, 2, 29);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMonthTest_across_year_boundary_backward()
    {
      DateTime dt = new DateTime(2001, 3, 31);
      int value = 25;
      TimeSpanExtMonth edt = new TimeSpanExtMonth(value);
      DateTime expected = new DateTime(1999, 2, 28);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMonthTest_addition_operator_with_large_negative_value()
    {
      DateTime dt = new DateTime(2002, 1, 1);
      int value = -22;
      TimeSpanExtMonth edt = new TimeSpanExtMonth(value);
      DateTime expected = new DateTime(2000, 3, 1);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtMonthTest_subtraction_operator_with_large_negative_value()
    {
      DateTime dt = new DateTime(2000, 3, 1);
      int value = -22;
      TimeSpanExtMonth edt = new TimeSpanExtMonth(value);
      DateTime expected = new DateTime(2002, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

	[TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtMonth edt = new TimeSpanExtMonth(1);
	  TimeSpanExtMonth edt2 = new TimeSpanExtMonth(2);
      DateTime expected = new DateTime(2000, 4, 1);

	  TimeSpanExt composite = edt + edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}

	[TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
	{	  
      DateTime dt = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      TimeSpanExtMonth edt = new TimeSpanExtMonth(3);
	  TimeSpanExtMonth edt2 = new TimeSpanExtMonth(2);
      DateTime expected = new DateTime(2000, 2, 1);

	  TimeSpanExt composite = edt - edt2;

      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
	}
  }
}
