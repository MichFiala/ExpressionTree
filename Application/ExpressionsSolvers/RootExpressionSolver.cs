using Application.Expressions;
using Application.Stores;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class RootExpressionSolver : IExpressionNodeSolver
	{
		private readonly IValuesStore _valuesStore;
		public ExpressionNodeSolverFacade SolverFacade { get; set; } = null!;
		public RootExpressionSolver(IValuesStore valuesStore)
		{
			_valuesStore = valuesStore;
		}
		public bool TrySolve(IExpressionNode expressionNode, out decimal result)
		{
			result = 0;
			var node = expressionNode as RootExpression;

			if (node is null) return false;
			// If value is already in store use it
			if(_valuesStore.TryGetValue(node.Key, out result)) return true;

			var couldBeSolved = SolverFacade.TrySolve(((RootExpression)node).Node, out result);

			if (!couldBeSolved) return false;

			_valuesStore.AddValue(node.Key, result);

			return true;
		}


	}
}