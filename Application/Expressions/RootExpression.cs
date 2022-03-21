using TreeStructure;

namespace Application.Expressions
{
	public class RootExpression : AbstractExpressionRoot
	{
		public IExpressionNode Node { get; }

		public override IEnumerable<IExpressionNode>? Children => new List<IExpressionNode> { Node };

		public RootExpression(IRootExpressionKey key, string name, IExpressionNode node) : base(key, name)
		{
			Node = node;
		}
	}
}