using Application.Expressions;
using Application.Operators;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
	public class BinomialExpressionSolver : IExpressionNodeSolver
	{
		public ExpressionNodeSolverFacade SolverFacade { get; set; } = null!;
		public bool TrySolve(IExpressionNode expressionNode, out decimal result)
		{
			if(SolverFacade is null) throw new NullReferenceException("Solver Facade is null");

			result = 0;
			var node = expressionNode as BinomialExpression;

			if(node is null) return false;

			var leftSideCouldBeSolved = SolverFacade.TrySolve(node.LeftSide, out decimal leftSideResult);
			var rightSideCouldBeSolved = SolverFacade.TrySolve(node.RightSide, out decimal rightSideResult);

			if (!leftSideCouldBeSolved || !rightSideCouldBeSolved) return false;

			switch (node.Operator)
			{
				case BinomialOperatorEnum.Plus:
					result = leftSideResult + rightSideResult;
					return true;
				case BinomialOperatorEnum.Multiplication:
					result = leftSideResult * rightSideResult;
					return true;			
				case BinomialOperatorEnum.Minus:
					result = leftSideResult - rightSideResult;
					return true;			
				case BinomialOperatorEnum.Division:
					result = leftSideResult / rightSideResult;
					return true;						
				default:
					throw new NotImplementedException($"Not implemented solving method for operator {node.Operator}");
			}
		}
	}
}