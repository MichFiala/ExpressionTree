using Application.ExpressionSimplifiers;

namespace Application
{
    public class ExpressionNodeSimplifierFacade
    {
        private readonly IExpressionSimplifier[] _availableSimplifiers;
        public ExpressionNodeSimplifierFacade(IExpressionSimplifier[] availableSimplifiers)
        {
            _availableSimplifiers = availableSimplifiers;
        }

        
    }
}