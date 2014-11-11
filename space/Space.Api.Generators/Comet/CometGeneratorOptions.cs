using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Comet
{
    public class CometGeneratorOptions : BaseGeneratorOptions
    {
        public CometGeneratorOptions() : base(new Qubit.QubitGeneratorOptions(){
            ItemCountMax = 2 * 16, // Comets can have 2 groups of 8 Qubit types
            SizeTypeMax = 1 * 16, // Comets can have any of the 16 Sixe Types for Qubits
            ValueTypeMax = 1 * 16, // Comets can only have the first 16 Types of Qubit Resources
            ValueMax = (1024) * 4 // Comets can have the "large value" times 8 
        })
        {
            // Defaults
            this.SurfaceZonesMax = 2;
            
        }

        public int SurfaceZonesMax { get; set; }

        public int MaxOrbitalSpeed { get; set; }

        public int MaxDistanceFromStar { get; set; }

        public int MaxOrbitalDiameter { get; set; }

        public int MaxRadius { get; set; }
    }
}
