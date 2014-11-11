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
    
    
    public partial class MoonsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.Moons> Search(Space.Data.Space.Moons Query) {
            Space.Data.Space.MoonsDAL dal =  new Space.Data.Space.MoonsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.Moons> Search(Space.Data.Space.Moons Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonsDAL dal =  new Space.Data.Space.MoonsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.Moons> FullSearch(Space.Data.Space.Moons Query, Func<Space.Data.Space.Moons,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.MoonsDAL dal =  new Space.Data.Space.MoonsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.Moons Query) {
            Space.Data.Space.MoonsDAL dal =  new Space.Data.Space.MoonsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.Moons Query) {
            Space.Data.Space.MoonsDAL dal =  new Space.Data.Space.MoonsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.Moons Query) {
            Space.Data.Space.MoonsDAL dal =  new Space.Data.Space.MoonsDAL();
            return dal.Delete(Query);
        }
    }
}
