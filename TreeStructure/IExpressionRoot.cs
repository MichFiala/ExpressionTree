namespace TreeStructure
{
	public interface IExpressionRoot : IExpressionNode
    {
        public IRootExpressionKey Key { get; }
	}
}