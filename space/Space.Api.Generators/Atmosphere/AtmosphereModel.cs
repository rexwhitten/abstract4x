using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Atmosphere
{
    public class AtmosphereModel : List<AtmoshpereLayerModel>
    {
        public AtmosphereModel() {

        }
    }

    public class AtmoshpereLayerModel : BaseModel
    {

        public AtmoshpereLayerModel() : base()
        {
            // defaults
            this.Radius = 1;
            this.SizeType = 0;
        }
    }
}
