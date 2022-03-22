using TreeStructure;

namespace Application.Keys
{
	public class PredefinedVariableExpressionKey : IExpressionRootKey
	{
		private readonly string _variableName;
		public string Key => _variableName;
		public PredefinedVariableExpressionKey(string variableName)
		{
			_variableName = variableName;
		}
	}
}