using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Planet
{
    public class PlanetModel : BaseModel
    {
        public List<Moon.MoonModel> Moons { get; set; }

        public Atmosphere.AtmosphereModel Atmosphere { get; set; }

        public PlanetModel()
            : base()
        {
            this.Moons = new List<Moon.MoonModel>();
            this.Atmosphere = new Atmosphere.AtmosphereModel();
        }

        public SurfaceArea.SurfaceAreaModel Surface { get; set; }
    }
}
