using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
    public class ConstantExpressionSolver : IExpressionNodeSolver
    {
        public bool CanSolve(IExpressionNode node) => node.GetType() == typeof(ConstantExpression);

		public IExpressionNode Solve(IExpressionNode expressionNode)
		{
            var node = expressionNode as ConstantExpression;

			if (node is null) throw new InvalidOperationException($"{this.GetType().Name} cannot solve expression of type {expressionNode.GetType()}");

			return node;
		}
    }
}