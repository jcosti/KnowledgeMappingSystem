namespace KnowledgeMappingSystem
{
    public abstract class UnaryInference : IInference
    {
        public UnaryInference(INode child)
        {
            this.Child = child;
            
            this.Premises = new() { this.Child };
        }

        public INode Child { get; set; }

        public List<INode> Premises { get; set; }

        public abstract double Probability { get; }
    }
}
