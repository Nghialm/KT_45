using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxPhieuKiemkeSlD : DomainObject<System.Guid>
    {
        private SxLenhsanxuat _ObjLenhSanXuat;
        public SxLenhsanxuat ObjLenhSanXuat
        {
            get { return _ObjLenhSanXuat; }
            set { _ObjLenhSanXuat = value; }
        }

        private DmHanghoa _ObjSanPham;
        public DmHanghoa ObjSanPham
        {
            get { return _ObjSanPham; }
            set { _ObjSanPham = value; }
        } 
	}
}