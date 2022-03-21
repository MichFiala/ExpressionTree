using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class ReferenceExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<ReferenceExpression>
	{
		private readonly ExpressionNodeSolverFactory _solverFactory;
		public ReferenceExpressionSolver(ExpressionNodeSolverFactory solverFactory)
		{
			_solverFactory = solverFactory;
		}
		public bool TrySolve(IExpressionNode expressionNode, out ReferenceExpression[] missingReferences, out decimal result)
		{
			result = 0;
			missingReferences = Array.Empty<ReferenceExpression>();
			return false;
			// var node = (VariableExpression)expressionNode;
			// result = 0;

			// if (node.Expression is null) return false;

			// return _solverFactory.TrySolve(node.Expression, out result);
		}
	}
}