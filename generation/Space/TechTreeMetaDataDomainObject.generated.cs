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
    
    
    public partial class TechTreeMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.TechTreeMetaData> Search(Space.Data.Space.TechTreeMetaData Query) {
            Space.Data.Space.TechTreeMetaDataDAL dal =  new Space.Data.Space.TechTreeMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeMetaData> Search(Space.Data.Space.TechTreeMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeMetaDataDAL dal =  new Space.Data.Space.TechTreeMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeMetaData> FullSearch(Space.Data.Space.TechTreeMetaData Query, Func<Space.Data.Space.TechTreeMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeMetaDataDAL dal =  new Space.Data.Space.TechTreeMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.TechTreeMetaData Query) {
            Space.Data.Space.TechTreeMetaDataDAL dal =  new Space.Data.Space.TechTreeMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.TechTreeMetaData Query) {
            Space.Data.Space.TechTreeMetaDataDAL dal =  new Space.Data.Space.TechTreeMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.TechTreeMetaData Query) {
            Space.Data.Space.TechTreeMetaDataDAL dal =  new Space.Data.Space.TechTreeMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
