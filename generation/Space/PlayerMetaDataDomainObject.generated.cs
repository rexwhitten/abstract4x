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
    
    
    public partial class PlayerMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlayerMetaData> Search(Space.Data.Space.PlayerMetaData Query) {
            Space.Data.Space.PlayerMetaDataDAL dal =  new Space.Data.Space.PlayerMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerMetaData> Search(Space.Data.Space.PlayerMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerMetaDataDAL dal =  new Space.Data.Space.PlayerMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlayerMetaData> FullSearch(Space.Data.Space.PlayerMetaData Query, Func<Space.Data.Space.PlayerMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlayerMetaDataDAL dal =  new Space.Data.Space.PlayerMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlayerMetaData Query) {
            Space.Data.Space.PlayerMetaDataDAL dal =  new Space.Data.Space.PlayerMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlayerMetaData Query) {
            Space.Data.Space.PlayerMetaDataDAL dal =  new Space.Data.Space.PlayerMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlayerMetaData Query) {
            Space.Data.Space.PlayerMetaDataDAL dal =  new Space.Data.Space.PlayerMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
