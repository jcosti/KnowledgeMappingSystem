using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeMappingSystem
{
    public class Negation : UnaryInference
    {
        public Negation(INode child) : base(child)
        {
        }

        public override double Probability => 1 - Child.Probability;
    }
}
