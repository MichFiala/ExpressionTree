using TreeStructure;

namespace Application
{
	public interface IExpressionNodeSolver
	{
		bool TrySolve(IExpressionNode node, out decimal result);
	}
}