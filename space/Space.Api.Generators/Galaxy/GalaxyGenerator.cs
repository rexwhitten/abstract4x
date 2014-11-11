using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Galaxy
{
    
    public class GalaxyGenerator : BaseGenerator
    {
        public GalaxyGeneratorOptions Options { get; set; }
        public GalaxyModel Genetrate()
        {
            GalaxyModel model = new GalaxyModel();

            #region [ Stars ]
            var star_count = this.Random.Next(this.Options.StarMin, this.Options.StarMax) / Drake.RateOfStarFormation;
            var star_index = 0;

            while (star_index <= (star_count - 1))
            {
                var star_generator = new Star.StarGenerator(this.Random.Next(), Drake.Options.Star);

                model.Stars.Add(star_generator.Generate());
                
                // finally, increment the star index
                star_index = star_index + 1;
            }
            #endregion

            return model;
        }
        public GalaxyGenerator(Int32 SeedIdentity, GalaxyGeneratorOptions options)
            : base("/galaxy", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
