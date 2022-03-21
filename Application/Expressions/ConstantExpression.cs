using TreeStructure;

namespace Application.Expressions
{
    /// <summary>
    /// Constant expression should be leaf in tree of expressions
    /// </summary>
    public class ConstantExpression : AbstractExpressionNode
    {
        public decimal Value { get; }

        public override IEnumerable<IExpressionNode>? Children => null;

        public ConstantExpression(string name, decimal value) : base(name)
        {
            Value = value;
        }
    }
}