namespace KnowledgeMappingSystem
{
    public abstract class BinaryInference : IInference
    {
        public BinaryInference(INode leftChild, INode rightChild) 
        {
            this.LeftChild = leftChild;
            this.RightChild = rightChild;

            this.Premises = new() { this.LeftChild, this.RightChild };
        }

        public INode LeftChild { get; set; }

        public INode RightChild { get; set; }

        public List<INode> Premises { get; set; }

        public abstract double Probability { get; }
    }
}
