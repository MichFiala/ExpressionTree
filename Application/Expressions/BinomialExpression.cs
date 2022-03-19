using Application.Operators;
using TreeStructure;

namespace Application.Expressions
{
	public class BinomialExpression : AbstractExpressionNode
	{
		public BinomialExpression(IExpressionNodeKey key, AbstractExpressionNode leftSide, BinomialOperatorEnum operatorEnum, AbstractExpressionNode rightSide) : base(key)
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