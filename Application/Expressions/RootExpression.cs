using TreeStructure;

namespace Application.Expressions
{
	public class RootExpression : IExpressionRoot
	{
		public ExpressionRootKey Key { get; }
		public IExpressionNode Node { get; set; }
		public RootExpression(ExpressionRootKey key, IExpressionNode node)
		{
			Key = key;
			Node = node;
		}
	}
}