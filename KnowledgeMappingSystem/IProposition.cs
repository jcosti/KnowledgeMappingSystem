namespace KnowledgeMappingSystem
{
    /// <summary>
    /// An interface representing a proposition.
    /// </summary>
    public interface IProposition
    {
        /// <summary>
        /// The content of this proposition (with ideally clear or workable semantics derived from it).
        /// </summary>
        public object Content { get; }
    }
}