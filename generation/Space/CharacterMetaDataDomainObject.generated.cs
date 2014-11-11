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
    
    
    public partial class CharacterMetaDataDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.CharacterMetaData> Search(Space.Data.Space.CharacterMetaData Query) {
            Space.Data.Space.CharacterMetaDataDAL dal =  new Space.Data.Space.CharacterMetaDataDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterMetaData> Search(Space.Data.Space.CharacterMetaData Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterMetaDataDAL dal =  new Space.Data.Space.CharacterMetaDataDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.CharacterMetaData> FullSearch(Space.Data.Space.CharacterMetaData Query, Func<Space.Data.Space.CharacterMetaData,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.CharacterMetaDataDAL dal =  new Space.Data.Space.CharacterMetaDataDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.CharacterMetaData Query) {
            Space.Data.Space.CharacterMetaDataDAL dal =  new Space.Data.Space.CharacterMetaDataDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.CharacterMetaData Query) {
            Space.Data.Space.CharacterMetaDataDAL dal =  new Space.Data.Space.CharacterMetaDataDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.CharacterMetaData Query) {
            Space.Data.Space.CharacterMetaDataDAL dal =  new Space.Data.Space.CharacterMetaDataDAL();
            return dal.Delete(Query);
        }
    }
}
