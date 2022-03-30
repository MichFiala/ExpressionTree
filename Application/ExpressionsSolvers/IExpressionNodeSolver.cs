using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public interface IExpressionNodeSolver
	{
		bool TrySolve(IExpressionNode node, out decimal result);
		bool CanSolve(IExpressionNode node);
	}
}