using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Planet
{
    public class PlanetGeneratorOptions : BaseGeneratorOptions
    {

        public int MoonCountMax { get; set; }

        public int SurfaceAreaCountMax { get; set; }

        public PlanetGeneratorOptions() : base (new Qubit.QubitGeneratorOptions(){
            ItemCountMax = 2 * 16, // Planets can have 2 groups of 8 Qubit types
            SizeTypeMax = 1 * 16, // Planets can have any of the 16 Sixe Types for Qubits
            ValueTypeMax = 1 * 16, // Planets can only have the first 16 Types of Qubit Resources
            ValueMax = (1024) * 4 // Stars can have the "large value" times 8 
        })
        {
            this.MoonCountMax = 1;
            this.SurfaceAreaCountMax = 1;
        }

        public int MaxSizeType { get; set; }

        public int MaxRadius { get; set; }
    }
}
