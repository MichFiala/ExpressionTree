using TreeStructure;

namespace Application.Stores
{
	public class ValuesStore : IValuesStore
	{
		private readonly Dictionary<ExpressionRootKey, decimal> _values = new();
		public void AddValue(ExpressionRootKey key, decimal value) => _values.Add(key, value);
		public bool TryGetValue(ExpressionRootKey key, out decimal value) => _values.TryGetValue(key, out value);
		public decimal GetValue(ExpressionRootKey key) => _values[key];
		public void Clear() => _values.Clear();
	}
}