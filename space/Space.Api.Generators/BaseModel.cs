using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators
{
    public class BaseModel
    {
        #region [ Position ]
        public Vector3 Position { get; set; }
        #endregion

        #region [ Attributes ]
        public Int32 SizeType { get; set; }

        public Int32 Radius { get; set; }
        #endregion

        #region [ Qubit Values ]
        public Qubit.QubitModel Qubits { get; set; }
        #endregion

        public BaseModel()
        {
            this.Qubits = new Qubit.QubitModel();
            this.Position = new Vector3();
        }
    }
}
