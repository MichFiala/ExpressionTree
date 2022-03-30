using TreeStructure;

namespace Application.ExpressionSimplifiers
{
    public interface IExpressionSimplifier
    {
         public IExpressionNode TrySimplify(IExpressionNode node);
    }
}