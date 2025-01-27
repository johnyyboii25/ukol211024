public class SubstractionExp : BinaryExpression
{
    public SubstractionExp(IExpression left, IExpression right) : base(left, right) {}
    public override double Evaluate()
    {
        return Left.Evaluate() - Right.Evaluate();
    }
}