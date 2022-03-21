using Application.Expressions;
using Application.Stores;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class ReferenceExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<ReferenceExpression>
	{
		private readonly ExpressionNodeSolverFactory _solverFactory;
		private readonly IValuesStore _valuesStore;
		public ReferenceExpressionSolver(ExpressionNodeSolverFactory solverFactory, IValuesStore valuesStore)
		{
			_valuesStore = valuesStore;
			_solverFactory = solverFactory;
		}
		public bool TrySolve(IExpressionNode expressionNode, out decimal result) =>
			_valuesStore.TryGetValue(((ReferenceExpression)expressionNode).ReferenceKey, out result);
		
	}
}