using Application.Operators;
using TreeStructure;

namespace Application.Expressions
{
	public class BinomialExpression : AbstractExpressionNode
	{
		public IExpressionNode LeftSide { get; }
		public BinomialOperatorEnum Operator { get; }
		public IExpressionNode RightSide { get; }
		public override IEnumerable<IExpressionNode>? Children => new List<IExpressionNode> { LeftSide, RightSide };
		public BinomialExpression(string name, IExpressionNode leftSide, BinomialOperatorEnum operatorEnum, IExpressionNode rightSide) : base(name)
		{
			LeftSide = leftSide;
			Operator = operatorEnum;
			RightSide = rightSide;
		}
	}
}