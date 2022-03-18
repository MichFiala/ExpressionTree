using TreeStructure;

namespace Application
{
	public class BinomialExpression : AbstractExpressionNode, IExpressionNode
	{
		public BinomialExpression(IExpressionNodeKey key, AbstractExpressionNode leftSide, BinomialOperatorEnum operatorEnum, AbstractExpressionNode rightSide) : base(key)
		{
			LeftSide = leftSide;
			Operator = operatorEnum;
			RightSide = rightSide;
		}
		public AbstractExpressionNode LeftSide { get; }

		public BinomialOperatorEnum Operator { get; }

		public AbstractExpressionNode RightSide { get; }
	}
}