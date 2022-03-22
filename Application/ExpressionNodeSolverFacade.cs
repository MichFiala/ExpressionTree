using Application.ExpressionsSolvers;
using TreeStructure;

namespace Application
{
	public class ExpressionNodeSolverFacade
	{
          private readonly IExpressionNodeSolver[] _availableSolvers;
		public ExpressionNodeSolverFacade(IExpressionNodeSolver[] availableSolvers)
		{
               _availableSolvers = availableSolvers;

			if(availableSolvers is null || !availableSolvers.Any()) throw new InvalidOperationException("No available solvers found");

			foreach(var solver in availableSolvers) solver.SolverFacade = this;

			_availableSolvers = availableSolvers;
		}
		private bool TrySolveBySolvers(IExpressionNode node, out decimal result)
		{
			result = 0;

			foreach(var solver in _availableSolvers)
			{
				if(solver.TrySolve(node, out result)) return true;
			}

			return false;
		}
		public bool TrySolve(IExpressionNode node, out decimal result) => TrySolveBySolvers(node, out result);
	}
}