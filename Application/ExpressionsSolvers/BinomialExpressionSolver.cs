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

        public IExpressionNode TrySimplify(IExpressionNode node)
        {
            if (TrySolve(node, out decimal result))
            {
                return new ConstantExpression(result);
            }
            return node;
        }

        public bool TrySolve(IExpressionNode expressionNode, out decimal result)
        {
            result = 0;
            var node = expressionNode as BinomialExpression;

            if (node is null) return false;

            var leftSideCouldBeSolved =  _solverFacade.TrySolve(node.LeftSide, out decimal leftSideResult);
            var rightSideCouldBeSolved = _solverFacade.TrySolve(node.RightSide, out decimal rightSideResult);

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

            // TODO check for 0 sides to simplify 
        }
    }
}