using TreeStructure;

namespace Application
{
	public class VariableExpression : AbstractExpressionNode, IExpressionNode
	{
        public IExpressionNode? Expression { get; }
		public VariableExpression(IExpressionNodeKey key, IExpressionNode? node) : base(key) 
        {
			Expression = node;
		}
	}
}