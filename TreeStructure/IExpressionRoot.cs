namespace TreeStructure
{
	public interface IExpressionRoot : IExpressionNode
    {
        public IExpressionRootKey Key { get; }
	}
}