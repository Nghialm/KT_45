using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;
using Vns.Erp.Core.Produce.Domain.Report;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class BangGiaD : DomainObject<System.Guid>
    {
        public BangGiaD(DonGiaDTO dongia)
        {
            _HanghoaId = dongia.HanghoaId;
            _Cang = dongia.Cang;
            _KhoId = dongia.KhoId;
            _SoLuongTon = dongia.SoLuongTon;
            _MaNghiepVu = dongia.MaNghiepVu;
            _MaVanChuyen = dongia.MaVuviec;
        }

        #region Gia tri khong luu, hien thi tren bao cao
        public Guid TypeId { get; set; }
        public Guid ApplicationId { get; set; }
        public String KhuVuc { get; set; }
        #endregion

    }
}