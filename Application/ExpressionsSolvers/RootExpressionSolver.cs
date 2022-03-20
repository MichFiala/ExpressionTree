using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class RootExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<ExpressionRoot>
	{
		private readonly ExpressionNodeSolverFactory _solverFactory;
		public RootExpressionSolver(ExpressionNodeSolverFactory solverFactory)
		{
			_solverFactory = solverFactory;

		}
		public bool TrySolve(IExpressionNode node, out decimal result) => _solverFactory.TrySolve(((ExpressionRoot)node).Node, out result);
	}
}