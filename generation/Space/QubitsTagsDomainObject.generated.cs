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
    
    
    public partial class QubitsTagsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitsTags> Search(Space.Data.Space.QubitsTags Query) {
            Space.Data.Space.QubitsTagsDAL dal =  new Space.Data.Space.QubitsTagsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitsTags> Search(Space.Data.Space.QubitsTags Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsTagsDAL dal =  new Space.Data.Space.QubitsTagsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitsTags> FullSearch(Space.Data.Space.QubitsTags Query, Func<Space.Data.Space.QubitsTags,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsTagsDAL dal =  new Space.Data.Space.QubitsTagsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitsTags Query) {
            Space.Data.Space.QubitsTagsDAL dal =  new Space.Data.Space.QubitsTagsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitsTags Query) {
            Space.Data.Space.QubitsTagsDAL dal =  new Space.Data.Space.QubitsTagsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitsTags Query) {
            Space.Data.Space.QubitsTagsDAL dal =  new Space.Data.Space.QubitsTagsDAL();
            return dal.Delete(Query);
        }
    }
}
