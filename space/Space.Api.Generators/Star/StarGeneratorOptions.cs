using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Star
{
    public class StarGeneratorOptions : BaseGeneratorOptions
    {
        #region [ Properties ] 
        public int AsteroidFieldMin { get; set; }

        public int AsteroifFieldMax { get; set; }

        public int CometMin { get; set; }

        public int CometMax { get; set; }

        public int PlanetMax { get; set; }

        public int PlanetMin { get; set; }

        public int StarRadiusMin { get; set; }

        public int StarRadiusMax { get; set; }

        public int StarAgeMin { get; set; }

        public int StarAgeMax { get; set; }
        #endregion

        public StarGeneratorOptions() : base(new Qubit.QubitGeneratorOptions() {
            ItemCountMax = 2 * 8, // Stars can have 2 groups of 8 Qubit types
            SizeTypeMax = 1 * 16, // Stars can have any of the 16 Sixe Types for Qubits
            ValueTypeMax = 1 * 8, // Stars can only have the first 8 Types of Qubit Resources
            ValueMax = (1024) * 8 // Stars can have the "large value" times 8 
        })
        {
             
        }

        public int StarTypeMax { get; set; }
    }
}
