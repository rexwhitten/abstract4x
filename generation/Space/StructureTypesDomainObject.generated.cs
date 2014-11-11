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
    
    
    public partial class StructureTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.StructureTypes> Search(Space.Data.Space.StructureTypes Query) {
            Space.Data.Space.StructureTypesDAL dal =  new Space.Data.Space.StructureTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.StructureTypes> Search(Space.Data.Space.StructureTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.StructureTypesDAL dal =  new Space.Data.Space.StructureTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.StructureTypes> FullSearch(Space.Data.Space.StructureTypes Query, Func<Space.Data.Space.StructureTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.StructureTypesDAL dal =  new Space.Data.Space.StructureTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.StructureTypes Query) {
            Space.Data.Space.StructureTypesDAL dal =  new Space.Data.Space.StructureTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.StructureTypes Query) {
            Space.Data.Space.StructureTypesDAL dal =  new Space.Data.Space.StructureTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.StructureTypes Query) {
            Space.Data.Space.StructureTypesDAL dal =  new Space.Data.Space.StructureTypesDAL();
            return dal.Delete(Query);
        }
    }
}
