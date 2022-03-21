using TreeStructure;

namespace Application.Expressions
{
	public class ExpressionRoot : AbstractExpressionRoot
	{
		public IExpressionNode Node { get; }

        public override IEnumerable<IExpressionNode>? Children => new List<IExpressionNode>{ Node };

        public ExpressionRoot(IExpressionRootKey key, string name, IExpressionNode node) : base(key, name)
		{
			Node = node;
		}
	}
}