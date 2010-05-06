using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TimeSpanExtensions.Test
{
    
    /// <summary>
    ///This is a test class for TimeSpanExtensionsTest and is intended
    ///to contain all TimeSpanExtensionsTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TimeSpanExtensionsTest
  {

    [TestMethod()]
    public void YearsTest()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      int value = 2;
      DateTime expected = new DateTime(2002, 1, 1);

      DateTime actual;
      actual = dt + value.Years();

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MonthsTest()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      int value = 2;
      DateTime expected = new DateTime(2000, 3, 1);

      DateTime actual;
      actual = dt + value.Months();

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void WeeksTest()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      int value = 2;
      DateTime expected = new DateTime(2000, 1, 15);

      DateTime actual;
      actual = dt + value.Weeks();

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void DaysTest()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 2.521186343M;
      DateTime expected = new DateTime(2000, 1, 3, 12, 30, 30, 500);

      DateTime actual;
      actual = dt + value.Days();

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void HoursTest()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 25.5101M;
      DateTime expected = new DateTime(2000, 1, 2, 1, 30, 36, 360);

      DateTime actual;
      actual = dt + value.Hours();

      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MinutesTest()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 1470.505M;
      DateTime expected = new DateTime(2000, 1, 2, 0, 30, 30, 300);

      DateTime actual;
      actual = dt + value.Minutes();

      Assert.AreEqual(expected, actual);   
    }

    [TestMethod()]
    public void SecondsTest()
    {
      DateTime dt = new DateTime(2000, 1, 1);
      Decimal value = 3693.333M;
      DateTime expected = new DateTime(2000, 1, 1, 1, 1, 33, 333);

      DateTime actual;
      actual = dt + value.Seconds();

      Assert.AreEqual(expected, actual);    
    }

    [TestMethod()]
    public void MillisecondsTest()
    {
        DateTime dt = new DateTime(2000, 1, 1);
        int value = 2222;
        DateTime expected = new DateTime(2000, 1, 1, 0, 0, 2, 222);

        DateTime actual;
        actual = dt + value.Milliseconds();

        Assert.AreEqual(expected, actual);
    }     
  }
}
