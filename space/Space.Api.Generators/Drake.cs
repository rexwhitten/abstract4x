using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators
{
    public static class Drake
    {
        public static int RateOfStarFormation { get; set; }
        public static int PercentageOfStarsWithPlanets { get; set; }

        public static GenerationOptions Options { get; set; }

        public static Galaxy.GalaxyModel Generate(Int32 DrakeKey)
        {
            var galaxy_generator = new Galaxy.GalaxyGenerator(DrakeKey, Drake.Options.Galaxy);

            var galaxy_model = galaxy_generator.Genetrate();

            return galaxy_model;
        }

        public static int AveragePlanetsPerStarThatSupportLife { get; set; }

        public static int PercentageOfPlanetsWhereLifeDevelops { get; set; }

        public static int PercentageOfLifeIsIntelligent { get; set; }
    }
}
