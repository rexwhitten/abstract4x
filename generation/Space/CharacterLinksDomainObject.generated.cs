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
    
    
    public partial class CharacterLinksDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.CharacterLinks> Search(Space.Data.Space.CharacterLinks Query) {
            Space.Data.Space.CharacterLinksDAL dal =  new Space.Data.Space.CharacterLinksDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterLinks> Search(Space.Data.Space.CharacterLinks Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterLinksDAL dal =  new Space.Data.Space.CharacterLinksDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterLinks> FullSearch(Space.Data.Space.CharacterLinks Query, Func<Space.Data.Space.CharacterLinks,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterLinksDAL dal =  new Space.Data.Space.CharacterLinksDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.CharacterLinks Query) {
            Space.Data.Space.CharacterLinksDAL dal =  new Space.Data.Space.CharacterLinksDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.CharacterLinks Query) {
            Space.Data.Space.CharacterLinksDAL dal =  new Space.Data.Space.CharacterLinksDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.CharacterLinks Query) {
            Space.Data.Space.CharacterLinksDAL dal =  new Space.Data.Space.CharacterLinksDAL();
            return dal.Delete(Query);
        }
    }
}
