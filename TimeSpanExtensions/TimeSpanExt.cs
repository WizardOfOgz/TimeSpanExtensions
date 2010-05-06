using System;

namespace TimeSpanExtensions
{
  /// <summary>
  /// 
  /// </summary>
  public abstract class TimeSpanExt
  {
	/// <summary>
	/// Used to indicated what operation to perform on the right operand, if one is stored.
	/// </summary>
	private enum Operation
	{
	  Addition, Subtraction
	}

	/// <summary>
	/// stores a reference to a right operand if this instance has
	/// another TimeSpanExt instance added or subtracted to it.
	/// In this way chains of operations can be created.
	/// </summary>
	protected TimeSpanExt rightOperand = null;
	Operation operation;
	protected decimal scalar = 1.0M; // Identity by default
	
	/// <summary>
	/// Adds two TimeSpanExt instances together
	/// </summary>
	/// <param name="dteb1"></param>
	/// <param name="dteb2"></param>
	/// <returns></returns>
	/// <remarks>
	/// When two TimeSpanExt instances are added together it is important that
	/// their order is preserved.  Both operands are cloned (necessary to avoid
	/// self- and cyclical references.  Notice that the right operand may not be
	/// cloned immediately.  The right operand should actually be appended to the
	/// end of the chain of operations from the left operand.  Cloning is deferred
	/// until reaching the end of the chain.
	/// </remarks>
	public static TimeSpanExt operator +(TimeSpanExt left, TimeSpanExt right)
	{
	  TimeSpanExt clone1 = left.Clone();

	  if (clone1.rightOperand == null)
	  {
		// There is no pre-existing rightOperand for the left operand
		TimeSpanExt clone2 = right.Clone();
		clone1.rightOperand = clone2;
		clone1.operation = Operation.Addition;
	  }
	  else
	  {
		// The left operand already has a right operand.  Our current right operand should be placed
		// at the end of the chain of operations from the left operand, so pass the new right
		// operand to the existing one by addition --- in this way the new right operand will be placed
		// at the end of the left operand's chain of operations.  Re-read that a few times until it
		// makes sense :)
		clone1.rightOperand = clone1.rightOperand + right;
	  }

	  return clone1;
	}
	/// <summary>
	/// Subtracts one TimeSpanExt instance from another
	/// </summary>
	/// <param name="dteb1"></param>
	/// <param name="dteb2"></param>
	/// <returns></returns>
	/// <remarks>See the corresponding + operator</remarks>
	public static TimeSpanExt operator -(TimeSpanExt left, TimeSpanExt right)
	{
	  TimeSpanExt clone1 = left.Clone();

	  if (clone1.rightOperand == null) // There is no next
	  {
		TimeSpanExt clone2 = right.Clone();
		clone1.rightOperand = clone2;
		clone1.operation = Operation.Subtraction;
	  }
	  else
	  {
		clone1.rightOperand = clone1.rightOperand - right;
	  }

	  return clone1;
	}

	/// <summary>
	/// All subclasses must provide their own logic for adding themselves to
	/// an instance of DateTime.
	/// </summary>
	/// <param name="dt"></param>
	/// <returns></returns>
	public abstract DateTime AddTo(DateTime dt);
	/// <summary>
	/// All subclasses must provide their own logic for subtracting themselves
	/// from an instance of DateTime.
	/// </summary>
	/// <param name="dt"></param>
	/// <returns></returns>
	public abstract DateTime SubtractFrom(DateTime dt);

	public TimeSpanExt Multiply(int scalar)
	{
	  this.scalar *= scalar;
	  if (rightOperand != null)
		rightOperand.Multiply(scalar);
	  return this;
	}
	public TimeSpanExt Multiply(float scalar)
	{
	  this.scalar *= (Decimal)scalar;
	  if (rightOperand != null)
		rightOperand.Multiply(scalar);
	  return this;
	}
	public TimeSpanExt Multiply(double scalar)
	{
	  this.scalar *= (decimal)scalar;
	  if (rightOperand != null)
		rightOperand.Multiply(scalar);
	  return this;
	}
	public TimeSpanExt Multiply(decimal scalar)
	{
	  this.scalar *= scalar;
	  if (rightOperand != null)
		rightOperand.Multiply(scalar);
	  return this;
	}

