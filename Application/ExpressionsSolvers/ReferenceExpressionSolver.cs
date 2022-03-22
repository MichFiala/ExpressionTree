using Application.Expressions;
using Application.Stores;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class ReferenceExpressionSolver : IExpressionNodeSolver
	{
		public ExpressionNodeSolverFacade SolverFacade { get; set; } = null!;
		private readonly IValuesStore _valuesStore;
		public ReferenceExpressionSolver(IValuesStore valuesStore)
		{
			_valuesStore = valuesStore;
		}
		public bool TrySolve(IExpressionNode expressionNode, out decimal result)
		{
			result = 0;
			var node = expressionNode as ReferenceExpression;

			if (node is null) return false;

			return _valuesStore.TryGetValue(node.ReferenceKey, out result);
		}

	}
}