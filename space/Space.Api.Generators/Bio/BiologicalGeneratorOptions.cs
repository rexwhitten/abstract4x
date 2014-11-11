using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Bio
{
    public class BiologicalGeneratorOptions : BaseGeneratorOptions
    {
      
        public BiologicalGeneratorOptions() : base(new Qubit.QubitGeneratorOptions(){
            ItemCountMax = 3,
            SizeTypeMax = 1,
            ValueMax = 200,
            ValueTypeMax = 100 // Mineral Consumptions
        })
        {

        }

        public int MaxLifeFormCount { get; set; }
    }
}
