using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Qubit
{
    public class QubitGeneratorOptions
    {
        public Int32 ItemCountMax { get; set; }
        // Qubit Value Type 
        public Int32 ValueTypeMax { get; set; }

        // Qubit Size Type 
        public Int32 SizeTypeMax { get; set; }

        public Int32 ValueMax { get; set; }
    }
}
