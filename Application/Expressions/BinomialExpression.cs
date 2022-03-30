using Application.Operators;
using TreeStructure;

namespace Application.Expressions
{
	public class BinomialExpression : IExpressionNode
	{
		public IExpressionNode LeftSide { get; set; }
		public BinomialOperatorEnum Operator { get; }
		public IExpressionNode RightSide { get; set; }
		public BinomialExpression(IExpressionNode leftSide, BinomialOperatorEnum operatorEnum, IExpressionNode rightSide)
		{
			LeftSide = leftSide;
			Operator = operatorEnum;
			RightSide = rightSide;
		}
	}
}