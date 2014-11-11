using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Bio
{
    public class BiologicalGenerator : BaseGenerator
    {
        public BiologicalGeneratorOptions Options { get; set; }

        public BiologicalModel Generate(SurfaceArea.SurfaceAreaZoneModel zone)
        {
            BiologicalModel model = new BiologicalModel();
            // Generate Qubits
            var qbit_gen = new Qubit.QubitGenerator(this.Random.Next(), this.Options.QubitOptions);
            model.Qubits = qbit_gen.Generate();

            var life_developed = (this.Random.Next(0, 100) < Drake.PercentageOfPlanetsWhereLifeDevelops);
            if (life_developed)
            {
                int life_form_count = this.Random.Next(0, this.Options.MaxLifeFormCount);
                int life_form_index = 0;

                while (life_form_index <= (life_form_count - 1))
                {
                    BiologicalLifeformModel life_form = this.Generate_LifeForm(zone);

                    life_form.BreathingType = zone.Weather


                    model.LifeForms.Add(life_form);
                    life_form_index++;
                }

            }

            return model;
        }

        private BiologicalLifeformModel Generate_LifeForm(SurfaceArea.SurfaceAreaZoneModel zone)
        {
            BiologicalLifeformModel model = new BiologicalLifeformModel();

            model.IntelligenceLife = (this.Random.Next(0, 100) <= Drake.PercentageOfLifeIsIntelligent);


            if (model.IntelligenceLife) {
                model.Civilization = this.Generate_Civilization(model);
                
            }

            return model;
        }

        private Civilization.CivilizationModel Generate_Civilization(BiologicalLifeformModel bioLifeForm)
        {
            var model = new Civilization.CivilizationModel(bioLifeForm);

            var generator = new Civilization.CivilizationGenerator(this.SeedIdentity,  )

            
            return model;
        }

        public BiologicalGenerator(Int32 SeedIdentity, BiologicalGeneratorOptions options)
            : base("/biological", SeedIdentity)
        {
            this.Options = options;
        }
    }
}