	public static TimeSpanExt operator *(int value, TimeSpanExt dteb)
	{
	  TimeSpanExt result = dteb.Clone();
      result.Multiply(value);
	  return result;
	}
	public static TimeSpanExt operator *(float value, TimeSpanExt dteb)
	{
	  TimeSpanExt result = dteb.Clone();
	  result.Multiply(value);
	  return result;
	}
	public static TimeSpanExt operator *(double value, TimeSpanExt dteb)
	{
	  TimeSpanExt result = dteb.Clone();
	  result.Multiply(value);
	  return result;
	}
	public static TimeSpanExt operator *(decimal value, TimeSpanExt dteb)
	{
	  TimeSpanExt result = dteb.Clone();
	  result.Multiply(value);
	  return result;
	}
	public static TimeSpanExt operator *(TimeSpanExt dteb, int value)
	{
	  TimeSpanExt result = dteb.Clone();
	  result.Multiply(value);
	  return result;
	}
	public static TimeSpanExt operator *(TimeSpanExt dteb, float value)
	{
	  TimeSpanExt result = dteb.Clone();
	  result.Multiply(value);
	  return result;
	}
	public static TimeSpanExt operator *(TimeSpanExt dteb, double value)
	{
	  TimeSpanExt result = dteb.Clone();
	  result.Multiply(value);
	  return result;
	}
	public static TimeSpanExt operator *(TimeSpanExt dteb, decimal value)
	{
	  TimeSpanExt result = dteb.Clone();
	  result.Multiply(value);
	  return result;
	}

	/// <summary>
	/// Adds this to an instance of DateTime
	/// </summary>
	/// <param name="dt"></param>
	/// <param name="dteb"></param>
	/// <returns></returns>
	public static DateTime operator +(DateTime dt, TimeSpanExt dteb)
	{
	  // Add this to the DateTime
	  DateTime resultForCurrent = dteb.AddTo(dt);

	  if (dteb.rightOperand != null)
	  {
		// Add or subtract the right operand (recursive)
		if (dteb.operation == Operation.Addition)
		  resultForCurrent = resultForCurrent + dteb.rightOperand;
		else // Operation.Subtraction
		  resultForCurrent = resultForCurrent - dteb.rightOperand;
	  }

	  return resultForCurrent;
	}
	/// <summary>
	/// Subtract this from an instance of DateTime
	/// </summary>
	/// <param name="dt"></param>
	/// <param name="dteb"></param>
	/// <returns></returns>
	public static DateTime operator -(DateTime dt, TimeSpanExt dteb)
	{
	  // Subtract this from the DateTime
	  DateTime resultForCurrent = dteb.SubtractFrom(dt);

	  if (dteb.rightOperand != null)
	  {
		// Add or subtract the right operand (recursive)
		if (dteb.operation == Operation.Addition)
		  resultForCurrent = resultForCurrent - dteb.rightOperand;
		else // Operation.Subtraction
		  resultForCurrent = resultForCurrent + dteb.rightOperand;
	  }

	  return resultForCurrent;
	}

	public DateTime Ago { get { return DateTime.Now - this; } }
	public DateTime FromNow { get { return DateTime.Now + this; } }
	public DateTime Since(DateTime dt)
	{
	  return dt + this;
	}

	/// <summary>
	/// Creates a shallow copy of this TimeSpanExtBase object and it's right operand.
	/// This function is recursive and will propagate down the line of chained operands.
	/// </summary>
	/// <returns></returns>
	private TimeSpanExt Clone()
	{
	  TimeSpanExt dteb = (TimeSpanExt)this.MemberwiseClone();

	  if (rightOperand != null)
	  {
		dteb.rightOperand = rightOperand.Clone();
	  }

	  return dteb;
	}
  }
}
