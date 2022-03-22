using Application.Stores;

namespace Application.ExpressionsSolvers
{
	public static class ExpressionSolverFactory
	{
		public static IExpressionNodeSolver[] GetAllAvailableSolvers(IValuesStore valuesStore) =>
		    new IExpressionNodeSolver[]
			  {
				new ConstantExpressionSolver(),
				new BinomialExpressionSolver(),
				new ReferenceExpressionSolver(valuesStore),
				new RootExpressionSolver(valuesStore),
			  };
	}
}