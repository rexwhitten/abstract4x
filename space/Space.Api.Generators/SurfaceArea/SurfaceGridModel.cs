using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Api.Generators.SurfaceArea
{
    public class SurfaceGridModel
    {
        private int dimension;
       

        #region [ Properties ] 
        public Int32 Dimension
        {
            get
            {
                return this.dimension;
            }
            set
            {
                this.dimension = value;
                this.Grid = new Int32[this.dimension, this.dimension, this.dimension];
            }
        }

        public Int32 Spacing { get; set; }

        public Int32[, ,] Grid { get; set; }
        #endregion

        public SurfaceGridModel(int Dimension, int Spacing)
        {
            this.dimension = 0;
            this.Spacing = Spacing;
            this.Grid = new Int32[this.dimension, this.dimension, this.dimension];
        }

        public SurfaceGridModel()
        {
            
            this.Dimension = Dimension;
            this.Spacing = Spacing;
            this.Grid = new Int32[this.Dimension, this.Dimension, this.Dimension];
        }

    }
}
