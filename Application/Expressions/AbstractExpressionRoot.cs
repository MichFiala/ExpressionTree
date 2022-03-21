using TreeStructure;

namespace Application.Expressions
{
    public abstract class AbstractExpressionRoot : IExpressionRoot
    {
        public IRootExpressionKey Key { get; }
        public string Name { get; }
        public abstract IEnumerable<IExpressionNode>? Children { get; }
        public AbstractExpressionRoot(IRootExpressionKey key, string name)
        {
            Key = key;
            Name = name;
        }
    }
}