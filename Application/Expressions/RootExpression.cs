using TreeStructure;

namespace Application.Expressions
{
	public class RootExpression : AbstractExpressionRoot
	{
		public IExpressionNode Node { get; }
		public RootExpression(IExpressionRootKey key, IExpressionNode node) : base(key)
		{
			Node = node;
		}
	}
}