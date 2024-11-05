class Program
{
	static void Main(string[] args)
	{
		//(-3+7)*2
		IExpression expression = new BinaryExpression(new Number(6),
			new BinaryExpression(new Number(6),
			new BinaryExpression(new Number(3),new Number(3), "^"), "*")
													,"+");
		Console.WriteLine($"{expression.GetString()} = {expression.Evaluate()} ");
	}
}

