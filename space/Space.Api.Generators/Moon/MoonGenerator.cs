using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Moon
{
    public class MoonGenerator : BaseGenerator
    {
        public MoonGeneratorOptions Options { get; set; }

        public MoonModel Generate()
        {
            MoonModel model = new MoonModel();

            #region [ Qubit ] 
            var qbit_gen = new Qubit.QubitGenerator(this.Random.Next(), this.Options.QubitOptions);
            model.Qubits = qbit_gen.Generate();
            #endregion

            var surface_gen = new SurfaceArea.SurfaceAreaGenerator(this.Random.Next(), Drake.Options.SurfaceArea);
            model.Surface = surface_gen.Generate();
            model.Radius = this.Random.Next(0, this.Options.MaxRadius);
            model.SizeType = this.Random.Next(0, this.Options.MaxSizeType);

            return model;
        }

        public MoonGenerator(Int32 SeedIdentity, MoonGeneratorOptions options)
            : base("/moon", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
