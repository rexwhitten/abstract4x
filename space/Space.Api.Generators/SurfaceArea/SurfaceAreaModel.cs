using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.SurfaceArea
{
    public class SurfaceAreaModel : List<SurfaceAreaZoneModel>
    {

        public SurfaceAreaModel() : base()
        {
            
        }
    }

    public class SurfaceAreaZoneModel : BaseModel
    {
        public SurfaceGridModel Grid { get; set; }

        public SurfaceAreaWeatherModel Weather { get; set; }

        public SurfaceAreaTerrainModel Terrain { get; set; }



        public SurfaceAreaZoneModel(int Size)
            : base()
        {
            this.Radius = 10; // Need Unit Library
            this.SizeType = BaseSizeType.Basic.Value();
            this.Grid = new SurfaceGridModel(Size, 256); // 256 is a magic number, what controls the spacing ?
        }

        public Bio.BiologicalModel Biological { get; set; }
    }
}
