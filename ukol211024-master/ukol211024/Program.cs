class Program
{
	static void Main(string[] args)
	{
		//(((3 - 5) * (-4) + 12) / 3 )^3
		IExpression expression = new BinaryExpression
		(new ExponentiationExp
		(new DivisionExp
		(new AdditionExp
		(new MultiplicationExp
		(new SubstractionExp(new N(3),new N(5)),
		new NegationExp(new N(4))),
		new N(12)),
		new N(3)),
		new N(3)));
		Console.WriteLine(expression.Evaluate(expression));
	}
}


