using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
    public class ConstantExpressionSolver : IExpressionNodeSolver
    {
        public bool CanSolve(IExpressionNode node) => node.GetType() == typeof(ConstantExpression);
        public bool TrySolve(IExpressionNode expressionNode, out decimal result)
        {
			result = 0;
			var node = expressionNode as ConstantExpression;

			if(node is null) return false;

            result = node.Value;

            return true;
        }
    }
}