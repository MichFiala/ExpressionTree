using Application.Operators;
using TreeStructure;

namespace Application.Expressions
{
	public class BinomialExpression : AbstractExpressionNode
	{
		public BinomialExpression(IExpressionNode leftSide, BinomialOperatorEnum operatorEnum, IExpressionNode rightSide)
		{
			LeftSide = leftSide;
			Operator = operatorEnum;
			RightSide = rightSide;
		}
		public IExpressionNode LeftSide { get; }

		public BinomialOperatorEnum Operator { get; }

		public IExpressionNode RightSide { get; }
	}
}