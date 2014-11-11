using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Comet
{
    public class CometGenerator : BaseGenerator
    {
        public CometGeneratorOptions Options { get; set;  }
        public CometModel Generate()
        {
            CometModel model = new CometModel();

            #region [ Generate Qubits ]
            var qbit_gen = new Qubit.QubitGenerator(this.Random.Next(), this.Options.QubitOptions);
            model.Qubits = qbit_gen.Generate();
            #endregion

            model.OrbitalDiameter = this.Random.Next(1, this.Options.MaxOrbitalDiameter);
            model.OrbitalSpeed = this.Random.Next(1, this.Options.MaxOrbitalSpeed);
            model.SurfaceArea = this.Generate_SurfaceArea();
            model.Radius = this.Random.Next(1, this.Options.MaxRadius);
                
            return model;
        }

        private SurfaceArea.SurfaceAreaModel Generate_SurfaceArea()
        {
            var model = new SurfaceArea.SurfaceAreaModel();
            var generator = new SurfaceArea.SurfaceAreaGenerator(this.SeedIdentity, Drake.Options.SurfaceArea);

            model = generator.Generate(true);

            return model;
        }
        public CometGenerator(Int32 SeedIdentity, CometGeneratorOptions options)
            : base("/comet", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
