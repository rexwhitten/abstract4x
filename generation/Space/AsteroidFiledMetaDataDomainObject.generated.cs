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
    
    
    public partial class AsteroidFiledMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledMetaData> Search(Space.Data.Space.AsteroidFiledMetaData Query) {
            Space.Data.Space.AsteroidFiledMetaDataDAL dal =  new Space.Data.Space.AsteroidFiledMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledMetaData> Search(Space.Data.Space.AsteroidFiledMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledMetaDataDAL dal =  new Space.Data.Space.AsteroidFiledMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.AsteroidFiledMetaData> FullSearch(Space.Data.Space.AsteroidFiledMetaData Query, Func<Space.Data.Space.AsteroidFiledMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.AsteroidFiledMetaDataDAL dal =  new Space.Data.Space.AsteroidFiledMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.AsteroidFiledMetaData Query) {
            Space.Data.Space.AsteroidFiledMetaDataDAL dal =  new Space.Data.Space.AsteroidFiledMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.AsteroidFiledMetaData Query) {
            Space.Data.Space.AsteroidFiledMetaDataDAL dal =  new Space.Data.Space.AsteroidFiledMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.AsteroidFiledMetaData Query) {
            Space.Data.Space.AsteroidFiledMetaDataDAL dal =  new Space.Data.Space.AsteroidFiledMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
