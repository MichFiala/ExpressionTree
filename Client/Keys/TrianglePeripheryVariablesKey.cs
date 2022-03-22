using Client.Variables;

namespace Client.Keys
{
	public record TrianglePeripheryVariablesKey : AbstractTriangleVariablesKey
	{
		public TrianglePeripheryVariables Variable { get; }
		public override string Key => $"{Attribute}-{Variable}";
		public TrianglePeripheryVariablesKey(TriangleAttributes attribute, TrianglePeripheryVariables variable): base(attribute)
		{
			Variable = variable;
		}
	}
}