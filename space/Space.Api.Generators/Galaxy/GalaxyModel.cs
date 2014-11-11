using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Galaxy
{
    public class GalaxyModel : BaseModel
    {
        public List<Star.StarModel> Stars { get; set;  }

        public GalaxyModel()
            : base()
        {
            this.Stars = new List<Star.StarModel>();

        }
    }
}
