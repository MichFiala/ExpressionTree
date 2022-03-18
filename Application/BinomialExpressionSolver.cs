using TreeStructure;

namespace Application
{
	public class BinomialExpressionSolver : IExpressionNodeSolver<BinomialExpression>
	{
		private readonly ExpressionSolverFactory _solverFactory;
		public BinomialExpressionSolver(ExpressionSolverFactory solverFactory)
		{
			_solverFactory = solverFactory;
		}
		public bool TrySolve(BinomialExpression node, out decimal result)
		{
			result = 0;

			var leftSideCouldBeSolved = _solverFactory.TrySolve(node.LeftSide, out decimal leftSideResult);
			var rightSideCouldBeSolved = _solverFactory.TrySolve(node.RightSide, out decimal rightSideResult);

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