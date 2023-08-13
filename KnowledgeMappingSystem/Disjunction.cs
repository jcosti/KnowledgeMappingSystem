namespace KnowledgeMappingSystem
{
    public class Disjunction : BinaryInference
    {
        public Disjunction(INode leftChild, INode rightChild) : base(leftChild, rightChild)
        {
        }

        public override double Probability => this.LeftChild.Probability + this.RightChild.Probability - this.LeftChild.Probability * this.RightChild.Probability;
    }
}
