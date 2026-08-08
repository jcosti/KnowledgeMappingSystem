namespace KnowledgeMappingSystem
{
    public class Conjunction : BinaryInference
    {
        public Conjunction(INode leftChild, INode rightChild) : base(leftChild, rightChild)
        {
        }

        public override double Probability => this.LeftChild.Probability * this.RightChild.Probability;
    }
}
