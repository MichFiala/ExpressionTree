namespace TreeStructure
{
	public interface IExpressionRoot : IExpressionNode
    {
        public ExpressionRootKey Key { get; }

        public IExpressionNode Node { get; set; }
	}
}