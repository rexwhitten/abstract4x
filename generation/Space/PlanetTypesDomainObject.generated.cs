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
    
    
    public partial class PlanetTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.PlanetTypes> Search(Space.Data.Space.PlanetTypes Query) {
            Space.Data.Space.PlanetTypesDAL dal =  new Space.Data.Space.PlanetTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlanetTypes> Search(Space.Data.Space.PlanetTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlanetTypesDAL dal =  new Space.Data.Space.PlanetTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.PlanetTypes> FullSearch(Space.Data.Space.PlanetTypes Query, Func<Space.Data.Space.PlanetTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.PlanetTypesDAL dal =  new Space.Data.Space.PlanetTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.PlanetTypes Query) {
            Space.Data.Space.PlanetTypesDAL dal =  new Space.Data.Space.PlanetTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.PlanetTypes Query) {
            Space.Data.Space.PlanetTypesDAL dal =  new Space.Data.Space.PlanetTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.PlanetTypes Query) {
            Space.Data.Space.PlanetTypesDAL dal =  new Space.Data.Space.PlanetTypesDAL();
            return dal.Delete(Query);
        }
    }
}
