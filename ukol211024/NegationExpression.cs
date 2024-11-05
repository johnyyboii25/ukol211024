public class NegationExpression : UnaryExpression
{
	public NegationExpression(IExpression expression) : base(expression, "-") { }

	public override double Evaluate()
	{
		return -_expression.Evaluate();
	}
}
