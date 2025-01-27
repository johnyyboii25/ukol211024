public class N : IExpression
{
	private readonly double _value;
	public N(double value)
	{
		_value = value;
	}

	public double Evaluate()
	{
		return _value;
	}
}