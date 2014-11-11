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
    
    
    public partial class NebulaMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.NebulaMetaData> Search(Space.Data.Space.NebulaMetaData Query) {
            Space.Data.Space.NebulaMetaDataDAL dal =  new Space.Data.Space.NebulaMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.NebulaMetaData> Search(Space.Data.Space.NebulaMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.NebulaMetaDataDAL dal =  new Space.Data.Space.NebulaMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.NebulaMetaData> FullSearch(Space.Data.Space.NebulaMetaData Query, Func<Space.Data.Space.NebulaMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.NebulaMetaDataDAL dal =  new Space.Data.Space.NebulaMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.NebulaMetaData Query) {
            Space.Data.Space.NebulaMetaDataDAL dal =  new Space.Data.Space.NebulaMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.NebulaMetaData Query) {
            Space.Data.Space.NebulaMetaDataDAL dal =  new Space.Data.Space.NebulaMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.NebulaMetaData Query) {
            Space.Data.Space.NebulaMetaDataDAL dal =  new Space.Data.Space.NebulaMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
