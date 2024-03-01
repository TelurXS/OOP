namespace LR3.Numbers;

public sealed class Real : Number
{
	public Real(double value) : base(value)
	{
	}

	public override Number Add(Number number)
	{
		return new Real(Value + number.Value);
	}

	public override Number Subtract(Number number)
	{
		return new Real(Value - number.Value);
	}

	public override Number Multiply(Number number)
	{
		return new Real(Value * number.Value);
	}

	public override Number Divide(Number number)
	{
		return new Real(Value / number.Value);
	}

	public override int CompareTo(Number? other)
	{
		if (other is null)
			return -1;

		return Value.CompareTo(other.Value);
	}

	public override bool Equals(Number? other)
	{
		if (other is null)
			return false;

		return Value.Equals(other.Value);
	}

	public override string ToString() => Value.ToString();
}
