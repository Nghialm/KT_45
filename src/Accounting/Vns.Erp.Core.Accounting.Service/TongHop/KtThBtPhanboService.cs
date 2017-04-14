using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtThBtPhanboService:GenericService<KtThBtPhanbo,System.Guid>, IKtThBtPhanboService
	{
	    public IKtThBtPhanboDao KtThBtPhanboDao
        {
            get { return (IKtThBtPhanboDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtThBtPhanbo> GetObjectAllByThangNam(decimal Thang, decimal Nam, System.Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("Thang");
            values.Add(Thang);
            props.Add("Nam");
            values.Add(Nam);
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        private KtThBtPhanbo ConvertDM2THButToanPhanBo(KtDmBtPhanbo objConvert)
        {
            KtThBtPhanbo temp = new KtThBtPhanbo();

            var _with1 = temp;
            _with1.Id = objConvert.Id;
            _with1.TenBtPhanbo = objConvert.TenBtPhanbo;
            _with1.Nhom = objConvert.Nhom;
            _with1.TkPhanboId = objConvert.TkPhanboId;
            _with1.MaTkPhanbo = objConvert.MaTkPhanbo;
            _with1.TenTkPhanbo = objConvert.TenTkPhanbo;
            _with1.TkDichId = objConvert.TkDichId;
            _with1.MaTkDich = objConvert.MaTkDich;
            _with1.TenTkDich = objConvert.TenTkDich;
            _with1.KhachHangPb = objConvert.KhachHangPb;
            _with1.VuviecPb = objConvert.VuviecPb;
            _with1.KhoanPhiPb = objConvert.KhoanPhiPb;
            _with1.CongTrinhPb = objConvert.CongTrinhPb;
            _with1.HopDongPb = objConvert.HopDongPb;
            _with1.PtqtPb = objConvert.PtqtPb;
            _with1.Tudo1Pb = objConvert.Tudo1Pb;
            _with1.Tudo2Pb = objConvert.Tudo2Pb;
            _with1.Tudo3Pb = objConvert.Tudo3Pb;
            _with1.Tudo4Pb = objConvert.Tudo4Pb;
            _with1.Tudo5Pb = objConvert.Tudo5Pb;
            _with1.KhachHangDich = objConvert.KhachHangDich;
            _with1.VuviecDich = objConvert.VuviecDich;
            _with1.KhoanPhiDich = objConvert.KhoanPhiDich;
            _with1.CongTrinhDich = objConvert.CongTrinhDich;
            _with1.HopDongDich = objConvert.HopDongDich;
            _with1.PtqtDich = objConvert.PtqtDich;
            _with1.Tudo1Dich = objConvert.Tudo1Dich;
            _with1.Tudo2Dich = objConvert.Tudo2Dich;
            _with1.Tudo3Dich = objConvert.Tudo3Dich;
            _with1.Tudo4Dich = objConvert.Tudo4Dich;
            _with1.Tudo5Dich = objConvert.Tudo5Dich;
            _with1.ThuTu = objConvert.ThuTu;
            _with1.Nam = objConvert.Nam;
            _with1.DonviId = objConvert.DonviId;
            _with1.MaDonvi = objConvert.MaDonvi;
            _with1.LoaiPhanbo = objConvert.LoaiPhanbo;

            return temp;
        }

        public List<KtThBtPhanbo> ConvertListDM2THButToanPhanBo(List<KtDmBtPhanbo> lstConvert)
        {
            List<KtThBtPhanbo> lst = new List<KtThBtPhanbo>();

            foreach (KtDmBtPhanbo temp in lstConvert)
            {
                lst.Add(ConvertDM2THButToanPhanBo(temp));
            }

            return lst;
        }

        public void DeleteByThangNam(decimal Thang, decimal Nam, System.Guid DonviId)
        {
            KtThBtPhanboDao.DeleteByThangNam(Thang, Nam, DonviId);
        }
	}
}