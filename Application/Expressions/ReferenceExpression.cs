using TreeStructure;

namespace Application.Expressions
{
    /// <summary>
    /// Variable expression should be always leaf in tree of expressions
    /// If variable value will be resolved it should be replaced by constant with value
    /// Variable expression has reference to root key, by that key we can resolve variable value if reference exists
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