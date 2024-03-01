namespace LR3.Numbers;

public sealed class Integer : Number
{
	public Integer(double value) : base(Math.Floor(value))
	{

	}

	public override Number Add(Number number)
	{
		return new Integer(Value + number.Value);
	}

	public override Number Subtract(Number number)
	{
		return new Integer(Value - number.Value);
	}

	public override Number Multiply(Number number)
	{
		return new Integer(Value * number.Value);
	}

	public override Number Divide(Number number)
	{
		return new Integer(Value / number.Value);
	}

	public override int CompareTo(Number? other)
	{
		if (other is null)
			return -1;

		return ((int)Value).CompareTo(((int)other.Value));
	}

	public override bool Equals(Number? other)
	{
		if (other is null)
			return false;

		return ((int)Value).Equals(((int)other.Value));
	}

	public override string ToString() => ((int)Value).ToString();
}
