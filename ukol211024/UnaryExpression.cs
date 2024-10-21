public abstract class UnaryExpression : IExpression
{
	protected IExpression _expression;

	public UnaryExpression(IExpression expression)
	{
		_expression = expression;
	}

	public abstract double Evaluate();
}