using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.Qubit
{
    public class QubitModel : List<QubitItemModel>
    {


        public QubitModel()
        {

        }
    }


    public class QubitItemModel
    {

        public Int32 Value { get; set; }
        public int ValueType { get; set; }
        public int SizeType { get; set; }

        public QubitItemModel()
        {
            this.Value = 0;
            this.ValueType = 0;
            this.SizeType = 0;
        }
    }


}
