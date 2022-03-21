using TreeStructure;

namespace Application.Expressions
{
    /// <summary>
    /// Variable expression should be always leaf in tree of expressions
    /// </summary>
    public class ReferenceExpression : AbstractExpressionNode
    {
        public IRootExpressionKey ReferenceKey { get; }

        public override IEnumerable<IExpressionNode>? Children => null;

        public ReferenceExpression(string name, IRootExpressionKey referenceKey) : base(name)
        {
            ReferenceKey = referenceKey;
        }
    }
}