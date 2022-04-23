using TreeStructure;

namespace Application.Stores
{
	public interface IValuesStore
	{
		public bool TryGetValue(ExpressionRootKey key, out decimal value);
		public decimal GetValue(ExpressionRootKey key);
		public void AddValue(ExpressionRootKey key, decimal value);
		public void Clear();
	}
}