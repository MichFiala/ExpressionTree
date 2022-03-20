using TreeStructure;

namespace Application.Expressions
{
	public class AbstractExpressionRoot : IExpressionRoot
	{
		public IExpressionRootKey Key { get; }

		public AbstractExpressionRoot(IExpressionRootKey key)
		{
			this.Key = key;
		}
	}
}