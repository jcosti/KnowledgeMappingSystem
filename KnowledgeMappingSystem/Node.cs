namespace KnowledgeMappingSystem
{
    public class Node : INode
    {
        /// <summary>
        /// The ways in which this node is inferred.
        /// </summary>
        public List<IInference>? Inferences { get; set; }

        public object Content => throw new NotImplementedException();

        public double Probability => Inferences?.Max(inference => inference.Probability) ?? 0;
    }
}
