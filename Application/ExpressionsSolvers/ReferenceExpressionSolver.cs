using Application.Expressions;
using Application.Stores;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class ReferenceExpressionSolver : IExpressionNodeSolver
	{
		private readonly IValuesStore _valuesStore;
		public ReferenceExpressionSolver(IValuesStore valuesStore)
		{
			_valuesStore = valuesStore;
		}
		public bool CanSolve(IExpressionNode node) => node.GetType() == typeof(ReferenceExpression);

		public IExpressionNode Solve(IExpressionNode expressionNode)
		{
			var node = expressionNode as ReferenceExpression;

			if (node is null) throw new InvalidOperationException($"{this.GetType().Name} cannot solve expression of type {expressionNode.GetType()}");

			var valueExists = _valuesStore.TryGetValue(node.ReferenceKey, out decimal result);

			return valueExists ? new ConstantExpression { Value = result } : node;
		}
	}
}