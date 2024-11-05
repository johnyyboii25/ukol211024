
using System.Linq.Expressions;

public interface IExpression
{
	double Evaluate();
	string GetString();
	void EvaluateAndString(IExpression expression)
	{
		Console.WriteLine($"{expression.GetString()} = {expression.Evaluate()}");
	}
}

