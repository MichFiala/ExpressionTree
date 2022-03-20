namespace Application.Expressions
{
	public class ConstantExpression : AbstractExpressionNode
	{
          public decimal Value { get; }
		public ConstantExpression(decimal value)
		{
               Value = value;
		}
	}
}