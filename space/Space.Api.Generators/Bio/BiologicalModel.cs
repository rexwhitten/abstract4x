using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Bio
{
    public class BiologicalModel : BaseModel
    {
        
        public List<BiologicalLifeformModel> LifeForms { get; set; }
        public BiologicalModel() : base() { 
           
        }
    }

    public class BiologicalLifeformModel
    {
        public BiologicalLifeformModel()
        {

        }

        public bool IntelligenceLife { get; set; }

        public Civilization.CivilizationModel Civilization { get; set; }
    }
}
