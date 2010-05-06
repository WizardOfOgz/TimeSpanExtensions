using TimeSpanExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtBaseTest and is intended
    ///to contain all TimeSpanExtBaseTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtTest
  {

	[TestMethod()]
	public void Addition_operator_should_return_valid_TimeSpanExtBase_instance()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dt = new DateTime(2000, 1, 1);
	  
	  var composite = dteb1 + dteb2;
	  var result = dt + composite;
	  var expected = new DateTime(2000, 2, 2);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Addition_operator_should_work_in_chained_operation()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dteb3 = 1.Day();
	  var dt = new DateTime(2000, 3, 29);

	  var result = dt + dteb1 + dteb2 + dteb3;
	  var expected = new DateTime(2000, 5, 1);

	  Assert.AreEqual(expected, result);
	}
	[TestMethod()]
	public void Addition_of_composed_to_DateTime_should_return_valid_DateTime()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dt = new DateTime(2000, 1, 1);
	  
	  var composite = dteb1 + dteb2;
	  var result = dt + composite; // result
	  var expected = new DateTime(2000, 2, 2);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Addition_of_complex_composed_to_DateTime_should_return_valid_DateTime()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dt = new DateTime(2000, 1, 1);
	  
	  var composite = 2 * dteb2 - (5 * dteb1);
	  var result = dt + composite;
	  var expected = new DateTime(2000, 2, 25);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Subtraction_from_DateTime_should_return_valid_DateTime()
	{
	  var dteb = 1.Day();
	  var dt = new DateTime(2000, 1, 1);
	  
	  var result = dt - dteb;
	  var expected = new DateTime(1999, 12, 31);

	  Assert.AreEqual(expected, result); 
	}

	[TestMethod()]
	public void Subtraction_of_composed_from_DateTime_should_return_valid_DateTime()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dt = new DateTime(2000, 1, 1);
	  
	  var composite = dteb1 - dteb2;
	  var result = dt - composite; // result
	  var expected = new DateTime(2000, 1, 31);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Subtraction_of_complex_composed_from_DateTime_should_return_valid_DateTime()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dt = new DateTime(2000, 3, 29);
	  
	  var composite = dteb1 - (dteb2 + (2 * dteb1));
	  var result = dt - composite;
	  var expected = new DateTime(2000, 4, 30);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Subtraction_operator_should_return_valid_TimeSpanExtBase_instance()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dt = new DateTime(2000, 1, 1);
	  
	  var composite = dteb1 - dteb2;
	  var result = dt - composite;
	  var expected = new DateTime(2000, 1, 31);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Subtraction_operator_should_work_in_chained_operation()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dteb3 = 1.Day();
	  var dt = new DateTime(2000, 5, 1);

	  var result = dt - dteb1 - dteb2 - dteb3;
	  var expected = new DateTime(2000, 3, 29);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Multiplication_operator_on_left_should_return_valid_TimeSpanExtBase_instance()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dteb3 = 1.Day();
	  var dteb4 = 2.Years();
	  var dt = new DateTime(2000, 3, 29);
	  
	  var composite = dteb1 + dteb2 + dteb3 + dteb4;
	  composite = 2 * composite;
	  var result = dt + composite;
	  var expected = new DateTime(2004, 6, 2);

	  Assert.AreEqual(expected, result);
	}
	
	[TestMethod()]
	public void Multiplication_operator_on_right_should_return_valid_TimeSpanExtBase_instance()
	{
	  var dteb1 = 1.Day();
	  var dteb2 = 1.Month();
	  var dteb3 = 1.Day();
	  var dteb4 = 2.Years();
	  var dt = new DateTime(2000, 3, 29);
	  
	  var composite = dteb1 + dteb2 + dteb3 + dteb4;
	  composite = composite * 2;
	  var result = dt + composite;
	  var expected = new DateTime(2004, 6, 2);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Addition_operator_should_work_with_same_operand_on_left_and_right()
	{
	  var dteb = 1.Day();
	  var composite = dteb + dteb + dteb;
	  var dt = new DateTime(2000, 1, 1);

	  var result = dt + composite;
	  var expected = new DateTime(2000, 1, 4);

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Ago_should_return_valid_DateTime()
	{	  
	  var dte = 1.Month();

	  // Just compare the date components since the expected and result will
	  // never have _exactly_ the same tick count.
	  var result = dte.Ago.Date;
	  var expected = (DateTime.Now - 1.Month()).Date; // No need to test the - operator here, just check that Ago does its job

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void FromNow_should_return_valid_DateTime()
	{	  
	  var dte = 1.Week();

	  // Just compare the date components since the expected and result will
	  // never have _exactly_ the same tick count.
	  var result = dte.FromNow.Date;
	  var expected = (DateTime.Now + 1.Week()).Date; // No need to test the + operator here, just check that Ago does its job

	  Assert.AreEqual(expected, result);
	}

	[TestMethod()]
	public void Since_should_return_valid_DateTime()
	{
	  // No need to test the - operator here, just check that Ago does the job
	  var dte = 1.Month();
	  var date = new DateTime(2000, 3, 31);

	  // Just compare the date components since the expected and result will
	  // never have _exactly_ the same tick count.
	  var result = dte.Since(date); ;
	  var expected = new DateTime(2000,4,30);

	  Assert.AreEqual(expected, result);
	}
  }
}
