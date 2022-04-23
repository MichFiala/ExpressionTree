using TreeStructure;

namespace Application.Expressions
{
    /// <summary>
    /// Variable expression should be always leaf in tree of expressions
    /// </summary>
    public class ReferenceExpression : IExpressionNode
    {
        public ExpressionRootKey ReferenceKey { get; }
        public ReferenceExpression(ExpressionRootKey referenceKey)
        {
            ReferenceKey = referenceKey;
        }
    }
}