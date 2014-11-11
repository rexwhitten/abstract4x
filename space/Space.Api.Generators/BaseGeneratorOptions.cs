using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators
{
    public class BaseGeneratorOptions
    {
  

        

        public Qubit.QubitGeneratorOptions QubitOptions { get; set; }

        public BaseGeneratorOptions(Qubit.QubitGeneratorOptions qubitOptions)
        {
            this.QubitOptions = qubitOptions;
        }
    }
}
