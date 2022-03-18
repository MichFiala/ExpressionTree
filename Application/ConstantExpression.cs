using TreeStructure;

namespace Application
{
	public class ConstantExpression : AbstractExpressionNode, IExpressionNode
	{
        //TODO potrebujeme u constanty klic???
		public ConstantExpression(IExpressionNodeKey key, decimal value) : base(key)
		{
		}
	}
}