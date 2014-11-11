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
    
    
    public partial class CharacterTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.CharacterTypes> Search(Space.Data.Space.CharacterTypes Query) {
            Space.Data.Space.CharacterTypesDAL dal =  new Space.Data.Space.CharacterTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterTypes> Search(Space.Data.Space.CharacterTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterTypesDAL dal =  new Space.Data.Space.CharacterTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterTypes> FullSearch(Space.Data.Space.CharacterTypes Query, Func<Space.Data.Space.CharacterTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterTypesDAL dal =  new Space.Data.Space.CharacterTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.CharacterTypes Query) {
            Space.Data.Space.CharacterTypesDAL dal =  new Space.Data.Space.CharacterTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.CharacterTypes Query) {
            Space.Data.Space.CharacterTypesDAL dal =  new Space.Data.Space.CharacterTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.CharacterTypes Query) {
            Space.Data.Space.CharacterTypesDAL dal =  new Space.Data.Space.CharacterTypesDAL();
            return dal.Delete(Query);
        }
    }
}
