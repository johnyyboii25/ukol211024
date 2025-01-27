public class DivisionExp : BinaryExpression
{
    public DivisionExp(IExpression left, IExpression right) : base(left, right) {}
    public override double Evaluate()
    {
        return Left.Evaluate() / Right.Evaluate();
    }
}