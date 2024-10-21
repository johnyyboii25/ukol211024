class Program
{
	static void Main(string[] args)
	{
		//(-3+7)*2
		IExpression expression = new DivisionExpression(new AdditionExpression(new NegationExpression(new Number(3)),new Number(7)),new Number(2));
		//[(-5+6.9*8)/8]^4
		IExpression expression1 = new ExponentiateExpression(
									new DivisionExpression(
										new AdditionExpression(new NegationExpression(new Number(5)),
										new MultiplicationExpresion(new Number(6.9),new Number(8))),
										new Number(8)),
										new Number(4));
		Console.WriteLine($"Výsledek: {expression.Evaluate()}");
		Console.WriteLine($"Výsledek 2: {expression1.Evaluate()}");
	}
}

