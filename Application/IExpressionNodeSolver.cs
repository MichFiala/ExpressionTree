using TreeStructure;

namespace Application
{
	public interface IExpressionNodeSolver<T> where T: AbstractExpressionNode
	{
		bool TrySolve(T node, out decimal result);
	}
}