using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Planet
{
    public class PlanetGenerator : BaseGenerator
    {
        public PlanetGeneratorOptions Options { get; set; }

        public PlanetModel Generate()
        {
            PlanetModel model = new PlanetModel();

            #region [ Qubits ] 
            var qbit_gen = new Qubit.QubitGenerator(this.Random.Next(), this.Options.QubitOptions);
            model.Qubits = qbit_gen.Generate();

            model.SizeType = this.Random.Next(0, this.Options.MaxSizeType);
            model.Radius = this.Random.Next(0, this.Options.MaxRadius);
            model.Surface = new SurfaceArea.SurfaceAreaModel();
            #endregion

            #region [ Surface Area ]
            var surface_gen = new SurfaceArea.SurfaceAreaGenerator(this.Random.Next(), Drake.Options.SurfaceArea);
            model.Surface = surface_gen.Generate();
            model.Radius = this.Random.Next(0, this.Options.MaxRadius);
            model.SizeType = this.Random.Next(0, this.Options.MaxSizeType);
            #endregion

            #region [ Moon ]
            Int32 moon_count = this.Random.Next(0, this.Options.MoonCountMax);
            Int32 moon_index = 0;

            while (moon_index <= (moon_count - 1))
            {
                var moon_gen = new Moon.MoonGenerator(this.Random.Next(), Drake.Options.Moon);
                model.Moons.Add(moon_gen.Generate());
                moon_index = moon_index + 1;
            }
            #endregion


            #region [ Surface Map ] 
           
            #endregion

            return model;
        }

        public PlanetGenerator(Int32 SeedIdentity, PlanetGeneratorOptions options)
            : base("/planet", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
