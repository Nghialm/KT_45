using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Vns.Erp.Core.Accounting.Domain.Extend;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Admin.Service.Interface;
using DevExpress.Utils;

using Vns.Erp.Core;
using Vns.Erp.Core.Controls.Commons;
using Vns.Erp.Core.Produce.Domain;
using Vns.Erp.Core.Produce.Service.Interface;
using Vns.Erp.Core.Admin.Service;

using Vns.Erp.Core.Controls;
using Vns.Erp.Core.Controls;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{

public partial class PhieuDieuXuatDieuChuyen
{

	#region "Property"
	private IHtLoaichungtuService _HtLoaichungtuService;
	public IHtLoaichungtuService HtLoaichungtuService {
		get { return _HtLoaichungtuService; }
		set { _HtLoaichungtuService = value; }
	}
	private ICtHNxService _CtHNxService;
	public ICtHNxService CtHNxService {
		get { return _CtHNxService; }
		set { _CtHNxService = value; }
	}

	private ICtDNxService _CtDNxService;
	public ICtDNxService CtDNxService {
		get { return _CtDNxService; }
		set { _CtDNxService = value; }
	}

	private IDmKhoService _DmKhoService;
	public IDmKhoService DmKhoService {
		get { return _DmKhoService; }
		set { _DmKhoService = value; }
	}

	private IDmTaikhoanService _DmTaikhoanService;
	public IDmTaikhoanService DmTaikhoanService {

		get { return _DmTaikhoanService; }
		set { _DmTaikhoanService = value; }
	}

	private IDmVuviecService _DmVuviecService;
	public IDmVuviecService DmVuviecService {

		get { return _DmVuviecService; }
		set { _DmVuviecService = value; }
	}

	private IDmNgoaiteService _DmNgoaiteService;
	public IDmNgoaiteService DmNgoaiteService {
		get { return _DmNgoaiteService; }
		set { _DmNgoaiteService = value; }
	}

	private ILsTygiaService _LsTygiaService;
	public ILsTygiaService LsTygiaService {
		get { return _LsTygiaService; }
		set { _LsTygiaService = value; }
	}

	private IDmHanghoaService _DmHanghoaService;
	public IDmHanghoaService DmHanghoaService {
		get { return _DmHanghoaService; }
		set { _DmHanghoaService = value; }
	}

	private IKtKhoasoThangService _KtKhoasoThangService;
	public IKtKhoasoThangService KtKhoasoThangService {
		get { return _KtKhoasoThangService; }
		set { _KtKhoasoThangService = value; }
	}

    private ISxLenhsanxuatService _SxLenhsanxuatService;
    public ISxLenhsanxuatService SxLenhsanxuatService
    {
        get { return _SxLenhsanxuatService; }
        set { _SxLenhsanxuatService = value; }
    }

    private IDmPhongbanService _DmPhongbanService;
    public IDmPhongbanService DmPhongbanService
    {
        get { return _DmPhongbanService; }
        set { _DmPhongbanService = value; }
    }
	#endregion

	#region "Variables and Messages"

	//Private originEntity As DBLogParamInfo = New DBLogParamInfo()

	Guid CTHNXID;
	Guid mCTHNXID;
	string m_Ma_Loai_CT;

	public HtLoaichungtu obj_loaichungtu = new HtLoaichungtu();
	/// <summary>
	///  khai bao 1 obj de Set,Get data tren form cua bang CT_H_NX va insert,update
	/// </summary>
	/// <remarks></remarks>

	private CtHNx obj_ct_h_nx = new CtHNx();
	/// <summary>
	/// khai bao 1 list obj de chua cac obj la cac record trong bang CT_D_NX dung de su ly insert,update
	/// </summary>
	/// <remarks></remarks>

	private List<CtDNx> lstobj_ct_d_nx = new List<CtDNx>();
	/// <summary>
	/// khai bao 1 list obj chua cac record delete cua bang CT_D_NX
	/// </summary>
	/// <remarks></remarks>

	private List<CtDNx> del_lstobj_ct_d_nx = new List<CtDNx>();
	/// <summary>
	/// khai bao bien kieu truyen vao cua trang thai tu ben list
	/// </summary>
	/// <remarks></remarks>

	private FormGlobals.DataInputState m_InputState;
	/// <summary>
	/// khai bao 1 list obj chua list obj da dc conver
	/// </summary>
	/// <remarks></remarks>

	private List<CT_H_GInfo> lstobj_ct_h_gg = new List<CT_H_GInfo>();
	private DataTable Kry_DATASOURE;
	private DataTable Ji_DATASOURE;
	private bool closeForm = false;
	private Boolean OnLoadData = false;
	string msgKhoaSo = "Đã khóa sổ nên bạn không thể Thêm/Sửa/Xóa!";

	string msgTTChungTu = "Bạn chưa được Phân quyền cập nhật trạng thái Chứng từ!";
	#endregion

	#region "Load form"

	/// <summary>
	/// ham xet icon cho cac button
	/// </summary>
	/// <remarks></remarks>
	public PhieuDieuXuatDieuChuyen()
	{
		FormClosed += PhieuDieuXuatDieuChuyen_FormClosed;
		
		InitializeComponent();
		TNCommon.setIconControl(this);
		urcGhi.Visible = Generals.Ts_PheDuyetChungTu;
		urcGhi.Enabled = Generals.Ts_PheDuyetChungTu;

        InitEvent();
		//Validate control
        FormHelper.RequireInputControls = new Control[] {
            dteNGAY_CT,
            dteNGAY_GHI,
            cboKhoNhap,
            cboKhoXuat
        };
        FormHelper.ApplyRequireInputValidate(FormHelper.RequireInputControls);
	}


	/// <summary>
	/// xu ly load form
	/// </summary>
	/// <param name="ID_CT"></param>
	/// <param name="eState"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public bool Show_Form(Guid ID_CT, string Ma_Loai_CT, string Ten_Loai_CT, List<CT_H_GInfo> lstCTH_G, Vns.Erp.Core.FormGlobals.DataInputState eState)
	{
		try {
			//hien thi header cua form
			FormGlobals.Form_SetText(this, "Phiếu điều chuyển", eState);
			FormGlobals.Form_InitDialog(this);

			//gan cho bien trang thai cua form
			m_InputState = eState;

			//lay ID duoc truyen vao
			mCTHNXID = ID_CT;
			m_Ma_Loai_CT = Ma_Loai_CT;

			obj_loaichungtu = HtLoaichungtuService.GetByMA_LOAI_CT(Ma_Loai_CT, Generals.DON_VI.Id);
			urcGhi.LCT_STATUS = obj_loaichungtu.Id;

			if (lstCTH_G != null) {
				lstobj_ct_h_gg = lstCTH_G;
			}

			//xet cac gia tri not null
			//Control_SetRequire(grlMA_KHANG, True)
			//Control_SetRequire(dteNGAY_GHI, True)

			//goi ham xu ly
			frmProgress.Instance().Thread = InitForm;
			frmProgress.Instance().Show_Progress();
			grvLPX_Hnx.FocusedRowChanged += grvLPX_Hnx_FocusedRowChanged;

			if (closeForm == true) {
			    FormGlobals.Message_Warning(ConstantMsgs.MSG_ALERT_FOR_RECENT_DELETE);
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				return true;
			} else {
				return (this.ShowDialog() == System.Windows.Forms.DialogResult.OK);
			}
		} catch (Exception ex) {
		   FormGlobals.Message_Error(ex);
           return false;
		}
	}

	#endregion

	#region "Private Function and Procedures"
    private void InitEvent()
    {
        btnAdd.Click +=new EventHandler(btnAdd_Click);
        btnMod.Click += new EventHandler(btnMod_Click);
        btnDel.Click += new EventHandler(btnDelete_Click);
        btnSav.Click += new EventHandler(btnLuu_Click);
        btnSea.Click +=new EventHandler(btnSea_Click);
        btnCan.Click +=new EventHandler(btnCan_Click);
        btnPri.Click +=new EventHandler(btnPri_Click);
        btnQuit.Click += new EventHandler(btnClo_Click);

        grvLPX_Hnx.FocusedRowChanged +=new FocusedRowChangedEventHandler(grvLPX_Hnx_FocusedRowChanged);
        grvPhieuDieuChuyen.KeyDown +=new KeyEventHandler(grvPhieuDieuChuyen_KeyDown);
        grvPhieuDieuChuyen.CellValueChanged += new CellValueChangedEventHandler(grvPhieuDieuChuyen_CellValueChanged);
        this.KeyDown += new KeyEventHandler(frmPhieuDieuXuatDieuChuyen_KeyDown);
        txtTY_GIA.EditValueChanged +=new EventHandler(txtTY_GIA_EditValueChanged);
        dteNGAY_CT.EditValueChanged += new EventHandler(dteNGAY_CT_EditValueChanged);
        this.FormClosed +=new FormClosedEventHandler(PhieuDieuXuatDieuChuyen_FormClosed);
        GFilterEdit_HANGHOA_ID.AfterFilter += new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(GFilter_HANGHOA_ID_AfterFilter);
        Gfilter_TKN_GIAVON.AfterFilter += new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(GFilter_HANGHOA_ID_AfterFilter);
        Gfilter_TKC_GIAVON.AfterFilter += new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(GFilter_HANGHOA_ID_AfterFilter);

        CheckEdit1.KeyDown +=new KeyEventHandler(CheckEdit1_KeyDown);
        cboTyGia.EditValueChanged += new EventHandler(cboTyGia_EditValueChanged);

        GFilterEdit_HANGHOA_ID.FisrtBinddata += new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(GFilterEdit_HANGHOA_ID_FisrtBinddata);
        GFilterEdit_HANGHOA_ID.ClearDataFilter += new RepositoryItemPopupFilterEdit.FilterCustomEventHandler(GFilterEdit_HANGHOA_ID_ClearDataFilter);
    }

	/// <summary>
	/// khoi xu ly form
	/// </summary>
	/// <remarks></remarks>
	private void InitForm()
	{
		try {
			//
			InitControl();
			// 
			InitData();

			grvLPX_Hnx.Columns["Ghi"].Visible = Generals.Ts_PheDuyetChungTu;
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// khoi xu ly control 
	/// </summary>
	/// <remarks></remarks>
	private void InitControl()
	{
		//
		BindLoookUpNX();

	}

	/// <summary>
	/// khoi xu ly data tren form
	/// </summary>
	/// <remarks></remarks>
	private void InitData()
	{
		try {
			OnLoadData = true;
			switch (m_InputState) {
                case FormGlobals.DataInputState.AddMode:
					// dat gia tri mac dinh khi them moi
                    m_InputState = FormGlobals.DataInputState.AddMode;
					//grcPhieuDieuChuyen.DataSource = lstobj_ct_d_nx
					DatTrangThaiControl();
					//txtCT_SO.Text = Nothing
					//txtCT_SO.Properties.ReadOnly = True
					ClearPage();
					ConfigGrid.GridConfig(this.Name + "?" + "MaLoaiCt=" + m_Ma_Loai_CT, grvPhieuDieuChuyen.Name, grvPhieuDieuChuyen);
					SetControlKho();

					break;
                case FormGlobals.DataInputState.EditMode:
					DatTrangThaiControl();
					//goi ham load data len form theo trang thai edit
					SetObjectToControl();
					break;
				//Load_Grid()
			}

			grlLoaiPhieuNhap.EditValueChanged += grlLoaiPhieuNhap_EditValueChanged;

			Load_Grid(lstobj_ct_h_gg);
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
		OnLoadData = false;
	}

	/// <summary>
	/// bind du lieu vao cac comobox
	/// </summary>
	/// <remarks></remarks>
	private void BindLoookUpNX()
	{
		Ji_DATASOURE = Vns.Erp.Core.DataHelper.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
		Gfilter_TKC_GIAVON.C_DATA_SOURCE = Ji_DATASOURE;
		Gfilter_TKN_GIAVON.C_DATA_SOURCE = Ji_DATASOURE;

		//GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE
		//GFilter.C_DATA_SOURCE = DM_KhangBO.Instance().GetAllBy_CO_SU_DUNG_DS(Generals.DON_VI.DONVI_ID.Replace("-", "")).Tables(0)
		// Bind loại chứng từ
        List<HtLoaichungtu> listLCTu = new List<HtLoaichungtu>(HtLoaichungtuService.LikeObjetMA_LOAI_CT(m_Ma_Loai_CT, Generals.DonviID));
		grlLoaiPhieuNhap.Properties.DataSource = listLCTu;
		grlLoaiPhieuNhap.Properties.DisplayMember = "KyHieu";
		grlLoaiPhieuNhap.Properties.ValueMember = "MaLoaiCt";
		TNCommon.SelectFirst(grlLoaiPhieuNhap);

		//Bind ngoai te
        List<DmNgoaite> lstNgoaite = new List<DmNgoaite>(_DmNgoaiteService.GetAll());
		cboTyGia.Properties.DisplayMember = "KyHieu";
		cboTyGia.Properties.ValueMember = "Id";
		cboTyGia.Properties.DataSource = lstNgoaite;
		cboTyGia.EditValue = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri);
		txtTY_GIA.Text = "1";

		//Bind TK No
        List<DmTaikhoan> lstTKNo = new List<DmTaikhoan>(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
		cboTKno.DataSource = lstTKNo;
		cboTKno.DisplayMember = "MaTaiKhoan";
		cboTKno.ValueMember = "Id";
		cboTKno.Columns.Add(new LookUpColumnInfo("MaTaiKhoan", "Mã tài khoản"));
		cboTKno.Columns.Add(new LookUpColumnInfo("TenTaiKhoan", "Tên tài khoản"));

		//Bind TK Có
        List<DmTaikhoan> lstTKCo = new List<DmTaikhoan>(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));
		cboTKco.DataSource = lstTKCo;
		cboTKco.DisplayMember = "MaTaiKhoan";
		cboTKco.ValueMember = "Id";
		cboTKco.Columns.Add(new LookUpColumnInfo("MaTaiKhoan", "Mã tài khoản"));
		cboTKco.Columns.Add(new LookUpColumnInfo("TenTaiKhoan", "Tên tài khoản"));

		//Bind kho
        List<DmKho> lstMaKho = new List<DmKho>(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id));
		List<DmKho> lstMaKhoXuat = lstMaKho;

		cboKhoNhap.Properties.DataSource = lstMaKho;
		cboKhoNhap.Properties.DisplayMember = "KyHieu";
		cboKhoNhap.Properties.ValueMember = "Id";

		cboKhoXuat.Properties.DataSource = lstMaKhoXuat;
		cboKhoXuat.Properties.DisplayMember = "KyHieu";
		cboKhoXuat.Properties.ValueMember = "Id";

		//'Bind mã kho nhập
		cboMaKhoNhap.DataSource = lstMaKho;
		cboMaKhoNhap.DisplayMember = "KyHieu";
		cboMaKhoNhap.ValueMember = "Id";
		cboMaKhoNhap.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã kho nhập"));
		cboMaKhoNhap.Columns.Add(new LookUpColumnInfo("TenKho", "Tên kho"));

		//'Bind mã kho xuất
		cboMaKhoXuat.DataSource = lstMaKhoXuat;
		cboMaKhoXuat.DisplayMember = "KyHieu";
		cboMaKhoXuat.ValueMember = "Id";
		cboMaKhoXuat.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã kho xuất"));
		cboMaKhoXuat.Columns.Add(new LookUpColumnInfo("TenKho", "Tên kho"));

		//Bind vụ việc
        List<DmVuviec> lstVuViecTemp = new List<DmVuviec>(DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id));
		List<DmVuviec> lstVuviec = new List<DmVuviec>();
		DmVuviec objvuviec = new DmVuviec();
		lstVuviec.Add(objvuviec);
		lstVuviec.AddRange(lstVuViecTemp);
		cboVuViec.DataSource = lstVuviec;
		cboVuViec.DisplayMember = "KyHieu";
		cboVuViec.ValueMember = "Id";
		cboVuViec.Columns.Add(new LookUpColumnInfo("KyHieu", "Mã vụ việc"));
		cboVuViec.Columns.Add(new LookUpColumnInfo("TenVuviec", "Tên vụ việc"));

        IList<SxLenhsanxuat> lstLenhSx = _SxLenhsanxuatService.GetAll();
        cboLenhSanXuatNhapId.DataSource = lstLenhSx;
        cboLenhSanXuatXuatId.DataSource = lstLenhSx;

        List<DmPhongban> lstPhongBanTemp = new List<DmPhongban>();
        lstPhongBanTemp.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id));
        List<DmPhongban> lstPhongBan1 = new List<DmPhongban>();
        DmPhongban objphongban = new DmPhongban();
        lstPhongBan1.Add(objphongban);
        lstPhongBan1.AddRange(lstPhongBanTemp);
        cboPXXuat.DataSource = lstPhongBanTemp;
        cboPXNhap.DataSource = lstPhongBanTemp;

	}

	/// <summary>
	/// ham xu ly load form danh sach
	/// </summary>
	/// <remarks></remarks>

	private void Load_Grid(List<CT_H_GInfo> lstobj_ct_h_gg)
	{
		if (lstobj_ct_h_gg != null & lstobj_ct_h_gg.Count > 0) {
			grcLPN_Hnx.DataSource = lstobj_ct_h_gg;
			for (int i = 0; i <= lstobj_ct_h_gg.Count - 1; i++) {
				if (mCTHNXID == lstobj_ct_h_gg[i].Id) {
					this.grvLPX_Hnx.FocusedRowHandle = i;
					break; // TODO: might not be correct. Was : Exit For
				}
			}
		}

	}

	/// <summary>
	/// lay ID cua row dang focus
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	private bool GetRowSelect()
	{
		if ((grvLPX_Hnx.GetSelectedRows().Length > 0)) {
			if ((grvLPX_Hnx.RowCount != 0)) {
				CT_H_GInfo grtCTH_NX = (CT_H_GInfo)grvLPX_Hnx.GetRow(grvLPX_Hnx.GetSelectedRows()[0]);
				// DMBTKC = grtCTH_NX
				mCTHNXID = grtCTH_NX.Id;
				return true;
			}
		}
		return false;
	}

	/// <summary>
	/// ham xu ly lay data tren form de insert va update
	/// </summary>
	/// <remarks></remarks>
	private void GetControlToOBject()
	{
		try {
			//lay nhieu gia tri trong 1 table khac
			HtLoaichungtu drLPNhap = (HtLoaichungtu)ComboHelper.GetSelectData(grlLoaiPhieuNhap);

			//lay cac truogn con thieu 
            obj_ct_h_nx.TyGia = Decimal.Parse(txtTY_GIA.Text);
			obj_ct_h_nx.MaNte = cboTyGia.Text;
            obj_ct_h_nx.NteId = VnsConvert.CGuid(cboTyGia.EditValue);
			obj_ct_h_nx.NgoaiTe = TNCommon.ParseDecimal(!(VnsConvert.CGuid(cboTyGia.EditValue) == VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)));

			obj_ct_h_nx.NguoiGiaoNhanHang = txtNGUOI_GIAO_NHAN_HANG.Text;
			obj_ct_h_nx.DienGiai = txtDIEN_GIAI.Text;
			obj_ct_h_nx.NgayGhi = dteNGAY_GHI.DateTime;
			obj_ct_h_nx.NgayCt = dteNGAY_CT.DateTime;
			obj_ct_h_nx.NgayTao = DateTime.Now;
			//obj_ct_h_nx.CT_SO = txtCT_SO.Text
			obj_ct_h_nx.DonviId = Generals.DON_VI.Id;
			obj_ct_h_nx.MaDonvi = Generals.DON_VI.MaDonvi;
            if (urcGhi.Value_info != null && urcGhi.Value_info.ParameterValue != null)
                obj_ct_h_nx.Ghi = decimal.Parse(urcGhi.Value_info.ParameterValue.ToString());
            else
                obj_ct_h_nx.Ghi = 1;

			obj_ct_h_nx.MaLoaiCt = drLPNhap.MaLoaiCt;
			obj_ct_h_nx.KyHieuLoaiCt = drLPNhap.KyHieu;
			obj_ct_h_nx.IdLoaiCt = drLPNhap.Id;
			obj_ct_h_nx.SoDu = 0;

			Boolean flgUpdate = true;
			//Xử lý insert,update
			switch (m_InputState) {
                case FormGlobals.DataInputState.AddMode:
					decimal strmMonth = 0;
					strmMonth = Convert.ToDecimal(dteNGAY_CT.DateTime.Month);
                    decimal strYear = 0;
					strYear = Convert.ToDecimal(dteNGAY_CT.DateTime.Year);

					C_SoChungTu_RP.r_SoCTPREFIX(obj_loaichungtu.Id, strmMonth, strYear, Generals.DON_VI.Id);
					obj_ct_h_nx.CtSo = C_SoChungTu_RP.SO_CHUNG_TU;
					obj_ct_h_nx.PrefixCt = C_SoChungTu_RP.PREFIX;
					flgUpdate = false;
					break;
				default:
					break;
			}
			//lay gia trị control tren luoi gan cho obj
			foreach (CtDNx objctdnx in lstobj_ct_d_nx) {
				//objctdnx.CTH_NX_ID = obj_ct_h_nx.CTH_NX_ID
				//objctdnx.NGAY_TAO = DateTime.Now
				objctdnx.Xuat = drLPNhap.KhoXuat;
				//
				objctdnx.IdKhang = obj_ct_h_nx.KhangId;
				objctdnx.IdDmKhangCo = obj_ct_h_nx.KhangId;
				objctdnx.MaDmKhangCo = obj_ct_h_nx.MaKhang;
				objctdnx.TenDmKhangCo = obj_ct_h_nx.TenKhang;
				objctdnx.IdDmKhangNo = obj_ct_h_nx.KhangId;
				objctdnx.MaDmKhangNo = obj_ct_h_nx.MaKhang;
				objctdnx.TenDmKhangNo = obj_ct_h_nx.TenKhang;
				objctdnx.ThuTu = 0;
			}

			_CtHNxService.SaveChungTuKho(flgUpdate, ref obj_ct_h_nx, ref lstobj_ct_d_nx, del_lstobj_ct_d_nx);
			//Gán lại số chứng từ sau khi lưu xong
			C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo;
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// ham xu ly load data len form theo ID tuong ung
	/// </summary>
	/// <remarks></remarks>
	private void SetObjectToControl()
	{
		try {
			obj_ct_h_nx = CtHNxService.GetById(mCTHNXID);
			if (obj_ct_h_nx == null) {
				closeForm = true;
				return;
			} else {
				closeForm = false;
			}

			grlLoaiPhieuNhap.EditValue = obj_ct_h_nx.MaLoaiCt;

			HtLoaichungtu objLoaiCT = (HtLoaichungtu)ComboHelper.GetSelectData(grlLoaiPhieuNhap);
			txtNGUOI_GIAO_NHAN_HANG.Text = obj_ct_h_nx.NguoiGiaoNhanHang;
			txtDIEN_GIAI.Text = obj_ct_h_nx.DienGiai;
			dteNGAY_CT.DateTime = obj_ct_h_nx.NgayCt.Value;
			dteNGAY_GHI.DateTime = obj_ct_h_nx.NgayGhi.Value;
			C_SoChungTu_RP.Text = obj_ct_h_nx.PrefixCt + obj_ct_h_nx.CtSo;
			cboTyGia.EditValue = obj_ct_h_nx.NteId;
			txtTY_GIA.EditValue = obj_ct_h_nx.TyGia;

			urcGhi.Set_Status(obj_ct_h_nx.Ghi.ToString());
			urcGhi.cboStatus.EditValue = obj_ct_h_nx.Ghi.ToString();

            lstobj_ct_d_nx = new List<CtDNx>(CtDNxService.GetObjectByCTHId(mCTHNXID));

			grcPhieuDieuChuyen.DataSource = lstobj_ct_d_nx;
			TongTien();
			//
			ConfigGrid.GridConfig(this.Name + "?" + "MaLoaiCt=" + m_Ma_Loai_CT, grvPhieuDieuChuyen.Name, grvPhieuDieuChuyen);
			SetControlKho();

			if (VnsConvert.CGuid(cboTyGia.EditValue) == VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) {
				SetColNgoaiTe(false);
			} else {
				SetColNgoaiTe(true);
			}

			if (objLoaiCT.DmCbnv == 1) {
				if (((lstobj_ct_d_nx != null) & lstobj_ct_d_nx.Count > 0)) {
					cboKhoNhap.EditValue = lstobj_ct_d_nx[0].KhoNhapId;
					cboKhoXuat.EditValue = lstobj_ct_d_nx[0].KhoXuatId;
				}
			}

			//'Kiểm tra trạng thái có cho phép sửa hay không
			if (!(urcGhi.ChoPhepSuaCT())) {
				urcGhi.Enabled = false;
			} else {
				urcGhi.Enabled = true;
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// ham xet trang thai control tren form
	/// </summary>
	/// <remarks></remarks>
	private void DatTrangThaiControl()
	{
		switch (m_InputState) {
			case FormGlobals.DataInputState.AddMode:
                FormGlobals.Control_SetState(GroupControl1, FormGlobals.DataInputState.AddMode);
                FormGlobals.Control_SetState(GroupControl2, FormGlobals.DataInputState.AddMode);
				grvPhieuDieuChuyen.OptionsBehavior.Editable = true;
				btnAdd.Enabled = false;
				btnMod.Enabled = false;
				btnSav.Enabled = true;
				btnDel.Enabled = false;
				btnPri.Enabled = false;
				navWelding1.Enabled = false;
				btnCan.Enabled = true;
				grcLPN_Hnx.Enabled = false;
				//txtCT_SO.Properties.ReadOnly = True
				grlLoaiPhieuNhap.Properties.ReadOnly = false;
				navWelding1.Enabled = false;
				break;
            case FormGlobals.DataInputState.EditMode:
                FormGlobals.Control_SetState(GroupControl1, FormGlobals.DataInputState.EditMode);
                FormGlobals.Control_SetState(GroupControl2, FormGlobals.DataInputState.EditMode);
				grvPhieuDieuChuyen.OptionsBehavior.Editable = true;
				btnAdd.Enabled = false;
				btnMod.Enabled = false;
				btnSav.Enabled = true;
				btnDel.Enabled = true;
				navWelding1.Enabled = false;
				btnPri.Enabled = true;
				btnCan.Enabled = true;
				grcLPN_Hnx.Enabled = false;
				//txtCT_SO.Properties.ReadOnly = True
				grlLoaiPhieuNhap.Properties.ReadOnly = true;
				navWelding1.Enabled = false;
				break;
			default:
                FormGlobals.Control_SetState(GroupControl1, FormGlobals.DataInputState.ViewMode);
                FormGlobals.Control_SetState(GroupControl2, FormGlobals.DataInputState.ViewMode);
				grvPhieuDieuChuyen.OptionsBehavior.Editable = false;
				btnAdd.Enabled = true;
				btnMod.Enabled = true;
				btnSav.Enabled = false;
				btnPri.Enabled = true;
				navWelding1.Enabled = true;
				btnDel.Enabled = true;
				btnCan.Enabled = false;
				grcLPN_Hnx.Enabled = true;
				grlLoaiPhieuNhap.Properties.ReadOnly = true;
				navWelding1.Enabled = true;
				break;
		}
		GroupControl1.Focus();
		grlLoaiPhieuNhap.Focus();
	}

	/// <summary>
	/// ham kiem tra null cua form
	/// </summary>
	/// <param name="lstobj_ct_d_nx"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	private bool CheckNull(List<CtDNx> lstobj_ct_d_nx)
	{

		// kiem tra null cua comobox ma khach
		//kiem tra null cua comobox ngay hach toan
		if ((dteNGAY_GHI.DateTime == null)) {
			FormGlobals.Message_Warning("Bạn chưa nhập ngày hạch toán");
			dteNGAY_GHI.Focus();
			return false;
		}

		if ((dteNGAY_GHI.DateTime.Date > dteNGAY_CT.DateTime.Date)) {
            FormGlobals.Message_Warning("Ngày hạch toán không được lớn hơn ngày chứng từ");
			dteNGAY_GHI.Focus();
			return false;
		}

        Decimal tygia = Decimal.Parse(txtTY_GIA.Text);
        if (LimitValue.CheckTyGia(tygia) == false)
        {
            FormGlobals.Message_Warning("Tỷ giá không hợp lệ");
			txtTY_GIA.Focus();
			return false;
		}

		//vong lap kiem tra cac cot tren luoi
		if (grvPhieuDieuChuyen.RowCount != 0) {
			//Try
			Guid _KhoNhapID = new Guid();
			Guid _KhoXuatID = new Guid();
			if ((cboKhoNhap.Visible)) {
				_KhoNhapID = VnsConvert.CGuid(cboKhoNhap.EditValue);
				_KhoXuatID = VnsConvert.CGuid(cboKhoXuat.EditValue);
			} else {
				_KhoNhapID = Null.NullGuid;
				_KhoXuatID = Null.NullGuid;
			}
			//vong lap kiem tra cac cot tren luoi

			foreach (CtDNx objctd in lstobj_ct_d_nx) {
				//kiem tra gia tri null cua cot Hang hoa
				if (Guid.Empty == objctd.HanghoaId) {
                    FormGlobals.Message_Warning("Bạn chưa nhập mã hàng hóa");
					return false;
				}

				//kiem tra gia tri null cua cot kho nhap
				objctd.KhoNhapId = (_KhoNhapID == Null.NullGuid ? objctd.KhoNhapId : _KhoNhapID);
				if (Guid.Empty == objctd.KhoNhapId) {
                    FormGlobals.Message_Warning("Bạn chưa lựa chọn kho nhập");
					return false;
				}

				//kiem tra gia tri null cua cot kho xuat
				objctd.KhoXuatId = (_KhoXuatID == Null.NullGuid ? objctd.KhoXuatId : _KhoXuatID);

				if (Guid.Empty == objctd.KhoXuatId) {
                    FormGlobals.Message_Warning("Bạn chưa lựa chọn kho xuất");
					return false;
				}

				if ((objctd.KhoNhapId == objctd.KhoXuatId)) {
                    FormGlobals.Message_Warning("Kho nhập không được bằng kho xuất");
					return false;
				}

				//kiem tra gia tri cua cot so luong
				if (objctd.SoLuong == 0) {
                    FormGlobals.Message_Warning("Bạn chưa nhập số lượng");
					return false;
				}

				//kiem tra gia tri cua cot don gia
				if (objctd.DonGiaVon == 0) {
                    FormGlobals.Message_Warning("Bạn chưa nhập đơn giá");
					return false;
				}

				if (LimitValue.CheckCurrency(objctd.GiaVon) == false) {
                    FormGlobals.Message_Warning("Giá vốn không hợp lệ");
					return false;
				}

				// kiem tra gia tri null cua 2 cot ma tai khoan co va tai khoan no
				if (string.IsNullOrEmpty(objctd.MaTkcGiavon) | string.IsNullOrEmpty(objctd.MaTkcGiavon)) {
                    FormGlobals.Message_Warning("Bạn chưa nhập tài khoản có giá vốn");
					return false;
				}

			}
		} else {
            FormGlobals.Message_Warning("Dữ liệu trên lưới chưa có");
			return false;
		}

		return true;
	}

	/// <summary>
	/// xu ly khi kick vao btn add 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void btnAdd_Click(System.Object sender, System.EventArgs e)
	{
		try {
			grvPhieuDieuChuyen.RowCellStyle -= grvPhieuDieuChuyen_RowCellStyle;
			obj_ct_h_nx = new CtHNx();
            m_InputState = FormGlobals.DataInputState.AddMode;
			DatTrangThaiControl();

			ClearPage();

		//originEntity = New DBLogParamInfo()
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly khi kick vao btn Sua
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	/// 
	private void btnMod_Click(System.Object sender, System.EventArgs e)
	{
		try {
			if (obj_ct_h_nx.DaKhoaSo == 0) {
                m_InputState = FormGlobals.DataInputState.EditMode;

				DatTrangThaiControl();

				TongTien();

			} else {
                FormGlobals.Message_Information("Chứng từ đã được khóa nên không thể sửa!");
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly del 1 row khi kick vao btn delete
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void btnDelete_Click(System.Object sender, System.EventArgs e)
	{
		try {
			if (!urcGhi.ChoPhepSuaCT()) {
                FormGlobals.Message_Warning(msgTTChungTu);
				return;
			}
			//Check kho'a so? tha'ng
			if (obj_ct_h_nx.DaKhoaSo == 1) {
                FormGlobals.Message_Warning(msgKhoaSo);
				return;
			}
			if (lstobj_ct_h_gg.Count > 0) {
                if (!(FormGlobals.Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)))
                {
					return;
				}

				CtHNxService.DeleteChungTu(obj_ct_h_nx);

                mCTHNXID = Vns.Erp.Core.Controls.Commons.GridHelper.RemoveLeftGrid(ref lstobj_ct_h_gg, mCTHNXID);
				if (!(Guid.Empty == mCTHNXID)) {
					SetObjectToControl();
				}

				//refresh lai data tren luoi
				grvLPX_Hnx.RefreshData();

                m_InputState = FormGlobals.DataInputState.ViewMode;
				//DatTrangThaiControl()
			}

			if (lstobj_ct_h_gg.Count == 0) {
				ClearPage();
                m_InputState = FormGlobals.DataInputState.AddMode;
				grlLoaiPhieuNhap.Focus();
			}
			//btnAdd.Focus()
			DatTrangThaiControl();
			SetFocus_FirstCell();
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly khi kick vao btn Luu
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void btnLuu_Click(System.Object sender, System.EventArgs e)
	{
		try {
			grvPhieuDieuChuyen.RowCellStyle += grvPhieuDieuChuyen_RowCellStyle;
			this.ValidateChildren();

			//'check trang thai co thuoc quyen cua user hay ko
			if (!urcGhi.ChoPhepSuaCT()) {
                FormGlobals.Message_Warning(msgTTChungTu);
				return;
			}

			// goi ham check null cac gia tri cua form
			if (!CheckNull(lstobj_ct_d_nx)) {
				return;
			}

			if (obj_ct_h_nx.DaKhoaSo == 1) {
				return;
                FormGlobals.Message_Information("Chứng từ này đã được khóa sổ");
			}

            int intYear = dteNGAY_CT.DateTime.Year;
			//Dim objKtKhoaSo As KtKhoasoThang = New KtKhoasoThang
			//objKtKhoaSo = KT_Khoaso_ThangBO.Instance.GetByNam(intYear, Generals.DON_VI.DONVI_ID.Replace("-", ""))

			//Check khoa so thang
			//Dim ktKhoasoThangService As KtKhoasoThangService = New KtKhoasoThangService()
			if (_KtKhoasoThangService.KiemTraKhoaSo(dteNGAY_CT.DateTime, Generals.DON_VI.Id)) {
                FormGlobals.Message_Warning(msgKhoaSo);
				return;
			}

			//Try
			Guid _KhoNhapID = default(Guid);
			Guid _KhoXuatID = default(Guid);
			if (!(cboKhoNhap.Visible)) {
                _KhoNhapID = VnsConvert.CGuid(cboKhoNhap.EditValue);
                _KhoXuatID = VnsConvert.CGuid(cboKhoXuat.EditValue);
			} else {
				_KhoNhapID = Guid.Empty;
				_KhoXuatID = Guid.Empty;
			}

			for (int i = 0; i <= lstobj_ct_d_nx.Count - 1; i++) {
				DmKho objKho = new DmKho();
				if (Guid.Empty == _KhoXuatID) {
					objKho = (DmKho)cboMaKhoXuat.GetDataSourceRowByKeyValue(lstobj_ct_d_nx[i].KhoXuatId);
				} else {
					lstobj_ct_d_nx[i].KhoNhapId = _KhoNhapID;
					lstobj_ct_d_nx[i].KhoXuatId = _KhoXuatID;
				}
			}

			List<DmKho> lst = new List<DmKho>();
            lst = (List<DmKho>)cboKhoXuat.Properties.DataSource;
            //if (!(_CtDNxService.KiemTraLuongTonKho(obj_ct_h_nx.Id, dteNGAY_CT.EditValue, lstobj_ct_d_nx, lst, Generals.DON_VI.Id))) {
            //    FormGlobals.Message_Warning("Không cho phép xuất âm");
            //    grvPhieuDieuChuyen.RefreshData();
            //    return;
            //}

			//goi ham xu ly data tren form
			frmProgress.Instance().Thread = GetControlToOBject;
			frmProgress.Instance().Show_Progress();
			frmProgress.Instance().SetFinishText("Data saved");

			mCTHNXID = obj_ct_h_nx.Id;
			CT_H_GInfo editObject = new CT_H_GInfo(obj_ct_h_nx);
            Vns.Erp.Core.Controls.Commons.GridHelper.RefreshLeftGrid(ref grvLPX_Hnx, ref lstobj_ct_h_gg, editObject, m_InputState);

			m_InputState = FormGlobals.DataInputState.ViewMode;
			DatTrangThaiControl();
			btnAdd.Focus();
			grvPhieuDieuChuyen.RowCellStyle -= grvPhieuDieuChuyen_RowCellStyle;
		} catch (Exception ex) {
			FormGlobals.Message_Error(ex);
		}
	}

	private void TinhSoTonKho(ref CtDNx objNX)
	{
        //if (!(Guid.Empty == objNX.HanghoaId) & !(Guid.Empty == objNX.KhoXuatId)) {
        //    objNX.TonKho = CtDNxService.TinhSLTonKho(objNX.Id, dteNGAY_CT.EditValue, objNX.HanghoaId, objNX.KhoXuatId, Generals.DON_VI.Id);
        //}
	}

	/// <summary>
	/// xu ly tiem kiem 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void btnSea_Click(System.Object sender, System.EventArgs e)
	{
        //try {
        //    frmTimKiemChungTuKho fr = ObjectFactory.GetObject("frmTimKiemChungTuKho");
        //    fr.MaCT = obj_loaichungtu.MaLoaiCt;
        //    fr.ShowDialog();
        //    if (fr.lstobj_ct_h_g.Count > 0) {
        //        //
        //        lstobj_ct_h_gg = fr.lstobj_ct_h_g;
        //        mCTHNXID = lstobj_ct_h_gg[0].Id;

        //        Load_Grid(lstobj_ct_h_gg);
        //        //
        //        SetObjectToControl();
        //        TongTien();
        //    }

        //    m_InputState = FormGlobals.DataInputState.ViewMode;
        //    DatTrangThaiControl();
        ////txtCT_SO.Properties.ReadOnly = True
        //} catch (Exception ex) {
        //    FormGlobals.Message_Error(ex);
        //}
	}

	/// <summary>
	/// xu ly khi kick vao btn Huy
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void btnCan_Click(System.Object sender, System.EventArgs e)
	{
		try {
			if (lstobj_ct_h_gg.Count > 0) {
                if (m_InputState == FormGlobals.DataInputState.AddMode)
                {
					mCTHNXID = lstobj_ct_h_gg[lstobj_ct_h_gg.Count - 1].Id;
					grvLPX_Hnx.FocusedRowHandle = lstobj_ct_h_gg.Count - 1;
				}
				SetObjectToControl();
				TongTien();
                m_InputState = FormGlobals.DataInputState.ViewMode;
			} else {
                m_InputState = FormGlobals.DataInputState.AddMode;
			}
			DatTrangThaiControl();
			btnAdd.Focus();
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly khi kick vao btn In phieu
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void btnPri_Click(System.Object sender, System.EventArgs e)
	{
        //try {
        //    HtLoaichungtu obj_htchungtu = (HtLoaichungtu)ComboHelper.GetSelectData(grlLoaiPhieuNhap);
        //    dynamic obj_form = (Form)ObjectFactory.GetObject("frmKho_Input", new object[] {
        //        mCTHNXID,
        //        obj_htchungtu
        //    });
        //    obj_form.ShowInTaskbar = false;
        //    obj_form.ShowDialog();
        //} catch (Exception ex) {
        //    FormGlobals.Message_Error(ex);
        //}
	}

	/// <summary>
	/// xu ly xoa toan bo data tren form
	/// </summary>
	/// <remarks></remarks>

	public void ClearPage()
	{
        FormGlobals.Control_ClearData(GroupControl1);
        FormGlobals.Control_ClearData(GroupControl2);
		C_SoChungTu_RP.Text = "";

		dteNGAY_GHI.EditValue = null;
		//cboTyGia.ItemIndex = 2
		txtTY_GIA.EditValue = 1;
		txtTongSL.Text = null;
		TxtTongTien.Text = null;
		//
		//urcGhi.cboStatus.EditValue = "1"
		urcGhi.Set_Status("1");
		dteNGAY_CT.EditValue = DateTime.Now;
		dteNGAY_GHI.EditValue = DateTime.Now;
		//txtTongSL.Enabled = False
		//TxtTongTien.Enabled = False
		// SplitContainerControl1.Panel2.MinimumSize = 950
		TNCommon.SelectFirst(grlLoaiPhieuNhap);
		//grlLoaiPhieuNhap.EditValue = m_Ma_Loai_CT
		lstobj_ct_d_nx = new List<CtDNx>();
		lstobj_ct_d_nx.Add(new CtDNx());
		grcPhieuDieuChuyen.DataSource = lstobj_ct_d_nx;
		grvPhieuDieuChuyen.RefreshData();

	}

	/// <summary>
	/// ham tinh tong tien cot trong luoi
	/// </summary>
	/// <remarks></remarks>
	private void TongTien()
	{
		decimal sumTongTien = default(decimal);
		decimal sumTongSoLuong = default(decimal);
		int i = 0;
		for (i = 0; i <= grvPhieuDieuChuyen.RowCount - 1; i++) {
			CtDNx tmpCtDNx = (CtDNx)grvPhieuDieuChuyen.GetRow(i);
			sumTongTien = sumTongTien + tmpCtDNx.GiaVon;
			sumTongSoLuong = sumTongSoLuong + tmpCtDNx.SoLuong;
		}
		//TxtTongTien.EditValue = Format(CLng(sumTongTien.ToString), "n0")
		//txtTongSL.EditValue = Format(CLng(sumTongSoLuong.ToString), "n0")
		TxtTongTien.EditValue = sumTongTien;
		txtTongSL.EditValue = sumTongSoLuong;
	}

	/// <summary>
	/// ham xu ly delete record
	/// </summary>
	/// <remarks></remarks>
	private void DeleteRow()
	{
		if (grvPhieuDieuChuyen.RowCount > 0) {
			CtDNx gridctdnx = (CtDNx)grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle);
			del_lstobj_ct_d_nx.Add(gridctdnx);
			grvPhieuDieuChuyen.DeleteSelectedRows();
			TongTien();
		} else {
            FormGlobals.Message_Warning("Không có bản ghi nào được chọn!");
		}

		// Message_Information("Xóa thành công")
	}

	/// <summary>
	/// xu ly btn dong
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void btnClo_Click(System.Object sender, System.EventArgs e)
	{
		try {
			this.Close();
			DialogResult = System.Windows.Forms.DialogResult.OK;
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	#endregion

	#region "Events"

	/// <summary>
	/// xu ly ... khi dang focus row hien tai
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void grvLPX_Hnx_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
	{
		try {
            if ((m_InputState == FormGlobals.DataInputState.EditMode) & (btnMod.Enabled == false))
            {
			//SetObjectToControl()
            }
            else if ((m_InputState == FormGlobals.DataInputState.AddMode) & (btnMod.Enabled == false))
            {
				return;
			} else {
				if (GetRowSelect()) {
					SetObjectToControl();
				}
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly su kien enter xuong dong trong luoi
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void grvPhieuDieuChuyen_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
	{
		try {
			switch (e.KeyCode) {
				case Keys.Enter:
					if ((GridHelper.CheckAddNewRow(grvPhieuDieuChuyen))) {
						lstobj_ct_d_nx.Add(new CtDNx());
						grvPhieuDieuChuyen.RefreshData();
						SetFocus_FirstCell();
					}
					break;
			}
			//
			if (e.KeyCode == Keys.F12) {
				string FormID = this.Name + "?" + "MaLoaiCt=" + m_Ma_Loai_CT;
				List<ColInfo> lstColInfo = new List<ColInfo>();
				ConfigGrid.GetGridColInfo(grvPhieuDieuChuyen, lstColInfo);
				ConfigGrid f = new ConfigGrid();
				if (f.Show_Form(grvPhieuDieuChuyen.Name, FormID, lstColInfo)) {
					ConfigGrid.GridConfig(FormID, grvPhieuDieuChuyen.Name, grvPhieuDieuChuyen);
				}
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly gan cac gia tri vao gridview 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void grvPhieuDieuChuyen_CellValueChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
	{
		try {
			CtDNx gridctdnx = (CtDNx)grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle);
			switch (e.Column.Name) {
				case "KHO_NHAP_ID":
					DmKho cboKhoNhap = (DmKho)cboMaKhoNhap.GetDataSourceRowByKeyValue(gridctdnx.Id);
					if ((gridctdnx == null)) {
						return;
					}

					break;
				case "TKN_GIAVON":
					DmTaikhoan cboTKNGiaVon = (DmTaikhoan)cboTKno.GetDataSourceRowByKeyValue(gridctdnx.TknGiavon);
					if ((gridctdnx == null)) {
						return;
					}
					//gan vao grid
					gridctdnx.MaTknGiavon = cboTKNGiaVon.MaTaikhoan;

					break;
				case "TKC_GIAVON":
					DmTaikhoan cboTKCGiaVon = (DmTaikhoan)cboTKco.GetDataSourceRowByKeyValue(gridctdnx.TkcGiavon);
					if ((gridctdnx == null)) {
						return;
					}
					//gan vao grid
					gridctdnx.MaTkcGiavon = cboTKCGiaVon.MaTaikhoan;

					break;
				case "VUVIEC_ID":
					DmVuviec cboVViec = (DmVuviec)cboVuViec.GetDataSourceRowByKeyValue(gridctdnx.VuviecId);
					if ((gridctdnx == null)) {
						return;
					}
					//Gan vao GridView
					gridctdnx.VuviecId = cboVViec.Id;
					gridctdnx.KyHieuVuviec = cboVViec.KyHieu;
					gridctdnx.TenVuviec = cboVViec.TenVuviec;
					gridctdnx.MaVuviec = cboVViec.MaVuviec;

					break;
			}

			try {
				if (VnsConvert.CGuid(cboTyGia.EditValue) != VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) {
					if (e.Column.FieldName.Equals("DonGiaVonNte") | e.Column.FieldName.Equals("SoLuong")) {
						decimal Total = gridctdnx.DonGiaVonNte * gridctdnx.SoLuong;
						gridctdnx.GiaVonNt = Total;
						gridctdnx.GiaVon = Total * decimal.Parse(txtTY_GIA.Text);
					}

					if (e.Column.FieldName.Equals("DonGiaVonNte")) {
						decimal GiaVND = decimal.Parse(txtTY_GIA.Text) * gridctdnx.DonGiaVonNte;
						gridctdnx.DonGiaVon = GiaVND;
					}
				} else {
					if (e.Column.FieldName.Equals("DonGiaVon") | e.Column.FieldName.Equals("SoLuong")) {
						decimal Total = gridctdnx.DonGiaVon * gridctdnx.SoLuong;
						gridctdnx.GiaVon = Total;
					}
				}

				if (e.Column.FieldName.Equals("DonGiaVonNte") | e.Column.FieldName.Equals("SoLuong")) {
					decimal Total = gridctdnx.DonGiaVonNte * gridctdnx.SoLuong;
					gridctdnx.GiaVonNt = Total;
				}

				TongTien();

			} catch (OverflowException ex) {
                FormGlobals.Message_Warning("Giá trị nhập vào quá lớn!");
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	private void SetFocus_FirstCell()
	{
        grvPhieuDieuChuyen.FocusedRowHandle = grvPhieuDieuChuyen.RowCount - 1;
        grvPhieuDieuChuyen.SelectRow(grvPhieuDieuChuyen.FocusedRowHandle);
        try
        {
            grvPhieuDieuChuyen.FocusedColumn = grvPhieuDieuChuyen.VisibleColumns[0];
        }
        catch (Exception ex)
        {
            FormGlobals.Message_Error(ex);
        }
	}

	/// <summary>
	/// xu ly su kien nut keys tren form
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void frmPhieuDieuXuatDieuChuyen_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
	{
		try {
			switch (e.KeyCode) {
				case Keys.Escape:
					if (Vns.Erp.Core.Controls.Commons.FormHelper.CheckStatusEscape(m_InputState)) {
						this.Close();
					}
					break; // TODO: might not be correct. Was : Exit Select


					break;
				case Keys.F4:
					//kiem tra dang o trang thai gi de xet xem co su dung them dong ko
                    if (m_InputState != FormGlobals.DataInputState.ViewMode)
                    {
						lstobj_ct_d_nx.Add(new CtDNx());
						SetFocus_FirstCell();
						grvPhieuDieuChuyen.RefreshData();
					}
					break; // TODO: might not be correct. Was : Exit Select


					break;
				case Keys.F8:
					//kiem tra dang o trang thai gi de xet xem co su dung xoa dong ko
                    if (m_InputState != FormGlobals.DataInputState.ViewMode)
                    {
						DeleteRow();
						// Cap nhat lai gia tri Tong Tien trong form
					}
					break; // TODO: might not be correct. Was : Exit Select

					break;
				//Dim frm_log As KTY.Security.frmViewLog_DanhSach
				//If m_InputState <> DataInputState.AddMode Then
				//    frm_log = New KTY.Security.frmViewLog_DanhSach(mCTHNXID, obj_ct_h_nx.ID_LOAI_CT, obj_ct_h_nx.CT_SO)
				//    frm_log.ShowDialog()
				//End If
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly su kien chi dc nhap "1" hoac "2" vao o text trang thai
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void txtGHI_KeyPress(System.Object sender, System.Windows.Forms.KeyPressEventArgs e)
	{
        //try {
        //    if ((Strings.Asc(e.KeyChar) != 49) & (Strings.Asc(e.KeyChar) != 50) & (Strings.Asc(e.KeyChar) != 8)) {
        //        e.Handled = true;
        //    }
        //} catch (Exception ex) {
        //    FormGlobals.Message_Error(ex);
        //}
	}

	private void txtTY_GIA_EditValueChanged(System.Object sender, System.EventArgs e)
	{
		try {
			try {

				foreach (CtDNx gridctdnx in lstobj_ct_d_nx) {
					if ( VnsConvert.CGuid(cboTyGia.EditValue) != VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) {
						gridctdnx.GiaVonNt = gridctdnx.DonGiaVonNte * gridctdnx.SoLuong;
						gridctdnx.GiaVon = gridctdnx.GiaVonNt * decimal.Parse(txtTY_GIA.Text);
						gridctdnx.DonGiaVon = gridctdnx.DonGiaVonNte * decimal.Parse(txtTY_GIA.Text);
					} else {
						gridctdnx.GiaVon = gridctdnx.DonGiaVon * gridctdnx.SoLuong;
					}

					gridctdnx.GiaVonNt = gridctdnx.DonGiaVonNte * gridctdnx.SoLuong;

					TongTien();
				}
			} catch (OverflowException ex) {
                FormGlobals.Message_Warning("Giá trị quá lớn!");
			}
			grvPhieuDieuChuyen.RefreshData();
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	private void dteNGAY_CT_EditValueChanged(System.Object sender, System.EventArgs e)
	{
		if (dteNGAY_GHI == null) {
		} else {
			dteNGAY_GHI.EditValue = dteNGAY_CT.EditValue;
		}
	}

	private void PhieuDieuXuatDieuChuyen_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
	{
		DialogResult = System.Windows.Forms.DialogResult.OK;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="senders"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void GFilter_HANGHOA_ID_AfterFilter(object senders, EventArgs e)
	{
		try {
			int rowHandle = grvPhieuDieuChuyen.FocusedRowHandle;
			string columnName = grvPhieuDieuChuyen.FocusedColumn.Name;
			CtDNx gridctdnx = (CtDNx)grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle);

			switch (columnName) {
				case "HangHoaId":
					if ((gridctdnx == null)) {
						return;
					}

					//Gan vao GridView
					if (GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count != 0) {
						gridctdnx.TenHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[2];
						gridctdnx.MaHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[3];
						gridctdnx.KyHieuHanghoa = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[1];
						gridctdnx.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[0]);
						gridctdnx.TenDvt = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[4];

						string strMaTaiKhoan = GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[5];

						if (string.IsNullOrEmpty(strMaTaiKhoan)) {
						} else {
							string[] strMTK = strMaTaiKhoan.Split(';');
							strMaTaiKhoan = strMTK[0];
							DmTaikhoan obj_taikhoan = new DmTaikhoan();
							obj_taikhoan = DmTaikhoanService.GetObjectByMaTK(strMaTaiKhoan, Generals.DON_VI.Id);
							gridctdnx.MaTkcGiavon = obj_taikhoan.MaTaikhoan;
							gridctdnx.TkcGiavon = obj_taikhoan.Id;
							gridctdnx.MaTknGiavon = obj_taikhoan.MaTaikhoan;
							gridctdnx.TknGiavon = obj_taikhoan.Id;

                            gridctdnx.DonGiaVon = 1;
						}
						grvPhieuDieuChuyen.SetRowCellValue(rowHandle, "KyHieuHanghoa", gridctdnx.KyHieuHanghoa);
					}

					break;
				case "MA_TKN_GIAVON":
					if ((gridctdnx == null)) {
						return;
					}
					if (Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0) {
						gridctdnx.MaTknGiavon = Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES[1];
						gridctdnx.TknGiavon = VnsConvert.CGuid(Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
					}
					grvPhieuDieuChuyen.SetRowCellValue(rowHandle, "MaTknGiavon", gridctdnx.MaTknGiavon);
					break;
				case "MA_TKC_GIAVON":
					if ((gridctdnx == null)) {
						return;
					}
					if (Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0) {
						gridctdnx.MaTkcGiavon = Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES[1];
						gridctdnx.TkcGiavon = VnsConvert.CGuid(Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
					}
					grvPhieuDieuChuyen.SetRowCellValue(rowHandle, "MaTkcGiavon", gridctdnx.MaTkcGiavon);
					break;
			}

			SendKeys.Send("{TAB}");

		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	private void CheckEdit1_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
	{
		try {
			EnterNext(sender, e);
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	private void EnterNext(System.Object sender, System.Windows.Forms.KeyEventArgs e)
	{
		try {
			if (e.KeyCode == Keys.Enter) {
				SendKeys.Send("{TAB}");
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	/// <summary>
	/// xu ly chon vao 1 dong trong comobox se lay ra 1 truong trong do gan vao o text tuong ung
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void cboTyGia_EditValueChanged(object sender, System.EventArgs e)
	{
		try {
			if (VnsConvert.CGuid(cboTyGia.EditValue) == VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)) {
				txtTY_GIA.Text = "1";
				SetColNgoaiTe(false);
				if (lstobj_ct_d_nx.Count > 0) {
					foreach (CtDNx objctdnx in lstobj_ct_d_nx) {
						objctdnx.DonGiaBanNte = 0;
						objctdnx.DonGiaVonNte = 0;
						objctdnx.GiaVonNt = 0;
						objctdnx.SoTienBanNte = 0;
					}
					grvPhieuDieuChuyen.RefreshData();
				}
			} else {
				if (!(OnLoadData)) {
					DmNgoaiteService dmNgoaiTe = new DmNgoaiteService();
					txtTY_GIA.EditValue = _LsTygiaService.GetTyGiaNgoaiTe(VnsConvert.CGuid(cboTyGia.EditValue), dteNGAY_CT.DateTime);
				}
				SetColNgoaiTe(true);
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	private void SetColNgoaiTe(bool ngoaite)
	{
		grvPhieuDieuChuyen.Columns["DonGiaVonNte"].Visible = ngoaite;
		grvPhieuDieuChuyen.Columns["GiaVonNt"].Visible = ngoaite;
		grvPhieuDieuChuyen.Columns["DonGiaVon"].ColumnEdit.ReadOnly = ngoaite;
		if ((ngoaite)) {
			txtTY_GIA.Enabled = true;
		//grvPhieuDieuChuyen.Columns("DON_GIA_VON_NTE").VisibleIndex = 6
		//grvPhieuDieuChuyen.Columns("GIA_VON_NT").VisibleIndex = 7
		} else {
			txtTY_GIA.Enabled = false;
		}
	}

	private void GFilterEdit_HANGHOA_ID_FisrtBinddata(System.Object senders, System.EventArgs e)
	{
		try {
			switch (grvPhieuDieuChuyen.FocusedColumn.Name) {
				case "HangHoaId":
					if (GFilterEdit_HANGHOA_ID.C_DATA_SOURCE == null) {
						if (Kry_DATASOURE == null) {
							GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Vns.Erp.Core.DataHelper.ToDataTable(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id));
						} else {
							GFilterEdit_HANGHOA_ID.C_DATA_SOURCE = Kry_DATASOURE;
						}
						GFilterEdit_HANGHOA_ID.Editors.A_DATA_SOURCE = GFilterEdit_HANGHOA_ID.C_DATA_SOURCE;
					}
					break;
				default:
					break;
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}

	private void GFilterEdit_HANGHOA_ID_ClearDataFilter(System.Object senders, System.EventArgs e)
	{
		try {
			int rowHandle = grvPhieuDieuChuyen.FocusedRowHandle;
			string columnName = grvPhieuDieuChuyen.FocusedColumn.Name;
			CtDNx obj = (CtDNx)grvPhieuDieuChuyen.GetRow(grvPhieuDieuChuyen.FocusedRowHandle);

			switch (columnName) {
				case "HangHoaId":
					if (obj == null) {
						return;
					}
					if (GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES.Count > 0) {
						obj.HanghoaId = VnsConvert.CGuid(GFilterEdit_HANGHOA_ID.OwnerEdit.A_LIST_VALUES[0]);
					}
					break;
				case "MA_TKN_GIAVON":
					if ((obj == null)) {
						return;
					}
					if (Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0) {
						obj.TknGiavon = VnsConvert.CGuid(Gfilter_TKN_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
					}
					break;
				case "MA_TKC_GIAVON":
					if ((obj == null)) {
						return;
					}
					if (Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES.Count > 0) {
						obj.TkcGiavon = VnsConvert.CGuid(Gfilter_TKC_GIAVON.OwnerEdit.A_LIST_VALUES[0]);
					}
					break;
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}
	#endregion

	private void grlLoaiPhieuNhap_EditValueChanged(System.Object sender, System.EventArgs e)
	{
		SetControlKho();
	}

	private void SetControlKho()
	{
		HtLoaichungtu objLoaiChungTu = (HtLoaichungtu)ComboHelper.GetSelectData(grlLoaiPhieuNhap);

		if (objLoaiChungTu == null) {
			return;
		}

		bool tempV = false;
		if ((objLoaiChungTu.DmCbnv == 1)) {
			tempV = true;
		} else {
			//grvPhieuDieuChuyen.Columns("KHO_NHAP_ID").VisibleIndex = 3
			//grvPhieuDieuChuyen.Columns("KHO_XUAT_ID").VisibleIndex = 4
		}
		//Combo

		lblKhoNhap.Visible = tempV;
		lblKhoXuat.Visible = tempV;
		cboKhoNhap.Visible = tempV;
		cboKhoXuat.Visible = tempV;
		//Grid
		int Dem = 0;
		bool BVisible = false;

		foreach (DevExpress.XtraGrid.Columns.GridColumn temp in grvPhieuDieuChuyen.Columns) {
			switch (temp.FieldName) {
				case "KhoNhapId":
				case "KhoXuatId":
					grvPhieuDieuChuyen.Columns[temp.FieldName].Visible = !tempV;
					if (!tempV) {
						grvPhieuDieuChuyen.Columns[temp.FieldName].VisibleIndex = grvPhieuDieuChuyen.Columns[temp.FieldName].VisibleIndex;
					}
					break;
				default:
					BVisible = grvPhieuDieuChuyen.Columns[temp.FieldName].Visible;
					Dem = grvPhieuDieuChuyen.Columns[temp.FieldName].VisibleIndex;

					grvPhieuDieuChuyen.Columns[temp.FieldName].Visible = grvPhieuDieuChuyen.Columns[temp.FieldName].Visible;
					grvPhieuDieuChuyen.Columns[temp.FieldName].VisibleIndex = grvPhieuDieuChuyen.Columns[temp.FieldName].VisibleIndex;
					break;
			}
		}
	}

	private void grvPhieuDieuChuyen_RowCellStyle(System.Object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
	{
		try {
			object val = grvPhieuDieuChuyen.GetRowCellValue(e.RowHandle, e.Column);
            decimal dvalue = 0;
			switch (e.Column.FieldName) {
				case "KyHieuHanghoa":
					if (string.IsNullOrEmpty(val.ToString())) {
						AppearanceHelper.Apply(e.Appearance, Generals.appError);
					}

					break;
				case "SoLuong":
                    Decimal.TryParse(val.ToString(), out dvalue);
                    if (dvalue <= 0 | dvalue >= decimal.MaxValue)
                    {
						AppearanceHelper.Apply(e.Appearance, Generals.appError);
					}
					break;
				case "DonGiaVon":
                    Decimal.TryParse(val.ToString(), out dvalue);
                    if (dvalue <= 0 | dvalue >= decimal.MaxValue)
                    {
						AppearanceHelper.Apply(e.Appearance, Generals.appError);
					}
					break;
			}
		} catch (Exception ex) {
            FormGlobals.Message_Error(ex);
		}
	}
}
}