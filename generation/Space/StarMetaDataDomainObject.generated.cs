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
    
    
    public partial class StarMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StarMetaData> Search(Space.Data.Space.StarMetaData Query) {
            Space.Data.Space.StarMetaDataDAL dal =  new Space.Data.Space.StarMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarMetaData> Search(Space.Data.Space.StarMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarMetaDataDAL dal =  new Space.Data.Space.StarMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StarMetaData> FullSearch(Space.Data.Space.StarMetaData Query, Func<Space.Data.Space.StarMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StarMetaDataDAL dal =  new Space.Data.Space.StarMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StarMetaData Query) {
            Space.Data.Space.StarMetaDataDAL dal =  new Space.Data.Space.StarMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StarMetaData Query) {
            Space.Data.Space.StarMetaDataDAL dal =  new Space.Data.Space.StarMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StarMetaData Query) {
            Space.Data.Space.StarMetaDataDAL dal =  new Space.Data.Space.StarMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
