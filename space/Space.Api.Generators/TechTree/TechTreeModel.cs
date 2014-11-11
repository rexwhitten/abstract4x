using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.TechTree
{
    public class TechTreeModel : BaseModel
    {
        public List<TechTreeModelItem> Items { get; set; }
        public TechTreeModel()
            : base()
        {
            this.Items = new List<TechTreeModelItem>();
        }
    }

    public class TechTreeModelItem
    {
        #region [ Qubits ]
        public Qubit.QubitModel Required { get; set; }

        public List<TechTreeModel> RequiredTech { get; set; }

        public Qubit.QubitModel Produces { get; set; }
        #endregion

        public TechTreeModelItem()
        {
            this.Required = new Qubit.QubitModel();
            this.RequiredTech = new List<TechTreeModel>();
            this.Produces = new Qubit.QubitModel();
        }
    }
}
