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
    
    
    public partial class QubitsDomainObject {
        
        public virtual IEnumerable<Space.Data.Space.Qubits> Search(Space.Data.Space.Qubits Query) {
            Space.Data.Space.QubitsDAL dal =  new Space.Data.Space.QubitsDAL();
            return dal.SelectObjects(Query);
        }
        
        public virtual IEnumerable<Space.Data.Space.Qubits> Search(Space.Data.Space.Qubits Query, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsDAL dal =  new Space.Data.Space.QubitsDAL();
            return dal.SelectObjects(Query).Skip(Skip).Take(Take);
        }
        
        public virtual IEnumerable<Space.Data.Space.Qubits> FullSearch(Space.Data.Space.Qubits Query, Func<Space.Data.Space.Qubits,Object> Orderby, Int32 Skip, Int32 Take) {
            Space.Data.Space.QubitsDAL dal =  new Space.Data.Space.QubitsDAL();
            return dal.SelectObjects(Query).OrderBy(Orderby).Skip(Skip).Take(Take);
        }
        
        public virtual int Update(Space.Data.Space.Qubits Query) {
            Space.Data.Space.QubitsDAL dal =  new Space.Data.Space.QubitsDAL();
            return dal.Update(Query);
        }
        
        public virtual int Insert(Space.Data.Space.Qubits Query) {
            Space.Data.Space.QubitsDAL dal =  new Space.Data.Space.QubitsDAL();
            Int32 rCode = new Int32();
            rCode = dal.Insert(Query);
            return rCode;
        }
        
        public virtual int Delete(Space.Data.Space.Qubits Query) {
            Space.Data.Space.QubitsDAL dal =  new Space.Data.Space.QubitsDAL();
            return dal.Delete(Query);
        }
    }
}
