using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators
{
    public class GenerationOptions
    {
        public Galaxy.GalaxyGeneratorOptions Galaxy { get; set; }

        public Asteroid.AsteroidGeneratorOptions Asteroid { get; set;  }

        public Atmosphere.AtmosphereGeneratorOptions Atmosphere { get; set; }

        public Comet.CometGeneratorOptions Comet { get; set; }

        public Moon.MoonGeneratorOptions Moon { get; set; }

        public Planet.PlanetGeneratorOptions Planet { get; set; }

        public Qubit.QubitGeneratorOptions Qubit { get; set; }

        public Star.StarGeneratorOptions Star { get; set; }

        public SurfaceArea.SurfaceAreaGeneratorOptions SurfaceArea { get ;set;}

        public GenerationOptions() : base(){
            this.Asteroid = new Asteroid.AsteroidGeneratorOptions();
            this.Atmosphere = new Atmosphere.AtmosphereGeneratorOptions();
            this.Comet = new Comet.CometGeneratorOptions();
            this.Galaxy = new Galaxy.GalaxyGeneratorOptions();
            this.Moon = new Moon.MoonGeneratorOptions();
            this.Planet = new Planet.PlanetGeneratorOptions();
            this.Qubit = new Qubit.QubitGeneratorOptions();
            this.Star = new Star.StarGeneratorOptions();
            this.SurfaceArea = new SurfaceArea.SurfaceAreaGeneratorOptions();
        }

        public Bio.BiologicalGeneratorOptions Biological { get; set; }
    }
}
