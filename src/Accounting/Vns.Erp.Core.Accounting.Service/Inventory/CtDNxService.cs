using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Vns.Erp.Core.Accounting.Report.Dao;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CtDNxService : GenericService<CtDNx, System.Guid>, ICtDNxService
    {
        public ICtDNxDao CtDNxDao
        {
            get { return (ICtDNxDao)Dao; }
            set { Dao = value; }
        }

        private IRpLedgerStoreDao _RpLedgerStoreDao;
        public IRpLedgerStoreDao RpLedgerStoreDao
        {
            get { return _RpLedgerStoreDao; }
            set { _RpLedgerStoreDao = value; }
        }

        public IList<CtDNx> GetObjectByCTHId(System.Guid CthNxId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("ObjCtHNx.Id");
            values.Add(CthNxId);

            return List(-1, -1, props, values, null);
        }

        private DmKho GetKhoInfo(Guid khoid, List<DmKho> lst)
        {
            foreach (DmKho tmp in lst)
            {
                if ((tmp.Id == khoid))
                {
                    return tmp;
                }
            }
            return null;
        }

        public Decimal TinhSLTonKho(Guid cthnx_id, DateTime ngayct, Guid hanghoaid, Guid KhoId, Guid DonviId)
        {
            return fn_so_luong_ton_kho_4_update(string.Empty, string.Empty, KhoId, hanghoaid, DonviId, ngayct, cthnx_id); 
        }

        private Decimal fn_so_luong_ton_kho_4_update(String MaTk, String MaTkDu, Guid KhoId, Guid HanghoaId, Guid DonviId,
            DateTime NgayTinh,
            //Guid IdDmHopDong, Guid IdDmHopDongDu,
            //Guid IdDmPtqt, Guid IdDmPtqtDu,
            //Guid IdDmPhongban, Guid IdDmPhongbanDu,
            //Guid IdDmVuviec, Guid IdDmVuviecDu,
            //Guid IdDmKhang, Guid IdDmKhangDu,
            //Guid IdDmKhoanphi, Guid IdDmKhoanphiDu,
            //Guid IdDmTudo1, Guid IdDmTudo1Du,
            //Guid IdDmTudo2, Guid IdDmTudo2Du,
            //Guid IdDmTudo3, Guid IdDmTudo3Du,
            //Guid IdDmTudo4, Guid IdDmTudo4Du,
            //Guid IdDmTudo5, Guid IdDmTudo5Du,
            Guid CthNxId)
        {
            return _RpLedgerStoreDao.fn_so_luong_ton_kho_4_update(MaTk, MaTkDu, KhoId, HanghoaId, DonviId, NgayTinh,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                Null.NullGuid, Null.NullGuid,
                CthNxId);
        }

        public Boolean KiemTraLuongTonKho(Guid cthnx_id, System.DateTime ngayct, ref List<CtDNx> lstNX, List<DmKho> lstKho, Guid DonviId)
        {
            Guid khoid = new Guid();
            Guid hanghoaid = new Guid();
            decimal soluongxuat = 0;
            decimal soluongton = 0;
            decimal thutu = 13;
            bool kiemtra = true;

            List<CtDNx> _lsttemp = new List<CtDNx>();

            foreach (CtDNx tmp in lstNX)
            {
                _lsttemp.Add(tmp.Clone());
            }

            while (!(_lsttemp.Count == 0))
            {
                soluongxuat = 0;
                khoid = _lsttemp[0].KhoXuatId;
                hanghoaid = _lsttemp[0].HanghoaId;

                for (int index = _lsttemp.Count - 1; index >= 0; index += -1)
                {
                    if (((khoid == _lsttemp[index].KhoXuatId) & (hanghoaid == _lsttemp[index].HanghoaId)))
                    {
                        soluongxuat = soluongxuat + _lsttemp[index].SoLuong;
                        _lsttemp.RemoveAt(index);
                    }
                }
                DmKho kho = GetKhoInfo(khoid, lstKho);
                soluongton = fn_so_luong_ton_kho_4_update(string.Empty, string.Empty, kho.Id, hanghoaid, DonviId, ngayct, cthnx_id);
                //soluongton = TinhSLTonKho(cthnx_id, ngayct, hanghoaid, kho.Id, DonviId);
                if ((soluongton < soluongxuat) & !(kho.XuatAm == 1))
                {
                    thutu = 13;
                    kiemtra = false;
                }
                else
                {
                    thutu = 0;
                }

                for (int index = lstNX.Count - 1; index >= 0; index += -1)
                {
                    if (((khoid == lstNX[index].KhoXuatId) & (hanghoaid == lstNX[index].HanghoaId)))
                    {
                        lstNX[index].TonKho = soluongton;
                        lstNX[index].ThuTu = thutu;
                    }
                }
            }

            return kiemtra;
        }

    }
}
