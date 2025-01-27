public class MultiplicationExp : BinaryExpression
{
    public MultiplicationExp(IExpression left, IExpression right) : base(left, right) {}
    public override double Evaluate()
    {
        return Left.Evaluate() * Right.Evaluate();
    }
}