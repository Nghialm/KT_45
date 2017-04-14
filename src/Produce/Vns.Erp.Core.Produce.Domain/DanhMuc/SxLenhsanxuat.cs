using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxLenhsanxuat : DomainObject<System.Guid>
    {
        IList<SxLenhsanxuatD> _LstLenhSanXuatDetail;
        [DataMember]
        public virtual IList<SxLenhsanxuatD> LstLenhSanXuatDetail
        {
            get { return _LstLenhSanXuatDetail; }
            set { _LstLenhSanXuatDetail = value; }
        }

        [DataMember]
        public virtual IList<BcKetoanKho> LstVatTuNhap
        { get; set; }

        [DataMember]
        public virtual IList<BcKetoanKho> LstVatTuXuat
        { get; set; }

        [DataMember]
        public virtual SxKehoachM ObjKeHoachSx
        { get; set; }

        [DataMember]
        public SxDmQuytrinh ObjDmQuyTrinh
        { get; set; }
	}
}