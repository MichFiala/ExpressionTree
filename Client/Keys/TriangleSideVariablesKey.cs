using Client.Variables;

namespace Client.Keys
{
	public record TriangleSideVariablesKey : AbstractTriangleVariablesKey
	{
		public override string Key => $"{Attribute}-{Variable}";
		public TriangleSideVariables Variable { get;}
		public TriangleSideVariablesKey(TriangleAttributes attribute, TriangleSideVariables variable) : base(attribute)
		{
			Variable = variable;
		}

	}
}