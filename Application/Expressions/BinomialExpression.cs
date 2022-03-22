using Application.Operators;
using TreeStructure;

namespace Application.Expressions
{
	public class BinomialExpression : IExpressionNode
	{
		public IExpressionNode LeftSide { get; }
		public BinomialOperatorEnum Operator { get; }
		public IExpressionNode RightSide { get; }
		public BinomialExpression(IExpressionNode leftSide, BinomialOperatorEnum operatorEnum, IExpressionNode rightSide)
		{
			LeftSide = leftSide;
			Operator = operatorEnum;
			RightSide = rightSide;
		}
	}
}