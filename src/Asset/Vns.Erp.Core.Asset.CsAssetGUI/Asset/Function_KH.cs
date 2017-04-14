using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public class Function_KH
    {

        #region Property
        private ICtTscdService _CtTscdService;
        public ICtTscdService CtTscdService
        {
            get { return _CtTscdService; }
            set { _CtTscdService = value; }
        }

        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }
        #endregion
        /// <summary>
        /// Lọc ra vệt cuối của chi tiết TSCD có ngày bắt đầu khấu hao nhỏ hơn ngày tính khấu hao
        /// </summary>
        /// <param name="NGAY_TINH"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public List<CtTscd> Vet_Cuoi_CT_TSCD(System.DateTime NGAY_TINH, List<DmTscd> lst_DM_TSCD)
        {
            //list CT_TSCD ứng với 1 TSCD_ID
            //Dim lst_temp_CT_TSCD As List(Of CtTscd) = New List(Of CtTscd)
            CtTscd obj_temp_CT_TSCD = new CtTscd();
            //List chứa vệt cuối của TSCD
            List<CtTscd> lst_vc_ct_tscd = new List<CtTscd>();

            if ((lst_DM_TSCD == null))
            {
                int TotalResult = 0;
                lst_DM_TSCD = new List<DmTscd>(_DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, out TotalResult));
            }

            //Lay tat ca vet cuoi cua TSCD theo thang truyen vao
            //Loc lay vet cuoi cua ct_tscd
            //Loai tru: 
            //Giam
            //Lấy ra thứ tự max tính đến ngày tính
            int Thu_Tu_Max = 0;
            //Ngay bat dau khau hao khi lam tron
            foreach (DmTscd obj_ct in lst_DM_TSCD)
            {
                obj_temp_CT_TSCD = _CtTscdService.GetObject_TOP1(obj_ct.Id, NGAY_TINH);
                DateTime NGAY_KH = default(DateTime);
                if ((obj_temp_CT_TSCD != null))
                {
                    NGAY_KH = Dt(obj_temp_CT_TSCD.NgayBdKh.Value);
                    //If (lst_temp_CT_TSCD(i).THU_TU = lst_temp_CT_TSCD.Count And NGAY_KH < NGAY_TINH And lst_temp_CT_TSCD(i).TANG_TSCD <> 4) Then
                    obj_temp_CT_TSCD.NgayBdKh = NGAY_KH;
                    lst_vc_ct_tscd.Add(obj_temp_CT_TSCD);
                }
                //End If
            }
            return lst_vc_ct_tscd;
        }

        private DateTime Dt(DateTime p_dt)
        {
            DateTime dt_ktkh = DateTime.Now;

            if (p_dt.Day < 15)
            {
                dt_ktkh = new DateTime(p_dt.Year, p_dt.Month, 1);
            }
            else
            {
                dt_ktkh = new DateTime(p_dt.Year, p_dt.Month, 1).AddMonths(1);
            }

            return dt_ktkh;
        }

        /// <summary>
        /// Tính khấu hao từng tháng một
        /// </summary>
        /// <param name="Thang">Truyền vào ngày tháng cần tính</param>
        /// <param name="CT_TSCD">Truyền vào CT_TSCD</param>
        /// <param name="PPT">True : tính HAO MÒN THÁNG theo Vệt cuối của CT_TSCD; Fasle: tính HAO MÒN THÁNG theo Vệt cuối của LS_KHAUHAO</param>
        /// <remarks></remarks>

        public TsLsKhauhao Khau_Hao_Tung_Thang(DateTime Thang, CtTscd CT_TSCD, bool PPT, List<TsLsKhauhao> lst_first_KH)
        {
            TsLsKhauhao obj_LS_TSCD = new TsLsKhauhao();
            string str = "";
            TsLsKhauhao obj_temp_LS_TSCD = new TsLsKhauhao();

            if (CT_TSCD.NgayKtKh!= null)
            {
                DateTime N_KTKH = Dt(CT_TSCD.NgayKtKh.Value);
                if ((N_KTKH <= Thang))
                {
                    obj_LS_TSCD.CtTscdId = CT_TSCD.Id;
                    obj_LS_TSCD.DmTscdId = CT_TSCD.TscdId;
                    obj_LS_TSCD.NguyenGia = 0;
                    obj_LS_TSCD.HaoMonThang = 0;
                    obj_LS_TSCD.HaoMonNam = 0;
                    obj_LS_TSCD.HaoMonLk = 0;
                    obj_LS_TSCD.Thang = Thang.Month;
                    obj_LS_TSCD.Nam = Thang.Year;
                    return obj_LS_TSCD;
                }
            }

            //Lấy ra giá trị cần thiết để tính khấu hao
            obj_temp_LS_TSCD = LS_KH_First(Thang, CT_TSCD, lst_first_KH);

            //'nếu hao mòn tháng =0 trả về giá trị trắng chứa ID_TSCD
            //gán các giá trị cần thiết cho object lịch sử hao mòn trả về
            obj_LS_TSCD.CtTscdId = CT_TSCD.Id;
            obj_LS_TSCD.DmTscdId = CT_TSCD.TscdId;
            obj_LS_TSCD.NguyenGia = CT_TSCD.NguyenGia;
            obj_LS_TSCD.MaDonvi = Generals.DON_VI.MaDonvi;
            obj_LS_TSCD.DonviId = Generals.DON_VI.Id;
            obj_LS_TSCD.Thang = Thang.Month;
            obj_LS_TSCD.Nam = Thang.Year;
            obj_LS_TSCD.NguoiTao = Generals.USER.Id;


            //'PPT=false :Hao mòn thang sẽ tính gối theo tháng trước nếu có thay đổi (không xóa dữ liệu cũ)
            //'PPT=true :Hao mòn tháng sẽ tính theo vệt cuối của CT_TSCD (Xóa dữ liệu cũ)
            if ((PPT == false))
            {
                obj_LS_TSCD.HaoMonThang = obj_temp_LS_TSCD.HaoMonThang;
            }
            else
            {
                if ((CT_TSCD.SoThangSd != 0))
                {
                    obj_LS_TSCD.HaoMonThang = Math.Round(CT_TSCD.GiaTriCl / CT_TSCD.SoThangSd, 0);
                }
                else
                {
                    obj_LS_TSCD.HaoMonThang = 0;
                }
            }

            if ((obj_temp_LS_TSCD.HaoMonThang == 0 | obj_temp_LS_TSCD.GiaTriCl == 0))
            {
                //obj_LS_TSCD.DM_TSCD_ID = obj_temp_LS_TSCD.DM_TSCD_ID
                return obj_LS_TSCD;
            }

            //Tính các giá trị còn lại(hao mòn năm, giá trị còn lại, hao mòn lũy kế, giá trị còn lại)
            obj_LS_TSCD.HaoMonNam = obj_temp_LS_TSCD.HaoMonNam;

            if ((obj_temp_LS_TSCD.GiaTriCl > obj_LS_TSCD.HaoMonThang))
            {
                obj_LS_TSCD.GiaTriCl = obj_temp_LS_TSCD.GiaTriCl - obj_LS_TSCD.HaoMonThang;
                obj_LS_TSCD.HaoMonLk = obj_temp_LS_TSCD.HaoMonLk + obj_LS_TSCD.HaoMonThang;
            }
            else
            {
                //If (Math.Round(obj_temp_LS_TSCD.GIA_TRI_CL, 0) <> 0) Then
                //    obj_LS_TSCD.GIA_TRI_CL = 0
                //    obj_LS_TSCD.HAO_MON_LK = obj_temp_LS_TSCD.HAO_MON_LK + obj_LS_TSCD.HAO_MON_THANG
                //Else
                //    Return Nothing
                //End If
                if ((obj_temp_LS_TSCD.GiaTriCl > 0))
                {
                    obj_LS_TSCD.HaoMonThang = obj_temp_LS_TSCD.GiaTriCl;
                    obj_LS_TSCD.HaoMonLk = obj_temp_LS_TSCD.HaoMonLk + obj_LS_TSCD.HaoMonThang;
                    obj_LS_TSCD.GiaTriCl = 0;
                }
                else
                {
                    obj_LS_TSCD.HaoMonThang = 0;
                    obj_LS_TSCD.HaoMonLk = 0;
                    obj_LS_TSCD.GiaTriCl = 0;
                }
            }

            return obj_LS_TSCD;
        }

        /// <summary>
        /// Lấy ra số liệu để tính khấu hao tháng truyền vào
        /// </summary>
        /// <param name="NGAY_KH"></param>
        /// <param name="obj_CT_TSCD_ID"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public TsLsKhauhao LS_KH_First(System.DateTime NGAY_KH, CtTscd obj_CT_TSCD_ID, List<TsLsKhauhao> lst_first_KH)
        {

            TsLsKhauhao obj_LS_KH_First = new TsLsKhauhao();
            //Lấy ra ngày của obj_all
            DateTime NGAY = default(DateTime);
            int year = 0;
            int month = 0;
            //Lấy ra lịch sử tài sản khấu hao ứng với một chi tiết TSCD
            List<TsLsKhauhao> lst_LS_CT_TSCD = new List<TsLsKhauhao>();
            foreach (TsLsKhauhao obj_all in lst_first_KH)
            {
                if ((obj_all.CtTscdId == obj_CT_TSCD_ID.Id))
                {
                    lst_LS_CT_TSCD.Add(obj_all);
                }
            }

            if ((NGAY_KH == obj_CT_TSCD_ID.NgayBdKh))
            {
                //Lấy dữ liệu cho của vệt cuối ct_TSCD
                if ((obj_CT_TSCD_ID.SoThangSd != 0))
                {
                    obj_LS_KH_First.HaoMonThang = Math.Round(obj_CT_TSCD_ID.GiaTriCl / obj_CT_TSCD_ID.SoThangSd, 0);
                    obj_LS_KH_First.HaoMonNam = Math.Round(obj_CT_TSCD_ID.GiaTriCl / (obj_CT_TSCD_ID.SoThangSd / 12), 0);
                    obj_LS_KH_First.HaoMonLk = obj_CT_TSCD_ID.HaoMonLuyKe;
                }
                else
                {
                    obj_LS_KH_First.HaoMonThang = 0;
                    obj_LS_KH_First.HaoMonNam = 0;
                }
                //Hao mòn năm =giá trị còn lại/tỷ lệ hao mòn
                obj_LS_KH_First.GiaTriCl = obj_CT_TSCD_ID.GiaTriCl;
            }
            else
            {
                foreach (TsLsKhauhao obj in lst_LS_CT_TSCD)
                {
                    year = (Int32)obj.Nam;
                    month = (Int32)obj.Thang;
                    NGAY = new DateTime(year, month, 1);
                    if ((NGAY == NGAY_KH.AddMonths(-1) & (obj.IdCha == Null.NullGuid)))
                    {
                        obj_LS_KH_First = obj;
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }

            return obj_LS_KH_First;

        }

    }

    public class Khau_hao_tung_thangInfo
    {

        #region "Private Variable"

        private Guid _TS_LS_KHAUHAO_ID;
        private Guid _DM_TSCD_ID;
        private string _MA_TSCD;
        private string _TEN_TSCD;
        private Guid _CT_TSCD_ID;
        private decimal _HAO_MON_LK;
        private decimal _HAO_MON_THANG;
        private decimal _HAO_MON_NAM;
        private decimal _NGUYEN_GIA;
        private decimal _GIA_TRI_CL;
        private decimal _THANG;
        private decimal _NAM;
        private DateTime _NgayKhauHao;
        private Guid _DONVI_ID;
        private string _MA_DONVI;
        private Guid _CTD_ID;
        private DateTime? _NGAY_TAO;
        private Guid _NGUOI_TAO;
        private DateTime? _NGAY_SUA;
        private Guid _NGUOI_SUA;
        private Guid _CTH_ID;
        private decimal _HE_SO;
        private decimal _BAO_CAO;
        private decimal _CHI_TIET;
        private Guid _ID_CHA;
        private decimal _IS_INSERT;
        private decimal _IS_UPDATE;
        private decimal _IS_DELETE;
        private Guid _NGUON_VON_ID;
        private DateTime _NGAY_KT_KH;
        #endregion
        private DateTime _NGAY_BD_KH;

        #region "Property"
        public DateTime NGAY_BD_KH
        {
            get { return _NGAY_BD_KH; }
            set { _NGAY_BD_KH = value; }
        }


        public DateTime NGAY_KTKH
        {
            get { return _NGAY_KT_KH; }
            set { _NGAY_KT_KH = value; }
        }


        public Guid NGUON_VON_ID
        {
            get { return _NGUON_VON_ID; }
            set { _NGUON_VON_ID = value; }
        }


        public decimal IS_DELETE
        {
            get { return _IS_DELETE; }
            set { _IS_DELETE = value; }
        }

        public decimal IS_UPDATE
        {
            get { return _IS_UPDATE; }
            set { _IS_UPDATE = value; }
        }

        public decimal IS_INSERT
        {
            get { return _IS_INSERT; }
            set { _IS_INSERT = value; }
        }

        public Guid ID_CHA
        {
            get { return _ID_CHA; }
            set { _ID_CHA = value; }
        }

        public decimal CHI_TIET
        {
            get { return _CHI_TIET; }
            set { _CHI_TIET = value; }
        }

        public decimal BAO_CAO
        {
            get { return _BAO_CAO; }
            set { _BAO_CAO = value; }
        }

        public decimal HE_SO
        {
            get { return _HE_SO; }
            set { _HE_SO = value; }
        }

        public Guid TS_LS_KHAUHAO_ID
        {
            get { return _TS_LS_KHAUHAO_ID; }
            set { _TS_LS_KHAUHAO_ID = value; }
        }

        public Guid DM_TSCD_ID
        {
            get { return _DM_TSCD_ID; }
            set { _DM_TSCD_ID = value; }
        }

        public Guid CT_TSCD_ID
        {
            get { return _CT_TSCD_ID; }
            set { _CT_TSCD_ID = value; }
        }

        public decimal HAO_MON_LK
        {
            get { return _HAO_MON_LK; }
            set { _HAO_MON_LK = value; }
        }

        public decimal HAO_MON_THANG
        {
            get { return _HAO_MON_THANG; }
            set { _HAO_MON_THANG = value; }
        }

        public decimal HAO_MON_NAM
        {
            get { return _HAO_MON_NAM; }
            set { _HAO_MON_NAM = value; }
        }

        public decimal NGUYEN_GIA
        {
            get { return _NGUYEN_GIA; }
            set { _NGUYEN_GIA = value; }
        }

        public decimal GIA_TRI_CL
        {
            get { return _GIA_TRI_CL; }
            set { _GIA_TRI_CL = value; }
        }

        public decimal THANG
        {
            get { return _THANG; }
            set { _THANG = value; }
        }

        public decimal NAM
        {
            get { return _NAM; }
            set { _NAM = value; }
        }

        public Guid DONVI_ID
        {
            get { return _DONVI_ID; }
            set { _DONVI_ID = value; }
        }

        public string MA_DONVI
        {
            get { return _MA_DONVI; }
            set { _MA_DONVI = value; }
        }

        public Guid CTD_ID
        {
            get { return _CTD_ID; }
            set { _CTD_ID = value; }
        }

        public DateTime? NGAY_TAO
        {
            get { return _NGAY_TAO; }
            set { _NGAY_TAO = value; }
        }

        public Guid NGUOI_TAO
        {
            get { return _NGUOI_TAO; }
            set { _NGUOI_TAO = value; }
        }

        public DateTime? NGAY_SUA
        {
            get { return _NGAY_SUA; }
            set { _NGAY_SUA = value; }
        }

        public Guid NGUOI_SUA
        {
            get { return _NGUOI_SUA; }
            set { _NGUOI_SUA = value; }
        }

        public Guid CTH_ID
        {
            get { return _CTH_ID; }
            set { _CTH_ID = value; }
        }

        public string TEN_TSCD
        {
            get { return _TEN_TSCD; }
            set { _TEN_TSCD = value; }
        }

        public string MA_TSCD
        {
            get { return _MA_TSCD; }
            set { _MA_TSCD = value; }
        }

        public System.DateTime NgayKhauHao
        {
            get
            {
                try
                {
                    System.DateTime tmpngay = new DateTime((Int32)_NAM, (Int32)_THANG, 1);
                    tmpngay = tmpngay.AddMonths(1).AddDays(-1);
                    return tmpngay;
                }
                catch (Exception ex)
                {
                    return System.DateTime.Today;
                }
            }
        }

        #endregion

        #region "Init Class"
        public Khau_hao_tung_thangInfo()
        {
        }

        public Khau_hao_tung_thangInfo(Guid TS_LS_KHAUHAO_ID, Guid DM_TSCD_ID, string MA_TSCD, string TEN_TSCD, Guid CT_TSCD_ID, decimal HAO_MON_LK, decimal HAO_MON_THANG, decimal HAO_MON_NAM, decimal NGUYEN_GIA, decimal GIA_TRI_CL,
        decimal THANG, decimal NAM, Guid DONVI_ID, string MA_DONVI, Guid CTD_ID, DateTime NGAY_TAO, Guid NGUOI_TAO, DateTime NGAY_SUA, Guid NGUOI_SUA, Guid CTH_ID,
        decimal HE_SO, decimal BAO_CAO, decimal CHI_TIET, Guid ID_CHA, Guid NGUON_VON_ID, DateTime NGAY_KTKH)
        {
            this.TS_LS_KHAUHAO_ID = TS_LS_KHAUHAO_ID;
            this.DM_TSCD_ID = DM_TSCD_ID;
            this.MA_TSCD = MA_TSCD;
            this.TEN_TSCD = TEN_TSCD;
            this.CT_TSCD_ID = CT_TSCD_ID;
            this.HAO_MON_LK = HAO_MON_LK;
            this.HAO_MON_THANG = HAO_MON_THANG;
            this.HAO_MON_NAM = HAO_MON_NAM;
            this.NGUYEN_GIA = NGUYEN_GIA;
            this.GIA_TRI_CL = GIA_TRI_CL;
            this.THANG = THANG;
            this.NAM = NAM;
            this.DONVI_ID = DONVI_ID;
            this.MA_DONVI = MA_DONVI;
            this.CTD_ID = CTD_ID;
            this.NGAY_TAO = NGAY_TAO;
            this.NGUOI_TAO = NGUOI_TAO;
            this.NGAY_SUA = NGAY_SUA;
            this.NGUOI_SUA = NGUOI_SUA;
            this.CTH_ID = CTH_ID;
            this.HE_SO = HE_SO;
            this.BAO_CAO = BAO_CAO;
            this.CHI_TIET = CHI_TIET;
            this.ID_CHA = ID_CHA;
            this.IS_INSERT = 0;
            this.NGUON_VON_ID = NGUON_VON_ID;
            this.NGAY_KTKH = NGAY_KTKH;
        }

        public Khau_hao_tung_thangInfo(TsLsKhauhao obj_KhauHao, CtTscd obj_ct)
        {
            this.TS_LS_KHAUHAO_ID = obj_KhauHao.Id;
            this.ID_CHA = obj_KhauHao.IdCha;
            this.DM_TSCD_ID = obj_ct.TscdId;
            this.MA_TSCD = obj_ct.MaTscd;
            this.TEN_TSCD = obj_ct.TenTscd;
            this.CT_TSCD_ID = obj_KhauHao.CtTscdId;
            this.HAO_MON_LK = obj_KhauHao.HaoMonLk;
            this.HAO_MON_THANG = obj_KhauHao.HaoMonThang;
            this.HAO_MON_NAM = obj_KhauHao.HaoMonNam;
            this.NGUYEN_GIA = obj_KhauHao.NguyenGia;
            this.GIA_TRI_CL = obj_KhauHao.GiaTriCl;
            this.THANG = obj_KhauHao.Thang;
            this.NAM = obj_KhauHao.Nam;
            this.DONVI_ID = obj_KhauHao.DonviId;
            this.MA_DONVI = obj_KhauHao.MaDonvi;
            this.CTD_ID = obj_KhauHao.CtdId;
            this.NGAY_TAO = (obj_KhauHao.NgayTao == null ? System.DateTime.Today : obj_KhauHao.NgayTao);
            this.NGUOI_TAO = obj_KhauHao.NguoiTao;
            this.NGAY_SUA = (obj_KhauHao.NgaySua == null ? System.DateTime.Today : obj_KhauHao.NgaySua);
            this.NGUOI_SUA = obj_KhauHao.NguoiSua;
            this.CTH_ID = obj_KhauHao.CthId;
            this.CHI_TIET = obj_KhauHao.ChiTiet;
            this.BAO_CAO = obj_KhauHao.BaoCao;
            this.NGUON_VON_ID = obj_KhauHao.NguonVonId;
        }

        public Khau_hao_tung_thangInfo(TsLsKhauhao obj_KhauHao, DmTscd obj_DM_Tscd)
        {
            this.TS_LS_KHAUHAO_ID = obj_KhauHao.Id;
            this.ID_CHA = obj_KhauHao.IdCha;
            this.DM_TSCD_ID = obj_DM_Tscd.Id;
            this.MA_TSCD = obj_DM_Tscd.MaTscd;
            this.TEN_TSCD = obj_DM_Tscd.TenTscd;
            this.CT_TSCD_ID = obj_KhauHao.CtTscdId;
            this.HAO_MON_LK = obj_KhauHao.HaoMonLk;
            this.HAO_MON_THANG = obj_KhauHao.HaoMonThang;
            this.HAO_MON_NAM = obj_KhauHao.HaoMonNam;
            this.NGUYEN_GIA = obj_KhauHao.NguyenGia;
            this.GIA_TRI_CL = obj_KhauHao.GiaTriCl;
            this.THANG = obj_KhauHao.Thang;
            this.NAM = obj_KhauHao.Nam;
            this.DONVI_ID = obj_KhauHao.DonviId;
            this.MA_DONVI = obj_KhauHao.MaDonvi;
            this.CTD_ID = obj_KhauHao.CtdId;
            this.NGAY_TAO = (obj_KhauHao.NgayTao == null ? System.DateTime.Today : obj_KhauHao.NgayTao);
            this.NGUOI_TAO = obj_KhauHao.NguoiTao;
            this.NGAY_SUA = (obj_KhauHao.NgaySua == null ? System.DateTime.Today : obj_KhauHao.NgaySua);
            this.NGUOI_SUA = obj_KhauHao.NguoiSua;
            this.CTH_ID = obj_KhauHao.CthId;
            this.CHI_TIET = obj_KhauHao.ChiTiet;
            this.BAO_CAO = obj_KhauHao.BaoCao;
            this.NGUON_VON_ID = obj_KhauHao.NguonVonId;
        }

        #endregion

        #region "Custom function"
        public TsLsKhauhao GenTsLsKhauhao()
        {
            TsLsKhauhao obj_LS_HM = new TsLsKhauhao();
            obj_LS_HM.Id = VnsConvert.CGuid(_TS_LS_KHAUHAO_ID);
            obj_LS_HM.DmTscdId = VnsConvert.CGuid(_DM_TSCD_ID);
            obj_LS_HM.CtTscdId = VnsConvert.CGuid(_CT_TSCD_ID);
            obj_LS_HM.HaoMonLk = _HAO_MON_LK;
            obj_LS_HM.HaoMonNam = _HAO_MON_NAM;
            obj_LS_HM.HaoMonThang = _HAO_MON_THANG;
            obj_LS_HM.NguyenGia = _NGUYEN_GIA;
            obj_LS_HM.GiaTriCl = _GIA_TRI_CL;
            obj_LS_HM.Thang = _THANG;
            obj_LS_HM.Nam = _NAM;
            obj_LS_HM.DonviId = VnsConvert.CGuid(_DONVI_ID);
            obj_LS_HM.MaDonvi = _MA_DONVI;
            obj_LS_HM.NgaySua = _NGAY_SUA;
            obj_LS_HM.NguoiSua = _NGUOI_SUA;
            obj_LS_HM.NguoiTao = _NGUOI_TAO;
            obj_LS_HM.NgayTao = _NGAY_TAO;
            obj_LS_HM.CtdId = VnsConvert.CGuid(_CTD_ID);
            obj_LS_HM.HeSo = _HE_SO;
            obj_LS_HM.IdCha = VnsConvert.CGuid(_ID_CHA);
            obj_LS_HM.BaoCao = _BAO_CAO;
            obj_LS_HM.ChiTiet = _CHI_TIET;
            obj_LS_HM.NgayKhauHao = NgayKhauHao;
            //obj_LS_HM.IS_INSERT = _IS_INSERT
            if (obj_LS_HM.ChiTiet == 1)
            {
                obj_LS_HM.CthId = VnsConvert.CGuid(_CTH_ID);
            }
            obj_LS_HM.NguonVonId = VnsConvert.CGuid(_NGUON_VON_ID);

            return obj_LS_HM;
        }
        #endregion
    }
}