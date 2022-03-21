using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
    public class ConstantExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<ConstantExpression>
    {
        public bool TrySolve(IExpressionNode expressionNode, out ReferenceExpression[] missingReferences, out decimal result)
        {
            result = ((ConstantExpression)expressionNode).Value;
            missingReferences = Array.Empty<ReferenceExpression>();

            return true;
        }
    }
}