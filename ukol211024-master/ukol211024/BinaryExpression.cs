public class BinaryExpression : IExpression
{
	protected IExpression Left;
	protected IExpression Right;
	public BinaryExpression(IExpression left,IExpression right)
	{
		Left = left;
		Right = right;
	}

	public abstract double Evaluate();
}
