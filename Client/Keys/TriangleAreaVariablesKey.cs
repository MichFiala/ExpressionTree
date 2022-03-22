using Client.Variables;

namespace Client.Keys
{
	public record TriangleAreaVariablesKey : AbstractTriangleVariablesKey
	{
		public override string Key => $"{Attribute}-{Variable}";
       	 public TriangleAreaVariables Variable { get;}
		public TriangleAreaVariablesKey(TriangleAttributes attribute, TriangleAreaVariables variable): base(attribute)
        {
               Variable = variable;
        }
	}
}