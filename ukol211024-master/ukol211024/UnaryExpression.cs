public abstract class UnaryExpression : IExpression
{
	protected IExpression Operand;
	protected UnaryExpression(IExpression operand)
	{
		Operand = operand;
	}

	public abstract double Evaluate();
}