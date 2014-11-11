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
    
    
    public partial class QubitsTypesDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.QubitsTypes> Search(Space.Data.Space.QubitsTypes Query) {
            Space.Data.Space.QubitsTypesDAL dal =  new Space.Data.Space.QubitsTypesDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitsTypes> Search(Space.Data.Space.QubitsTypes Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsTypesDAL dal =  new Space.Data.Space.QubitsTypesDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.QubitsTypes> FullSearch(Space.Data.Space.QubitsTypes Query, Func<Space.Data.Space.QubitsTypes,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsTypesDAL dal =  new Space.Data.Space.QubitsTypesDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.QubitsTypes Query) {
            Space.Data.Space.QubitsTypesDAL dal =  new Space.Data.Space.QubitsTypesDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.QubitsTypes Query) {
            Space.Data.Space.QubitsTypesDAL dal =  new Space.Data.Space.QubitsTypesDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.QubitsTypes Query) {
            Space.Data.Space.QubitsTypesDAL dal =  new Space.Data.Space.QubitsTypesDAL();
            return dal.Delete(Query);
        }
    }
}
