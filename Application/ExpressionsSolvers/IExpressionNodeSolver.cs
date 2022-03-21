using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public interface IExpressionNodeSolver
	{
		bool TrySolve(IExpressionNode node, out ReferenceExpression[] missingReferences, out decimal result);
	}
}