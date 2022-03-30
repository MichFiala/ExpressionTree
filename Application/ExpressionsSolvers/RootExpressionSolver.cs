using Application.Expressions;
using Application.Stores;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class RootExpressionSolver : IExpressionNodeSolver
	{
		private readonly IValuesStore _valuesStore;
		private readonly ExpressionNodeSolverFacade _solverFacade;
		public RootExpressionSolver(ExpressionNodeSolverFacade solverFacade, IValuesStore valuesStore)
		{
			_solverFacade = solverFacade;
			_valuesStore = valuesStore;
		}
		public bool CanSolve(IExpressionNode node) => node.GetType() == typeof(RootExpression);
		public IExpressionNode Solve(IExpressionNode expressionNode)
		{
			var node = expressionNode as RootExpression;

			if (node is null) throw new InvalidOperationException($"{this.GetType().Name} cannot solve expression of type {expressionNode.GetType()}");

			node.Node = _solverFacade.Solve(node.Node);
            	// Should this be here of on level higher?
			if (node.Node is ConstantExpression) _valuesStore.AddValue(node.Key, ((ConstantExpression)node.Node).Value);

			return node;
		}
	}
}