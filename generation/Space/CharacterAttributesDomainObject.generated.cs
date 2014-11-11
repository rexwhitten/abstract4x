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
    
    
    public partial class CharacterAttributesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.CharacterAttributes> Search(Space.Data.Space.CharacterAttributes Query) {
            Space.Data.Space.CharacterAttributesDAL dal =  new Space.Data.Space.CharacterAttributesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterAttributes> Search(Space.Data.Space.CharacterAttributes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterAttributesDAL dal =  new Space.Data.Space.CharacterAttributesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterAttributes> FullSearch(Space.Data.Space.CharacterAttributes Query, Func<Space.Data.Space.CharacterAttributes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterAttributesDAL dal =  new Space.Data.Space.CharacterAttributesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.CharacterAttributes Query) {
            Space.Data.Space.CharacterAttributesDAL dal =  new Space.Data.Space.CharacterAttributesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.CharacterAttributes Query) {
            Space.Data.Space.CharacterAttributesDAL dal =  new Space.Data.Space.CharacterAttributesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.CharacterAttributes Query) {
            Space.Data.Space.CharacterAttributesDAL dal =  new Space.Data.Space.CharacterAttributesDAL();
            return dal.Delete(Query);
        }
    }
}
