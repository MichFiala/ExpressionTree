using Application.Expressions;
using Application.Stores;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class RootExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<RootExpression>
	{
		private readonly ExpressionNodeSolverFactory _solverFactory;
          private readonly IValuesStore _valuesStore;
		public RootExpressionSolver(ExpressionNodeSolverFactory solverFactory, IValuesStore valuesStore)
		{
               _valuesStore = valuesStore;
			_solverFactory = solverFactory;

		}
		public bool TrySolve(IExpressionNode rootNode, out decimal result) 
		{
			var node = (RootExpression)rootNode;

			var couldBeSolved = _solverFactory.TrySolve(((RootExpression)node).Node, out result);

			if(!couldBeSolved) return false;

			_valuesStore.AddValue(node.Key, result);

			return true;
		}

		
	}
}