namespace KnowledgeMappingSystem
{
    public interface IFrequency
    {
        /// <summary>
        /// The frequency of this proposition evaluating to true.
        /// </summary>
        public ulong TrueFrequency { get; }

        /// <summary>
        /// The frequency of this proposition evaluating to false.
        /// </summary>
        public ulong FalseFrequency { get; }

        /// <summary>
        /// The total frequency of evaluations of this proposition.
        /// </summary>
        public ulong TotalFrequency => TrueFrequency + FalseFrequency;
    }
}
