using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Atmosphere
{
    public class AtmosphereGenerator : BaseGenerator
    {
        public AtmosphereGeneratorOptions Options { get; set; }

        public AtmosphereModel Generate()
        {
            AtmosphereModel model = new AtmosphereModel();
 
            return model;
        }

        public AtmosphereGenerator(Int32 SeedIdentity, AtmosphereGeneratorOptions options)
            : base("/atmosphere", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
