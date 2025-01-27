
public class ExponentiationExp : BinaryExpression
{
    public ExponentiationExp(IExpression left, IExpression right) : base(left, right) {}
    public override double Evaluate()
    {
        return Math.Pow(Left.Evaluate(), Right.Evaluate());
    }
}