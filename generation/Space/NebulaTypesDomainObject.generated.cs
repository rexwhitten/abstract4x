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
    
    
    public partial class NebulaTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.NebulaTypes> Search(Space.Data.Space.NebulaTypes Query) {
            Space.Data.Space.NebulaTypesDAL dal =  new Space.Data.Space.NebulaTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.NebulaTypes> Search(Space.Data.Space.NebulaTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.NebulaTypesDAL dal =  new Space.Data.Space.NebulaTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.NebulaTypes> FullSearch(Space.Data.Space.NebulaTypes Query, Func<Space.Data.Space.NebulaTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.NebulaTypesDAL dal =  new Space.Data.Space.NebulaTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.NebulaTypes Query) {
            Space.Data.Space.NebulaTypesDAL dal =  new Space.Data.Space.NebulaTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.NebulaTypes Query) {
            Space.Data.Space.NebulaTypesDAL dal =  new Space.Data.Space.NebulaTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.NebulaTypes Query) {
            Space.Data.Space.NebulaTypesDAL dal =  new Space.Data.Space.NebulaTypesDAL();
            return dal.Delete(Query);
        }
    }
}
