using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
    public class ConstantExpressionSolver : IExpressionNodeSolver
    {
		public ExpressionNodeSolverFacade SolverFacade { get; set; } = null!;
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