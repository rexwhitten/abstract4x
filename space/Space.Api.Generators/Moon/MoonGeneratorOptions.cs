using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Moon
{
    public class MoonGeneratorOptions : BaseGeneratorOptions 
    {
        public MoonGeneratorOptions() : base(new Qubit.QubitGeneratorOptions(){
            ItemCountMax = 2 * 16, // Moons can have 2 groups of 8 Qubit types
            SizeTypeMax = 1 * 16, // Moons can have any of the 16 Sixe Types for Qubits
            ValueTypeMax = 1 * 16, // Moons can only have the first 16 Types of Qubit Resources
            ValueMax = (1024) * 4 // Moons can have the "large value" times 8 
        })
        {

        }

        public int MaxRadius { get; set; }

        public int MaxSizeType { get; set; }
    }
}
