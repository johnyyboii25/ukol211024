public class Number : IExpression
{
	private double value;

	public Number(double value)
	{
		this.value = value;
	}

	public double Evaluate()
	{
		return value;
	}
	public string GetString()
	{
		return value.ToString();
	}
}