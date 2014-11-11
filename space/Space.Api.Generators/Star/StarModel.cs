using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Star
{
    public class StarModel : BaseModel
    {
        public List<Asteroid.AsteroidModel> AsteroidFields { get; set; }
        public List<Comet.CometModel> Comets { get; set; }

        public List<Planet.PlanetModel> Planets { get; set; }

        public StarModel()
        {
            this.AsteroidFields = new List<Asteroid.AsteroidModel>();
            this.Comets = new List<Comet.CometModel>();
            this.Planets = new List<Planet.PlanetModel>();
        }

        public int StarAge { get; set; }

        public int StarType { get; set; }
    }
}
