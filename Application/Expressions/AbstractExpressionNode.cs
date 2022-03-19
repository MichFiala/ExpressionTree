using TreeStructure;

namespace Application.Expressions
{
	public abstract class AbstractExpressionNode : IExpressionNode
	{
		public IExpressionNodeKey Key { get; private set; }
		public AbstractExpressionNode(IExpressionNodeKey key)
		{
			Key = key;
		}
	}
}