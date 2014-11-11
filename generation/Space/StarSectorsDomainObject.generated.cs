namespace Space.Data.Space {
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Data;
    using System.Xml;
    using System.Xml.Linq;
    using Space;
    using Space.Data;
    using System.Runtime.Serialization;
    
    
    public partial class StarSectorsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarSectors> Search(Space.Data.Space.StarSectors Query) {
            Space.Data.Space.StarSectorsDAL dal =  new Space.Data.Space.StarSectorsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectors> Search(Space.Data.Space.StarSectors Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorsDAL dal =  new Space.Data.Space.StarSectorsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectors> FullSearch(Space.Data.Space.StarSectors Query, Func<Space.Data.Space.StarSectors,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorsDAL dal =  new Space.Data.Space.StarSectorsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarSectors Query) {
            Space.Data.Space.StarSectorsDAL dal =  new Space.Data.Space.StarSectorsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarSectors Query) {
            Space.Data.Space.StarSectorsDAL dal =  new Space.Data.Space.StarSectorsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarSectors Query) {
            Space.Data.Space.StarSectorsDAL dal =  new Space.Data.Space.StarSectorsDAL();
            return dal.Delete(Query);
        }
    }
}
