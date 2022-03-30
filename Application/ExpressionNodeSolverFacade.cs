using Application.ExpressionsSolvers;
using Application.Stores;
using TreeStructure;

namespace Application
{
	public class ExpressionNodeSolverFacade
	{
		private readonly IExpressionNodeSolver[] _availableSolvers;
		public ExpressionNodeSolverFacade(ExpressionSolverFactory solverFactory)
		{
			_availableSolvers = solverFactory.CreateSolvers(this);

			if (_availableSolvers is null || !_availableSolvers.Any()) throw new InvalidOperationException("No available solvers found");
		}
		private IExpressionNodeSolver GetSolver(IExpressionNode node) => _availableSolvers.Single(s => s.CanSolve(node));
		public IExpressionNode Solve(IExpressionNode node) => GetSolver(node).Solve(node);
	}
}