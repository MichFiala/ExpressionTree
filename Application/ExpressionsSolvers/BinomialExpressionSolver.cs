using Application.Expressions;
using Application.Operators;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
    public class BinomialExpressionSolver : IExpressionNodeSolver
    {
        private readonly ExpressionNodeSolverFacade _solverFacade;

        public BinomialExpressionSolver(ExpressionNodeSolverFacade solverFacade)
        {
            _solverFacade = solverFacade;
        }

        public bool CanSolve(IExpressionNode node) => node.GetType() == typeof(BinomialExpression);

		public IExpressionNode Solve(IExpressionNode expressionNode)
		{
            var node = expressionNode as BinomialExpression;

            if (node is null) throw new InvalidOperationException($"{this.GetType().Name} cannot solve expression of type {expressionNode.GetType()}");

            node.LeftSide =  _solverFacade.Solve(node.LeftSide);
            node.RightSide = _solverFacade.Solve(node.RightSide);
            // TODO check for 0 sides
            if (node.LeftSide is not ConstantExpression || node.RightSide is not ConstantExpression) return node;

			var leftSideValue = ((ConstantExpression)node.LeftSide).Value;
            var rightSideValue = ((ConstantExpression)node.RightSide).Value;

			switch (node.Operator)
            {
                case BinomialOperatorEnum.Plus:
					return new ConstantExpression { Value = leftSideValue + rightSideValue };
				case BinomialOperatorEnum.Multiplication:
                    return new ConstantExpression { Value = leftSideValue * rightSideValue };
                case BinomialOperatorEnum.Minus:
                    return new ConstantExpression { Value = leftSideValue - rightSideValue };
                case BinomialOperatorEnum.Division:
                    return new ConstantExpression { Value = leftSideValue / rightSideValue };
                default:
                    throw new NotImplementedException($"Not implemented solving method for operator {node.Operator}");
            }
		}
    }
}