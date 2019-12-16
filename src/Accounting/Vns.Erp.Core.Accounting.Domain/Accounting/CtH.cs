using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Accounting.Domain
{
    public partial class CtH : DomainObject<System.Guid>
    {
        #region Extends Property
        private IList<CtD> _LstCtD;
        [DataMember]
        public IList<CtD> LstCtD
        {
            get { return _LstCtD; }
            set { _LstCtD = value; }
        }
        #endregion
    }
}