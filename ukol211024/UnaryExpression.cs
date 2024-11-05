public abstract class UnaryExpression : IExpression
{
	protected IExpression _expression;
	private string _operator;

	public UnaryExpression(IExpression expression, string operatorSymbol)
	{
		this._expression = expression;
		this._operator = operatorSymbol;
	}

	public double Evaluate()
	{
		return _operator switch
		{
			"-" => -Evaluate(),
			_ => throw new InvalidOperationException("Unknown operator")
		};
	}
	public string GetString()
	{
		return $"({_operator}{_expression.GetString()})";
	}
}