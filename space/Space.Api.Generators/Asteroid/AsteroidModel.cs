using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Asteroid
{
    public class AsteroidModel : BaseModel 
    {
      
        public AsteroidModel() : base()
        {
         
        }

        public int FieldSize { get; set; }

        public int AverageAsteroidSize { get; set; }

        public int AverageSpeed { get; set; }
    }
}
