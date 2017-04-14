using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxPhieuKiemkeVtD : DomainObject<System.Guid>
    {
        private SxLenhsanxuat _ObjLenhSanXuat;
        public SxLenhsanxuat ObjLenhSanXuat
        {
            get { return _ObjLenhSanXuat; }
            set { _ObjLenhSanXuat = value; }
        }

        private DmHanghoa _ObjVatLieu;
        public DmHanghoa ObjVatLieu
        {
            get { return _ObjVatLieu; }
            set { _ObjVatLieu = value; }
        } 
	}
}