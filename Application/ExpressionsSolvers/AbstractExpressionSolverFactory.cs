using Application.Stores;

namespace Application.ExpressionsSolvers
{
    public abstract class AbstractExpressionSolverFactory
    {
        public abstract IExpressionNodeSolver[] CreateSolvers(ExpressionNodeSolverFacade solverFacade);
    }
}