using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class VariableExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<VariableExpression>
	{
		private readonly ExpressionNodeSolverFactory _solverFactory;
		public VariableExpressionSolver(ExpressionNodeSolverFactory solverFactory)
		{
			_solverFactory = solverFactory;
		}
		public bool TrySolve(IExpressionNode expressionNode, out decimal result)
		{
			var node = (VariableExpression)expressionNode;
			result = 0;

			if (node.Expression is null) return false;

			return _solverFactory.GetExpressionSolver(expressionNode).TrySolve(node.Expression, out result);
		}
	}
}