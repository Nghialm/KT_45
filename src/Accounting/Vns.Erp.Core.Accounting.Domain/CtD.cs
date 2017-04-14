using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Accounting.Domain
{
	public partial class CtD : DomainObject<System.Guid>
    {
        


        #region Extend Property
        private CtH _ObjCtH;
        [DataMember]
        public virtual CtH ObjCtH
        {
            get { return _ObjCtH; }
            set { _ObjCtH = value; }
        }
        #endregion

    }
}