using TreeStructure;

namespace Application.Expressions
{
	public class VariableExpression : AbstractExpressionNode
	{
		public IExpressionNode? Expression { get; }
		public VariableExpression(IExpressionNodeKey key, IExpressionNode? node) : base(key)
		{
			Expression = node;
		}
	}
}