using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.SurfaceArea
{
    public class SurfaceAreaGenerator : BaseGenerator 
    {
        private Int32 CurrentDept = 0;

        public SurfaceAreaGeneratorOptions Options { get; set; }

        public SurfaceAreaModel Generate(bool force_no_life = false)
        {
            SurfaceAreaModel model = new SurfaceAreaModel();
           
            Int32 zone_count = this.Random.Next(0, this.Options.MaxZoneCount);
            Int32 zone_index = 0;

            while (zone_index <= (zone_count - 1))
            {
                var zone = new SurfaceAreaZoneModel(this.Random.Next(0, 16));

                zone.Grid = new SurfaceGridModel(
                    this.Random.Next(32,this.Options.MaxGridDimension),
                    this.Options.SurfaceSizeClass
                );
                // Generate Qubits
                var qbit_gen = new Qubit.QubitGenerator(this.Random.Next(), this.Options.QubitOptions);
                zone.Qubits = qbit_gen.Generate();

                zone.Radius = this.Random.Next(0, this.Options.MaxRadius);
                zone.SizeType = this.Random.Next(0, this.Options.MaxSizeType);
                zone.Grid = this.Generate_Grid(zone.SizeType);
                zone.Terrain = this.Generate_Terrain();
                zone.Position = new Vector3(zone_index, 0, 0);
                zone.Weather = this.Generate_Weather();

                if (force_no_life == false)
                {
                    if (this.Random.Next(0, 100) < (Drake.AveragePlanetsPerStarThatSupportLife))
                    {
                        #region [ bological ]
                        zone.Biological = new Bio.BiologicalModel();
                        var bio_gen = new Bio.BiologicalGenerator(this.Random.Next(), Drake.Options.Biological);
                        zone.Biological = bio_gen.Generate(zone);
                        #endregion
                    }
                }

                // Add 
                model.Add(zone);
                // Increment
                zone_index = zone_index + 1;
            }

            return model;
        }

        private SurfaceAreaWeatherModel Generate_Weather()
        {
            SurfaceAreaWeatherModel model = new SurfaceAreaWeatherModel();

            model.AvgWeatherType = this.Random.Next(0, this.Options.MaxWeatherType);
            model.AvgElectroActivity = this.Random.Next(0, this.Options.MaxAvgElectroActivity);
            model.AvgAirPressure = this.Random.Next(0 , this.Options.MaxAvgAirPressue);
            model.AvgWindSpeed = this.Random.Next(0, this.Options.MaxAvgWindSpeed);
            model.AvgLiquidContent = this.Random.Next(0, this.Options.MaxLiquidContent);
            model.AvgTemperature = this.Random.Next(this.Options.MinAvgTemp, this.Options.MaxAvgTemp);
            model.AvgSkyCover = this.Random.Next(0, 100);

            return model;
        }

        private SurfaceAreaTerrainModel Generate_Terrain()
        {
            SurfaceAreaTerrainModel model = new SurfaceAreaTerrainModel();

            model.SeaLevel = this.Random.Next(0, this.MaxSeaLevel);
            model.TerrainType = this.Random.Next(0, this.MaxTerrainType);
            model.TerrainSpectrumType = this.Random.Next(0, this.MaxTerrainSpectrumType);
            model.AvgRockiness = this.Random.Next(0, this.Options.MaxAvgRockiness);
            model.AvgElevation = this.Random.Next(0, this.Options.MaxAvgElevantion);
            model.PercentageFroze = this.Random.Next(0, 100);
            model.PercentageMolten = this.Random.Next(model.PercentageFroze, 100);
            
            // Biological Terrain 
            

            return model;
        }

        private SurfaceGridModel Generate_Grid(Int32 SizeType)
        {
            SurfaceGridModel model = new SurfaceGridModel(SizeType, SizeType);

            int lat_index = 0;
            int lon_index = 0;
            int ele_index = 0;
            int type_index = 0;

            while (lat_index <= (SizeType - 1))
            {
                while (lon_index <= (SizeType - 1))
                {
                    while (ele_index <= (SizeType - 1))
                    {
                        type_index = Random.Next(0, this.Options.MaxTerrainGridCellType);
                        model.Grid[lat_index, lon_index, ele_index] = type_index;

                        ele_index = ele_index + 1;
                    }

                    lon_index = lon_index + 1;
                }

                lat_index = lat_index + 1;
            }

            

            return model;
        }

        public SurfaceAreaGenerator(Int32 SeedIdentity, SurfaceAreaGeneratorOptions options)
            : base("/surfacearea", SeedIdentity)
        {
            this.Options = options;
        }

        public int MaxSeaLevel { get; set; }

        public int MaxTerrainType { get; set; }

        public int MaxTerrainSpectrumType { get; set; }
    }
}
