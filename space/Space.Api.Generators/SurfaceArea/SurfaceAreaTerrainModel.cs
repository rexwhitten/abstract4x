using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.SurfaceArea
{
    public class SurfaceAreaTerrainModel
    {
        public SurfaceAreaTerrainModel()
        {

        }

        public int SeaLevel { get; set; }

        public int TerrainType { get; set; }

        public int TerrainSpectrumType { get; set; }

        public int AvgRockiness { get; set; }

        public int AvgElevation { get; set; }

        public int PercentageFroze { get; set; }

        public int PercentageMolten { get; set; }
    }
}
