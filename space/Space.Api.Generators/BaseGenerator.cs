using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators
{
    public class BaseGenerator
    {
        
        public Int32 SeedIdentity { get; set; }

        public String TypePath { get; set;  }

        public Random Random
        {
            get
            {
                return new Random(this.SeedIdentity);
            }
        }

        public BaseGenerator(String TypePath, Int32 SeedIdentity)
        {
            this.SeedIdentity = SeedIdentity;
            this.TypePath = TypePath;
        }
    }
}
