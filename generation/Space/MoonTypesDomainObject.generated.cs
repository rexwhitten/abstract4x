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
    
    
    public partial class MoonTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.MoonTypes> Search(Space.Data.Space.MoonTypes Query) {
            Space.Data.Space.MoonTypesDAL dal =  new Space.Data.Space.MoonTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonTypes> Search(Space.Data.Space.MoonTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonTypesDAL dal =  new Space.Data.Space.MoonTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.MoonTypes> FullSearch(Space.Data.Space.MoonTypes Query, Func<Space.Data.Space.MoonTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonTypesDAL dal =  new Space.Data.Space.MoonTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.MoonTypes Query) {
            Space.Data.Space.MoonTypesDAL dal =  new Space.Data.Space.MoonTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.MoonTypes Query) {
            Space.Data.Space.MoonTypesDAL dal =  new Space.Data.Space.MoonTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.MoonTypes Query) {
            Space.Data.Space.MoonTypesDAL dal =  new Space.Data.Space.MoonTypesDAL();
            return dal.Delete(Query);
        }
    }
}
