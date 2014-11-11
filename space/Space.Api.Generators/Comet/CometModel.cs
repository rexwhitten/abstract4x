using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Comet
{
    public class CometModel : BaseModel
    {
        

        public CometModel()
        {
            
        }

        public int OrbitalSpeed { get; set; }

        public SurfaceArea.SurfaceAreaModel SurfaceArea { get; set; }

        public int DistanceFromStar { get; set; }

        public int OrbitalDiameter { get; set; }
    }
}
