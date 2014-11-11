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
    
    
    public partial class GalaxyMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.GalaxyMetaData> Search(Space.Data.Space.GalaxyMetaData Query) {
            Space.Data.Space.GalaxyMetaDataDAL dal =  new Space.Data.Space.GalaxyMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.GalaxyMetaData> Search(Space.Data.Space.GalaxyMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxyMetaDataDAL dal =  new Space.Data.Space.GalaxyMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.GalaxyMetaData> FullSearch(Space.Data.Space.GalaxyMetaData Query, Func<Space.Data.Space.GalaxyMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.GalaxyMetaDataDAL dal =  new Space.Data.Space.GalaxyMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.GalaxyMetaData Query) {
            Space.Data.Space.GalaxyMetaDataDAL dal =  new Space.Data.Space.GalaxyMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.GalaxyMetaData Query) {
            Space.Data.Space.GalaxyMetaDataDAL dal =  new Space.Data.Space.GalaxyMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.GalaxyMetaData Query) {
            Space.Data.Space.GalaxyMetaDataDAL dal =  new Space.Data.Space.GalaxyMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
