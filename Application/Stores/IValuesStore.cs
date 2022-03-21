using TreeStructure;

namespace Application.Stores
{
	public interface IValuesStore
	{
		public bool TryGetValue(IRootExpressionKey key, out decimal value);
		public void AddValue(IRootExpressionKey key, decimal value);
	}
}