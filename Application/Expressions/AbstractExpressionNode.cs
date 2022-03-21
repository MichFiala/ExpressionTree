using TreeStructure;

namespace Application.Expressions
{
    public abstract class AbstractExpressionNode : IExpressionNode
    {
        public string Name { get; }
        public abstract IEnumerable<IExpressionNode>? Children { get; }

        public AbstractExpressionNode(string name)
		{
            Name = name;
        }
    }
}