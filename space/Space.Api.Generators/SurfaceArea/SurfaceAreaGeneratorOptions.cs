using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.SurfaceArea
{
    public class SurfaceAreaGeneratorOptions : BaseGeneratorOptions 
    {
        public SurfaceAreaGeneratorOptions Options { get; set; }
        public SurfaceAreaModel Generate()
        {
            SurfaceAreaModel model = new SurfaceAreaModel();

            


            return model;
        }

        public SurfaceAreaGeneratorOptions() : base(new Qubit.QubitGeneratorOptions(){
            ItemCountMax = 8,
            SizeTypeMax = 1,
            ValueMax = (1024),
            ValueTypeMax = 128
        })
        {
           
        }

        public int MaxZoneCount { get; set; }

        public int MaxGridDimension { get; set; }

        public int SurfaceSizeClass { get; set; }


        public int MaxAvgElectroActivity { get; set; }

        public int MaxAvgAirPressue { get; set; }

        public int MaxAvgWindSpeed { get; set; }

        public int MaxWeatherType { get; set; }

        public int MaxLiquidContent { get; set; }

        public int MinAvgTemp { get; set; }

        public int MaxAvgTemp { get; set; }

        public int MaxAvgRockiness { get; set; }

        public int MaxAvgElevantion { get; set; }

        public int MaxTerrainGridCellType { get; set; }

        public int MaxRadius { get; set; }

        public int MaxSizeType { get; set; }
    }
}
