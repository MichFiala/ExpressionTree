using TreeStructure;

namespace Application.Expressions
{
    /// <summary>
    /// Constant expression should be leaf in tree of expressions
    /// </summary>
    public class ConstantExpression : IExpressionNode
    {
        public decimal Value { get; }
		public ConstantExpression(decimal value)
        {
            Value = value;
        }
    }
}