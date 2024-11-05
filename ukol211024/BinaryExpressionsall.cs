public class AdditionExpression : BinaryExpression
{
	public AdditionExpression(IExpression left, IExpression right) : base(left, right, "+")
	{

	}

	public override double Evaluate()
	{
		return _left.Evaluate() + _right.Evaluate();
	}
}

public class SubtractionExpression : BinaryExpression
{
	public SubtractionExpression(IExpression left, IExpression right) : base(left, right, "-")
	{

	}

	public override double Evaluate()
	{
		return _left.Evaluate() - _right.Evaluate();
	}
}

public class MultiplicationExpresion : BinaryExpression
{
	public MultiplicationExpresion(IExpression left, IExpression right) : base(left, right, "*")
	{

	}

	public override double Evaluate()
	{
		return _left.Evaluate() * _right.Evaluate();
	}
}

public class DivisionExpression : BinaryExpression
{
	public DivisionExpression(IExpression left, IExpression right) : base(left, right, "/")
	{

	}

	public override double Evaluate()
	{
		return _left.Evaluate() / _right.Evaluate();
	}
}

public class ExponentiateExpression : BinaryExpression
{
	public ExponentiateExpression(IExpression left, IExpression right) : base(left, right, "^")
	{

	}

	public override double Evaluate()
	{
		return Math.Pow(_left.Evaluate(), _right.Evaluate());
	}
}