using TreeStructure;

namespace Application.Expressions
{
    public abstract class AbstractExpressionRoot : IExpressionRoot
    {
        public IExpressionRootKey Key { get; }
        public string Name { get; }
        public abstract IEnumerable<IExpressionNode>? Children { get; }
        public AbstractExpressionRoot(IExpressionRootKey key, string name)
        {
            Key = key;
            Name = name;
        }
    }
}