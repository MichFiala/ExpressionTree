using Application.Variables;
using TreeStructure;

namespace Application.Keys
{
	public class CalculationVariableExpressionKey : IRootExpressionKey
	{
		private readonly string _logicalStructure;
		private readonly CalculationVariablesEnum _variable;
		public string Key => $"{_logicalStructure}-{_variable}";
		public CalculationVariableExpressionKey(string logicalStructure, CalculationVariablesEnum variable)
		{
			_variable = variable;
			_logicalStructure = logicalStructure;
		}
	}
}