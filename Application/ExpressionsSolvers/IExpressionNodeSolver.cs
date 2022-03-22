using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public interface IExpressionNodeSolver
	{
		public ExpressionNodeSolverFacade SolverFacade { get; set; }
		bool TrySolve(IExpressionNode node, out decimal result);
	}
}