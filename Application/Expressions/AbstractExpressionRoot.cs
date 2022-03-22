using TreeStructure;

namespace Application.Expressions
{
    public abstract class AbstractExpressionRoot : IExpressionRoot
    {
        public IExpressionRootKey Key { get; }
        public AbstractExpressionRoot(IExpressionRootKey key)
        {
            Key = key;
        }
    }
}