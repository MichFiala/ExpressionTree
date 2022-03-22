using TreeStructure;

namespace Application.Expressions
{
    /// <summary>
    /// Variable expression should be always leaf in tree of expressions
    /// </summary>
    public class ReferenceExpression : IExpressionNode
    {
        public IExpressionRootKey ReferenceKey { get; }
        public ReferenceExpression(IExpressionRootKey referenceKey)
        {
            ReferenceKey = referenceKey;
        }
    }
}