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
    
    
    public partial class StructureStatusDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StructureStatus> Search(Space.Data.Space.StructureStatus Query) {
            Space.Data.Space.StructureStatusDAL dal =  new Space.Data.Space.StructureStatusDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StructureStatus> Search(Space.Data.Space.StructureStatus Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StructureStatusDAL dal =  new Space.Data.Space.StructureStatusDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StructureStatus> FullSearch(Space.Data.Space.StructureStatus Query, Func<Space.Data.Space.StructureStatus,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StructureStatusDAL dal =  new Space.Data.Space.StructureStatusDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StructureStatus Query) {
            Space.Data.Space.StructureStatusDAL dal =  new Space.Data.Space.StructureStatusDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StructureStatus Query) {
            Space.Data.Space.StructureStatusDAL dal =  new Space.Data.Space.StructureStatusDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StructureStatus Query) {
            Space.Data.Space.StructureStatusDAL dal =  new Space.Data.Space.StructureStatusDAL();
            return dal.Delete(Query);
        }
    }
}
