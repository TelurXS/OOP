namespace LR3.Numbers;

public abstract class Number : IComparable<Number>, IEquatable<Number>
{
    public Number(double value)
    {
        Value = value;
    }

    public double Value { get; }

    public abstract Number Add(Number number);

    public abstract Number Subtract(Number number);

    public abstract Number Multiply(Number number);

    public abstract Number Divide(Number number);

    public abstract int CompareTo(Number? other);

    public abstract bool Equals(Number? other);

	public static Number operator + (Number left, Number right) => left.Add(right);
                                    
    public static Number operator - (Number left, Number right) => left.Subtract(right);
                                    
    public static Number operator * (Number left, Number right) => left.Multiply(right);
                                    
    public static Number operator / (Number left, Number right) => left.Divide(right);

}
