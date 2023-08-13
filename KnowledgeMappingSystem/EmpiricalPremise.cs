namespace KnowledgeMappingSystem
{
    // TODO: Need to assume this is a credible empirical source for now (needs further investigation into how this would be ensured statistically).
    public class EmpiricalPremiseNode : IPremiseNode
    {
        public double Probability => 1;

        public object Content { get => throw new NotImplementedException(); }

        public ulong TrueFrequency => throw new NotImplementedException();

        public ulong FalseFrequency => throw new NotImplementedException();
    }
}
