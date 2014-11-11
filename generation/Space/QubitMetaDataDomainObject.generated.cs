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
    
    
    public partial class QubitMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitMetaData> Search(Space.Data.Space.QubitMetaData Query) {
            Space.Data.Space.QubitMetaDataDAL dal =  new Space.Data.Space.QubitMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitMetaData> Search(Space.Data.Space.QubitMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitMetaDataDAL dal =  new Space.Data.Space.QubitMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitMetaData> FullSearch(Space.Data.Space.QubitMetaData Query, Func<Space.Data.Space.QubitMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitMetaDataDAL dal =  new Space.Data.Space.QubitMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitMetaData Query) {
            Space.Data.Space.QubitMetaDataDAL dal =  new Space.Data.Space.QubitMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitMetaData Query) {
            Space.Data.Space.QubitMetaDataDAL dal =  new Space.Data.Space.QubitMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitMetaData Query) {
            Space.Data.Space.QubitMetaDataDAL dal =  new Space.Data.Space.QubitMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
