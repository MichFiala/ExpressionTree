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
        private bool TrySolveBySolvers(IExpressionNode node, out decimal result)
        {
            var solver = _availableSolvers.Single(s => s.CanSolve(node));

            return solver.TrySolve(node, out result);
        }
        public bool TrySolve(IExpressionNode node, out decimal result) => TrySolveBySolvers(node, out result);
    }
}