using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Civilization
{
    public class CivilizationGenerator : BaseGenerator
    {
        public CivilizationGeneratorOptions Options { get; set;  }

        public CivilizationModel Generate(Bio.BiologicalLifeformModel lifeForm)
        {
            CivilizationModel model = new CivilizationModel(lifeForm);

            model.CivilizationType = this.Random.Next(1, this.Options.MaxCivilizationType);
            model.SocialType = this.Random.Next(1, this.Options.MaxCivilizationSocialType);
            model.ExternalCommunicationType = this.Random.Next(1, this.Options.MaxCivilizationExternalCommunicationType);
            model.ExternalDiplomacyType = this.Random.Next(1, this.Options.MaxExternalDiplomacyType);

            // Tech Tree ( Motives, Attributes ) 


            return model;
        }

        public CivilizationGenerator(Int32 SeedIdentity, CivilizationGeneratorOptions options)
            : base("/civilization", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
