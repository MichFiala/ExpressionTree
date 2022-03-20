using Application.Variables;
using TreeStructure;

namespace Application.Keys
{
	public class CalculationVariableExpressionKey : IExpressionRootKey
	{
		private readonly string _logicalStructure;
		private readonly CalculationVariablesEnum _variable;
		public CalculationVariableExpressionKey(string logicalStructure, CalculationVariablesEnum variable)
		{
			_variable = variable;
			_logicalStructure = logicalStructure;

		}

		public string Key => $"{_logicalStructure}-{_variable}";
	}
}