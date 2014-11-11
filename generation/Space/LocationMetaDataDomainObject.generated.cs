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
    
    
    public partial class LocationMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.LocationMetaData> Search(Space.Data.Space.LocationMetaData Query) {
            Space.Data.Space.LocationMetaDataDAL dal =  new Space.Data.Space.LocationMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.LocationMetaData> Search(Space.Data.Space.LocationMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.LocationMetaDataDAL dal =  new Space.Data.Space.LocationMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.LocationMetaData> FullSearch(Space.Data.Space.LocationMetaData Query, Func<Space.Data.Space.LocationMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.LocationMetaDataDAL dal =  new Space.Data.Space.LocationMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.LocationMetaData Query) {
            Space.Data.Space.LocationMetaDataDAL dal =  new Space.Data.Space.LocationMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.LocationMetaData Query) {
            Space.Data.Space.LocationMetaDataDAL dal =  new Space.Data.Space.LocationMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.LocationMetaData Query) {
            Space.Data.Space.LocationMetaDataDAL dal =  new Space.Data.Space.LocationMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
