using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Expressions;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class ConstantExpressionSolver : IExpressionNodeSolver, IExpressionNodeSolverForMarker<ConstantExpression>
	{
		public bool TrySolve(IExpressionNode expressionNode, out decimal result) 
        {
            result = ((ConstantExpression)expressionNode).Value;

			return true;
		} 
	}
}