using Application.Expressions;
using Application.Stores;
using TreeStructure;

namespace Application.ExpressionsSolvers
{
    public class RootExpressionSolver : IExpressionNodeSolver
    {
        private readonly IValuesStore _valuesStore;
        private readonly ExpressionNodeSolverFacade _solverFacade;
        public RootExpressionSolver(ExpressionNodeSolverFacade solverFacade, IValuesStore valuesStore)
        {
            _solverFacade = solverFacade;
            _valuesStore = valuesStore;
        }
        public bool CanSolve(IExpressionNode node) => node.GetType() == typeof(RootExpression);
        public bool TrySolve(IExpressionNode expressionNode, out decimal result)
        {
            result = 0;
            var node = expressionNode as RootExpression;

            if (node is null) return false;

            var couldBeSolved = _solverFacade.TrySolve(((RootExpression)node).Node, out result);

            if (!couldBeSolved) return false;

            _valuesStore.AddValue(node.Key, result);

            return true;
        }
    }
}