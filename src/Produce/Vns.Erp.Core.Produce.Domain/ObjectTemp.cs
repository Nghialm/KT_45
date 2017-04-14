using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vns.Erp.Core.Produce.Domain
{
    public partial class KeHoachDetail
    {
        public virtual String LoaiKeHoach { get; set; }
        public virtual String MaVatLieu { get; set; }
        public virtual String TenVatLieu { get; set; }
        public virtual String LoaiVatLieu { get; set; }
        public virtual decimal SoLuong { get; set; }
        public virtual String TenDvt { get; set; }
        public virtual decimal DanhGia { get; set; }
        public virtual String MoTa { get; set; }        
    }    
}
