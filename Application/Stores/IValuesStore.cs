using TreeStructure;

namespace Application.Stores
{
	public interface IValuesStore
	{
		public bool TryGetValue(IExpressionRootKey key, out decimal value);
		public void AddValue(IExpressionRootKey key, decimal value);
		public void Clear();
	}
}