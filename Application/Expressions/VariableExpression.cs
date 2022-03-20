using TreeStructure;

namespace Application.Expressions
{
	public class VariableExpression : AbstractExpressionNode
	{
		public IExpressionNode? Expression { get; }
		public VariableExpression(IExpressionNode? node)
		{
			Expression = node;
		}
	}
}