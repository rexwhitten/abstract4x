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
    
    
    public partial class StructureMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StructureMetaData> Search(Space.Data.Space.StructureMetaData Query) {
            Space.Data.Space.StructureMetaDataDAL dal =  new Space.Data.Space.StructureMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StructureMetaData> Search(Space.Data.Space.StructureMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StructureMetaDataDAL dal =  new Space.Data.Space.StructureMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StructureMetaData> FullSearch(Space.Data.Space.StructureMetaData Query, Func<Space.Data.Space.StructureMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StructureMetaDataDAL dal =  new Space.Data.Space.StructureMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StructureMetaData Query) {
            Space.Data.Space.StructureMetaDataDAL dal =  new Space.Data.Space.StructureMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StructureMetaData Query) {
            Space.Data.Space.StructureMetaDataDAL dal =  new Space.Data.Space.StructureMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StructureMetaData Query) {
            Space.Data.Space.StructureMetaDataDAL dal =  new Space.Data.Space.StructureMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
