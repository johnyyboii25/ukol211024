public class BinaryExpression : IExpression
{
	protected IExpression _left;
	protected IExpression _right;
	private string _operator;

	public BinaryExpression(IExpression left, IExpression right, string operatorSymbol)
	{
		_left = left;
		_right = right;
		_operator = operatorSymbol;
	}

	public double Evaluate()
	{
		return _operator switch
		{
			"+" => _left.Evaluate() + _right.Evaluate(),
			"-" => _left.Evaluate() - _right.Evaluate(),
			"*" => _left.Evaluate() * _right.Evaluate(),
			"/" => _left.Evaluate() / _right.Evaluate(),
			_ => throw new InvalidOperationException("Unknown operator")
		};
	}
	public string GetString()
	{
		return $"({_left.GetString()}{_operator}{_right.GetString()})";
	}
}
