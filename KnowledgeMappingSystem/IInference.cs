namespace KnowledgeMappingSystem
{
    /// <summary>
    /// The mechanistic counterpart of propositions sourced via information sources (scientific/empirical, privacy respecting including ZKPs and differential privacy, etc) based on inductive inferences (treating deductive as a special case with probability 1).
    /// </summary>
    public interface IInference : IProbability
    {
        /// <summary>
        /// The premises.
        /// </summary>
        public List<INode> Premises { get; set; }
    }
}
