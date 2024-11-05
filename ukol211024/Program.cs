class Program
{
	static void Main(string[] args)
	{
		IExpression expression = new BinaryExpression(new Number(6),
			new BinaryExpression(new Number(6),
			new BinaryExpression(new Number(3),new Number(3), "^"), "*")
													,"+");
		expression.EvaluateAndString(expression);
	}
}

