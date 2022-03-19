using TreeStructure;

namespace Application.Expressions
{
	public class ConstantExpression : AbstractExpressionNode
	{
        	//TODO potrebujeme u constanty klic???
          public decimal Value { get; }
		public ConstantExpression(IExpressionNodeKey key, decimal value) : base(key)
		{
               Value = value;
		}
	}
}