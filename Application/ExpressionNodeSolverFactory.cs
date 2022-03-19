using Application.Expressions;
using Application.ExpressionsSolvers;
using Castle.Windsor;
using TreeStructure;

namespace Application
{
	public class ExpressionNodeSolverFactory
	{
		private readonly WindsorContainer _container;
		public ExpressionNodeSolverFactory(WindsorContainer container)
		{
			_container = container;

		}
		public IExpressionNodeSolver GetExpressionSolver(IExpressionNode node)
		{
			var type = node.GetType();

			if (type == typeof(BinomialExpression))
				return (IExpressionNodeSolver)_container.Resolve<IExpressionNodeSolverForMarker<BinomialExpression>>();
			if (type == typeof(VariableExpression))
				return (IExpressionNodeSolver)_container.Resolve<IExpressionNodeSolverForMarker<VariableExpression>>();

			throw new InvalidDataException($"Cannot find solver for type {node.GetType()}");
		}

		public bool TrySolve(IExpressionNode node, out decimal result) => GetExpressionSolver(node).TrySolve(node, out result);
	}
}