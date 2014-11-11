using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Atmosphere
{
    public class AtmosphereGeneratorOptions  : BaseGeneratorOptions
    {
        #region [ Constructor ]
        public AtmosphereGeneratorOptions() : base(new Qubit.QubitGeneratorOptions(){
            ItemCountMax = 4,
            SizeTypeMax = 8,
            ValueTypeMax = 8,
            ValueMax = (1024) * 4
        })
        {
            this.LayerHeightMax = 1000;
            this.LayerMaxWindSpeed = 2000;
            this.LayerMaxElectricActivity = 1000;
            this.LayerMaxTemp = 1000;
        }
        #endregion

        #region [ Properties ] 
        public int LayerHeightMax { get; set; }

        public int LayerMaxWindSpeed { get; set; }

        public int LayerMaxElectricActivity { get; set; }

        public int LayerMaxTemp { get; set; }
        #endregion
    }
}
