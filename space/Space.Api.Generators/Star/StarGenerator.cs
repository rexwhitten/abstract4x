using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Star
{
    public class StarGenerator : BaseGenerator
    {
        public StarGeneratorOptions Options { get; set; }

        public StarModel Generate()
        {
            StarModel model = new StarModel();

            #region [ Generate Qubits ]
            // Stars should have lots of gas, and solar energy qubits
            var qbit_gen = new Qubit.QubitGenerator(this.Random.Next(), this.Options.QubitOptions);
            model.Qubits = qbit_gen.Generate();
            #endregion

            #region [ Star Attributes ] 
            model.Radius = this.Random.Next(this.Options.StarRadiusMin, this.Options.StarRadiusMax);
            model.StarAge = this.Random.Next(this.Options.StarAgeMin, this.Options.StarAgeMax);

            model.StarType = this.Random.Next(0,this.Options.StarTypeMax);

            // Solar Energy Qubits
            model.Qubits.Add(new Qubit.QubitItemModel()
            {
                ValueType = 900,
                Value = (this.Random.Next(this.Options.StarRadiusMin, this.Options.StarRadiusMax) * model.Radius) * 100000,
                SizeType = this.Random.Next(1, this.Options.QubitOptions.SizeTypeMax)
            });
            #endregion

            #region [ Asteroids ]
            Int32 asteroid_feild_count = this.Random.Next(this.Options.AsteroidFieldMin, this.Options.AsteroifFieldMax);
            Int32 asteroid_feild_index = 0;

            while (asteroid_feild_index <= (asteroid_feild_count - 1))
            {
                var asteroid_gen = new Asteroid.AsteroidGenerator(this.Random.Next(), Drake.Options.Asteroid);
                model.AsteroidFields.Add(asteroid_gen.Generate());
                asteroid_feild_index = asteroid_feild_index + 1;
            }
            #endregion

            #region [ Comet ]
            Int32 comet_count = this.Random.Next(this.Options.CometMin, this.Options.CometMax);
            Int32 comet_index = 0;

            while (comet_index <= (comet_count - 1))
            {
                var comet_gen = new Comet.CometGenerator(this.Random.Next(), Drake.Options.Comet);

                model.Comets.Add(comet_gen.Generate());

                comet_index = comet_index + 1;
            }
            #endregion

            #region [ Planets ] 
            var has_planets = (this.Random.Next(0, 100)) > Drake.PercentageOfStarsWithPlanets;

            if (has_planets)
            {
                #region [ Planet ]
                Int32 planet_count = this.Random.Next(this.Options.PlanetMin, this.Options.PlanetMax);
                Int32 planet_index = 0;

                while (planet_index <= (planet_count - 1))
                {
                    // Set Planet Generation Options
                    var planet_gen = new Planet.PlanetGenerator(this.Random.Next(), Drake.Options.Planet);
                    // Generate Planet 
                    model.Planets.Add(planet_gen.Generate());

                    planet_index = planet_index - 1;
                }
                #endregion
            }
            #endregion

            return model;
        }

        public StarGenerator(Int32 SeedIdentity, StarGeneratorOptions options)
            : base("/star", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
