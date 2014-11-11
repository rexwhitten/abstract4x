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
    
    
    public partial class GalaxysDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.Galaxys> Search(Space.Data.Space.Galaxys Query) {
            Space.Data.Space.GalaxysDAL dal =  new Space.Data.Space.GalaxysDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.Galaxys> Search(Space.Data.Space.Galaxys Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxysDAL dal =  new Space.Data.Space.GalaxysDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.Galaxys> FullSearch(Space.Data.Space.Galaxys Query, Func<Space.Data.Space.Galaxys,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxysDAL dal =  new Space.Data.Space.GalaxysDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.Galaxys Query) {
            Space.Data.Space.GalaxysDAL dal =  new Space.Data.Space.GalaxysDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.Galaxys Query) {
            Space.Data.Space.GalaxysDAL dal =  new Space.Data.Space.GalaxysDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.Galaxys Query) {
            Space.Data.Space.GalaxysDAL dal =  new Space.Data.Space.GalaxysDAL();
            return dal.Delete(Query);
        }
    }
}
