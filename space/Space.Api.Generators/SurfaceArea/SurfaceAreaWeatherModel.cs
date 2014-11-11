using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.SurfaceArea
{
    public class SurfaceAreaWeatherModel
    {
        public int ElectroActivity { get; set; }

        public int AirPressure { get; set; }

        public int AvgElectroActivity { get; set; }

        public int AvgAirPressure { get; set; }

        public int AvgWindSpeed { get; set; }

        public int AvgLiquidContent { get; set; }

        public int AvgTemperature { get; set; }

        public int AvgSkyCover { get; set; }

        public int AvgWeatherType { get; set; }
    }
}
