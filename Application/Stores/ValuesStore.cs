using Application.Expressions;
using TreeStructure;

namespace Application.Stores
{
	public class ValuesStore : IValuesStore
	{
		private readonly Dictionary<string, decimal> _values = new();
		public void AddValue(IRootExpressionKey key, decimal value) => _values.Add(key.Key, value);
		public bool TryGetValue(IRootExpressionKey key, out decimal value) => _values.TryGetValue(key.Key, out value);

         
	}
}