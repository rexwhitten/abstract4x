using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Civilization
{
    public class CivilizationGeneratorOptions : BaseGeneratorOptions
    {
        public CivilizationGeneratorOptions() : base(new Qubit.QubitGeneratorOptions(){

        })
        {

        }

        public int MaxCivilizationType { get; set; }

        public int MaxCivilizationSocialType { get; set; }

        public int MaxCivilizationExternalCommunicationType { get; set; }

        public int MaxExternalDiplomacyType { get; set; }
    }
}
