namespace TreeStructure
{
    public interface IExpressionNode
    {
        public string Name { get; }
        public IEnumerable<IExpressionNode>? Children { get; }
    }
}