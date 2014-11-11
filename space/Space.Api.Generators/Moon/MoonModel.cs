using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Moon
{
    public class MoonModel : BaseModel
    {
        public MoonModel() : base()
        {

        }

        public SurfaceArea.SurfaceAreaModel Surface { get; set; }
    }
}
