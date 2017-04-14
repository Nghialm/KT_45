using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxPhieuKiemke : DomainObject<System.Guid>
    {
        IList<SxPhieuKiemkeSlD> _LstSxPhieuKiemkeSlD;
        [DataMember]
        public virtual IList<SxPhieuKiemkeSlD> LstSxPhieuKiemkeSlD
        {
            get { return _LstSxPhieuKiemkeSlD; }
            set { _LstSxPhieuKiemkeSlD = value; }
        }

        IList<SxPhieuKiemkeVtD> _LstSxPhieuKiemkeVtD;
        [DataMember]
        public virtual IList<SxPhieuKiemkeVtD> LstSxPhieuKiemkeVtD
        {
            get { return _LstSxPhieuKiemkeVtD; }
            set { _LstSxPhieuKiemkeVtD = value; }
        }
	}
}