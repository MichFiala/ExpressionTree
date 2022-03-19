using Application.Expressions;
using Application.Operators;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class BinomialExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<BinomialExpression>
	{
		private readonly ExpressionNodeSolverFactory _solverFactory;
		public BinomialExpressionSolver(ExpressionNodeSolverFactory solverFactory)
		{
			_solverFactory = solverFactory;
		}
		public bool TrySolve(IExpressionNode binomialNode, out decimal result)
		{
			var node = (BinomialExpression)binomialNode;
			result = 0;

			var leftSideCouldBeSolved = _solverFactory.GetExpressionSolver(node.LeftSide).TrySolve(node.LeftSide, out decimal leftSideResult);
			var rightSideCouldBeSolved = _solverFactory.GetExpressionSolver(node.LeftSide).TrySolve(node.RightSide, out decimal rightSideResult);

			if (!leftSideCouldBeSolved || !rightSideCouldBeSolved) return false;

			switch (node.Operator)
			{
				case BinomialOperatorEnum.Plus:
					result = leftSideResult + rightSideResult;
					return true;
				default:
					throw new NotImplementedException($"Not implemented solving method for operator {node.Operator}");
			}
		}
	}
}