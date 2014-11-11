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
    
    
    public partial class StarSectorMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarSectorMetaData> Search(Space.Data.Space.StarSectorMetaData Query) {
            Space.Data.Space.StarSectorMetaDataDAL dal =  new Space.Data.Space.StarSectorMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorMetaData> Search(Space.Data.Space.StarSectorMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorMetaDataDAL dal =  new Space.Data.Space.StarSectorMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarSectorMetaData> FullSearch(Space.Data.Space.StarSectorMetaData Query, Func<Space.Data.Space.StarSectorMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarSectorMetaDataDAL dal =  new Space.Data.Space.StarSectorMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarSectorMetaData Query) {
            Space.Data.Space.StarSectorMetaDataDAL dal =  new Space.Data.Space.StarSectorMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarSectorMetaData Query) {
            Space.Data.Space.StarSectorMetaDataDAL dal =  new Space.Data.Space.StarSectorMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarSectorMetaData Query) {
            Space.Data.Space.StarSectorMetaDataDAL dal =  new Space.Data.Space.StarSectorMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
