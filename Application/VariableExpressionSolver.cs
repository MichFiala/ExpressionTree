using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeStructure;

namespace Application
{
	public class VariableExpressionSolver : IExpressionNodeSolver<VariableExpression>
	{
		private readonly ExpressionSolverFactory _solverFactory;
		public VariableExpressionSolver(ExpressionSolverFactory solverFactory)
		{
			_solverFactory = solverFactory;
		}
		public bool TrySolve(VariableExpression node, out decimal result)
		{
			result = 0;

			if (node.Expression is null) return false;

			return _solverFactory.TrySolve(node.Expression, out result);
		}
	}
}