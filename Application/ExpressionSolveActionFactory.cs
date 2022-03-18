using Castle.Windsor;
using TreeStructure;

namespace Application
{
	public class ExpressionSolverFactory
	{
		private readonly WindsorContainer _container;
		public ExpressionSolverFactory(WindsorContainer container)
		{
			_container = container;

		}
		public bool TrySolve(IExpressionNode node, out decimal result)
		{
			result = 0;
			var type = node.GetType();

			if (type == typeof(BinomialExpression)) 
				return _container.Resolve<IExpressionNodeSolver<BinomialExpression>>().TrySolve((BinomialExpression)node, out result);
			if (type == typeof(VariableExpression)) 
				return _container.Resolve<IExpressionNodeSolver<VariableExpression>>().TrySolve((VariableExpression)node, out result);
			
			throw new InvalidDataException($"Cannot find solver for type {node.GetType()}");
		}
	}
}