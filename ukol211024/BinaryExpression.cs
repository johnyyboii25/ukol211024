public abstract class BinaryExpression : IExpression
{
	protected IExpression _left;
	protected IExpression _right;

	public BinaryExpression(IExpression left, IExpression right)
	{
		_left = left;
		_right = right;
	}

	public abstract double Evaluate();
}
