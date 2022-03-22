using TreeStructure;

namespace Application.Stores
{
	public class ValuesStore : IValuesStore
	{
		private readonly Dictionary<string, decimal> _values = new();
		public void AddValue(IExpressionRootKey key, decimal value) => _values.Add(key.Key, value);
		public bool TryGetValue(IExpressionRootKey key, out decimal value) => _values.TryGetValue(key.Key, out value);
		public void Clear() => _values.Clear();
	}
}