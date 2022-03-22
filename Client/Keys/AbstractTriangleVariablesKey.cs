using Client.Variables;
using TreeStructure;

namespace Client.Keys
{
	public abstract record AbstractTriangleVariablesKey : IExpressionRootKey
	{
        public TriangleAttributes Attribute { get; }
		public abstract string Key { get; }
		public AbstractTriangleVariablesKey(TriangleAttributes attribute)
        {
               Attribute = attribute;
            
        }
	}
}