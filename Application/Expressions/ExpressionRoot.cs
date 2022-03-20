using TreeStructure;

namespace Application.Expressions
{
	public class ExpressionRoot : AbstractExpressionRoot
	{
		public IExpressionNode Node { get; }
		public ExpressionRoot(IExpressionRootKey key, IExpressionNode node) : base(key)
		{
			Node = node;
		}
	}
}