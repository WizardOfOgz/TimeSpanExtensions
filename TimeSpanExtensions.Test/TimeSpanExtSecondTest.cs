using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpanExtSecondTest and is intended
    ///to contain all TimeSpanExtSecondTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtSecondTest
  {

    [TestMethod()]
    public void TimeSpanExtSecond_create()
    {
      int testInt = 3;
      float testFloat = 3.5F;
      double testDouble = 3.79;
      decimal testDecimal = 3.1415M;

      Assert.AreEqual(testInt, (int)(new TimeSpanExtSecond(testInt)).Value);
      Assert.AreEqual(testFloat, (float)(new TimeSpanExtSecond(testFloat)).Value);
      Assert.AreEqual(testDouble, (Double)(new TimeSpanExtSecond(testDouble)).Value);
      Assert.AreEqual(testDecimal, (new TimeSpanExtSecond(testDecimal)).Value);
    }

    [TestMethod()]
    public void TimeSpanExtSecondTest_addition_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 3693.333M;
      TimeSpanExtSecond edt = new TimeSpanExtSecond(value);
      DateTime expected = new DateTime(2000, 1, 1, 1, 1, 33, 333);

      DateTime actual;
      actual = dt + edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void TimeSpanExtSecondTest_subtraction_operator()
    {
      DateTime dt = new DateTime(2000, 1, 1, 1, 1, 33, 333);
      Decimal value = 3693.333M;
      TimeSpanExtSecond edt = new TimeSpanExtSecond(value);
      DateTime expected = new DateTime(2000, 1, 1);

      DateTime actual;
      actual = dt - edt;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
	public void Addition_with_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      TimeSpanExtSecond edt = new TimeSpanExtSecond(1);
      TimeSpanExtSecond edt2 = new TimeSpanExtSecond(2);
      DateTime expected = new DateTime(2000, 1, 1, 0, 0, 3);

	  TimeSpanExt composite = edt + edt2;
      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
	public void Subtraction_from_TimeSpanExtBase_returns_a_valid_TimeSpanExtBase()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      TimeSpanExtSecond edt = new TimeSpanExtSecond(3);
      TimeSpanExtSecond edt2 = new TimeSpanExtSecond(2);
      DateTime expected = new DateTime(2000, 1, 1, 0, 0, 1);

	  TimeSpanExt composite = edt - edt2;
      DateTime actual;
      actual = dt + composite;

      Assert.AreEqual(expected, actual);
    }

  }
}
