using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Asteroid
{
    public class AsteroidGenerator : BaseGenerator
    {
        public AsteroidGeneratorOptions Options { get; set; }
        public AsteroidModel Generate()
        {
            AsteroidModel model = new AsteroidModel();

            // Asteroid Field Qubits
            var qbit_gen = new Qubit.QubitGenerator(this.Random.Next(), this.Options.QubitOptions);
            model.Qubits = qbit_gen.Generate();

            model.FieldSize = this.Random.Next(1, this.Options.MaxFieldSize);
            model.AverageAsteroidSize = this.Random.Next(1, this.Options.MaxAsteroidSize);
            model.AverageSpeed = this.Random.Next(1, this.Options.MaxAverageSpeed);
            model.Radius = this.Random.Next(0, this.Options.MaxRadius);
            model.SizeType = this.Random.Next(0, this.Options.MaxSizeType);

            return model;
        }

        public AsteroidGenerator(Int32 SeedIdentity, AsteroidGeneratorOptions options)
            : base("/asteroid", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
