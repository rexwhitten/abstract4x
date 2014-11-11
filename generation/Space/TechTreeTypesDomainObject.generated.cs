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
    
    
    public partial class TechTreeTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.TechTreeTypes> Search(Space.Data.Space.TechTreeTypes Query) {
            Space.Data.Space.TechTreeTypesDAL dal =  new Space.Data.Space.TechTreeTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeTypes> Search(Space.Data.Space.TechTreeTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeTypesDAL dal =  new Space.Data.Space.TechTreeTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.TechTreeTypes> FullSearch(Space.Data.Space.TechTreeTypes Query, Func<Space.Data.Space.TechTreeTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.TechTreeTypesDAL dal =  new Space.Data.Space.TechTreeTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.TechTreeTypes Query) {
            Space.Data.Space.TechTreeTypesDAL dal =  new Space.Data.Space.TechTreeTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.TechTreeTypes Query) {
            Space.Data.Space.TechTreeTypesDAL dal =  new Space.Data.Space.TechTreeTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.TechTreeTypes Query) {
            Space.Data.Space.TechTreeTypesDAL dal =  new Space.Data.Space.TechTreeTypesDAL();
            return dal.Delete(Query);
        }
    }
}
