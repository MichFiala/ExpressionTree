using Application.Stores;

namespace Application.ExpressionsSolvers
{
    public class ExpressionSolverFactory : AbstractExpressionSolverFactory
    {
        private readonly IValuesStore _valuesStore;

        public ExpressionSolverFactory(IValuesStore valuesStore)
		{
            _valuesStore = valuesStore;
        }
        public override IExpressionNodeSolver[] CreateSolvers(ExpressionNodeSolverFacade solverFacade) =>
        	new IExpressionNodeSolver[]
              {
                new ConstantExpressionSolver(),
                new BinomialExpressionSolver(solverFacade),
                new ReferenceExpressionSolver(_valuesStore),
                new RootExpressionSolver(solverFacade, _valuesStore),
              };
    }
}