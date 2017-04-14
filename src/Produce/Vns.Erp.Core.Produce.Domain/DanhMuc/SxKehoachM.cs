using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxKehoachM : DomainObject<System.Guid>
    {
        IList<SxKehoachD> _LstKeHoachDetail;
        [DataMember]
        public virtual IList<SxKehoachD> LstKeHoachDetail
        {
            get { return _LstKeHoachDetail; }
            set { _LstKeHoachDetail = value; }
        }

        IList<SxPhancong> _LstKhThucHien;
        [DataMember]
        public virtual IList<SxPhancong> LstKhThucHien
        {
            get { return _LstKhThucHien; }
            set { _LstKhThucHien = value; }
        }

        
	}
}