using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Civilization
{
    public class CivilizationModel : BaseModel
    {
        private Bio.BiologicalLifeformModel lifeFormModel;

        public TechTree.TechTreeModel TechTree { get; set; }

        public CivilizationModel(Bio.BiologicalLifeformModel model)
        {
            this.lifeFormModel = model;
        }

        public int CivilizationType { get; set; }

        public int SocialType { get; set; }

        public int ExternalCommunicationType { get; set; }

        public int ExternalDiplomacyType { get; set; }
    }
}
