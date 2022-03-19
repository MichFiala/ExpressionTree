using TreeStructure;

namespace Application.Variables
{
	public class CalculationVariableExpressionKey : IExpressionNodeKey
	{
		private readonly string _logicalStructure;
		private readonly CalculationVariablesEnum _variable;
		public CalculationVariableExpressionKey(string logicalStructure, CalculationVariablesEnum variable)
		{
			_variable = variable;
			_logicalStructure = logicalStructure;

		}
		public string GetKey() => $"{_logicalStructure}-{_variable}";
	}
}