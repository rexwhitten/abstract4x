using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Asteroid
{
    public class AsteroidGeneratorOptions : BaseGeneratorOptions
    {
        public AsteroidGeneratorOptions() : base(new Qubit.QubitGeneratorOptions(){
            ItemCountMax = 2 * 16, // Asteroids can have 2 groups of 8 Qubit types
            SizeTypeMax = 1 * 16, // ASteroids can have any of the 16 Sixe Types for Qubits
            ValueTypeMax = 1 * 16, // ASteroids can only have the first 16 Types of Qubit Resources
            ValueMax = (1024) * 4 // ASteroids can have the "large value" times 8 
        })
        {

        }

        public int MaxFieldSize { get; set; }

        public int MaxAsteroidSize { get; set; }

        public int MaxAverageSpeed { get; set; }

        public int MaxRadius { get; set; }

        public int MaxSizeType { get; set; }
    }
}
