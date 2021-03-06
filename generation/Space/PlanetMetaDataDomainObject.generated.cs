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
    
    
    public partial class PlanetMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlanetMetaData> Search(Space.Data.Space.PlanetMetaData Query) {
            Space.Data.Space.PlanetMetaDataDAL dal =  new Space.Data.Space.PlanetMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlanetMetaData> Search(Space.Data.Space.PlanetMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlanetMetaDataDAL dal =  new Space.Data.Space.PlanetMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlanetMetaData> FullSearch(Space.Data.Space.PlanetMetaData Query, Func<Space.Data.Space.PlanetMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlanetMetaDataDAL dal =  new Space.Data.Space.PlanetMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlanetMetaData Query) {
            Space.Data.Space.PlanetMetaDataDAL dal =  new Space.Data.Space.PlanetMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlanetMetaData Query) {
            Space.Data.Space.PlanetMetaDataDAL dal =  new Space.Data.Space.PlanetMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlanetMetaData Query) {
            Space.Data.Space.PlanetMetaDataDAL dal =  new Space.Data.Space.PlanetMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
