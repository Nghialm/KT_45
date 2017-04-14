using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;



namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDieuChuyenTaiSan_DanhSach
    {

        #region "Variables"

        private DmTscd obj_tscd = new DmTscd();
        private TsDieuchuyen obj_TSDC = new TsDieuchuyen();
        private List<DmTscd> lst_tscd = new List<DmTscd>();
        private List<TsDieuchuyen> lst_ts_dc = new List<TsDieuchuyen>();
        #endregion

        #region "Property"
        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }

        private ITsDieuchuyenService _TsDieuchuyenService;
        public ITsDieuchuyenService TsDieuchuyenService
        {
            get { return _TsDieuchuyenService; }
            set { _TsDieuchuyenService = value; }
        }

        private IDmPhongbanService _DmPhongbanService;
        public IDmPhongbanService DmPhongbanService
        {
            get { return _DmPhongbanService; }
            set { _DmPhongbanService = value; }
        }

        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }
        #endregion

        #region "Private functions"

        private void AddEvents()
        {
            KeyDown += frmDieuChuyenTaiSan_DanhSach_KeyDown;
            Load += frmDieuChuyenTaiSan_DanhSach_Load;
            grvTSCD.FocusedRowChanged += grvTSCD_FocusedRowChanged;
            btnChuyen.Click += btnCreate_Click;
            btnModify.Click += btnModify_Click;
            btnDelete.Click += btnDelete_Click;
            grvBoPhan.CustomUnboundColumnData += grvBoPhan_CustomUnboundColumnData;
            btnClose.Click += btnClose_Click;
        }

        public frmDieuChuyenTaiSan_DanhSach()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        private void Load_grv_TSCD()
        {
            int TotalResult = 0;
            lst_tscd.AddRange(_DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, out TotalResult));
            grcTSCD.DataSource = lst_tscd;
        }

        private void Load_grv_BoPhan(Guid TSCD_ID)
        {
            lst_ts_dc = new List<TsDieuchuyen>();
            lst_ts_dc.AddRange(_TsDieuchuyenService.GetObjectByTSCD_ID(TSCD_ID));
            grcBoPhan.DataSource = lst_ts_dc;
        }

        private void frmDieuChuyenTaiSan_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                Load_grv_TSCD();

                //bind bo phan dieu chuyen
                List<DmPhongban> lstDM_PB = new List<DmPhongban>();
                lstDM_PB.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id));
                cboBO_PHAN_DC_ID.DataSource = lstDM_PB;
                cboBO_PHAN_DC_ID.DisplayMember = "TenPhongban";
                cboBO_PHAN_DC_ID.ValueMember = "Id";

                //tao cac unbound column
                grcBoPhan.ForceInitialize();
                //ub tai khoan tai san
                GridColumn ubTKTS = grvBoPhan.Columns.AddField("TK_TS");
                ubTKTS.Caption = "Tài khoản tài sản";
                ubTKTS.VisibleIndex = 3;
                ubTKTS.Width = 200;
                ubTKTS.UnboundType = DevExpress.Data.UnboundColumnType.String;
                ubTKTS.OptionsColumn.ReadOnly = true;
                //ub tai san khau hao
                GridColumn ubTKKH = grvBoPhan.Columns.AddField("TK_KH");
                ubTKKH.Caption = "Tài khoản khấu hao";
                ubTKKH.VisibleIndex = 4;
                ubTKKH.Width = 200;
                ubTKKH.UnboundType = DevExpress.Data.UnboundColumnType.String;
                ubTKKH.OptionsColumn.ReadOnly = true;
                //ub tai san chi phi
                GridColumn ubTKCP = grvBoPhan.Columns.AddField("TK_CP");
                ubTKCP.Caption = "Tài khoản chi phí";
                ubTKCP.VisibleIndex = 5;
                ubTKCP.Width = 200;
                ubTKCP.UnboundType = DevExpress.Data.UnboundColumnType.String;
                ubTKCP.OptionsColumn.ReadOnly = true;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void Create()
        {
            //Try
            frmDieuChuyenTaiSan_ChiTiet frm = (frmDieuChuyenTaiSan_ChiTiet)ObjectFactory.GetObject("frmDieuChuyenTaiSan_ChiTiet");
            if ((frm.Show_Form(obj_tscd.Id, Null.NullGuid, FormGlobals.DataInputState.AddMode)))
            {
                this.Load_grv_BoPhan(obj_tscd.Id);
                grvBoPhan.FocusedRowHandle = grvBoPhan.RowCount - 1;
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        private void Edit()
        {
            //Try
            if ((grvBoPhan.RowCount != 0))
            {
                obj_TSDC = (TsDieuchuyen)grvBoPhan.GetRow(grvBoPhan.FocusedRowHandle);
                if ((obj_TSDC.ThuTu < lst_ts_dc.Count))
                {
                    FormGlobals.Message_Warning("Bạn không được sửa bản ghi này");
                }
                else
                {
                    frmDieuChuyenTaiSan_ChiTiet frm = (frmDieuChuyenTaiSan_ChiTiet)ObjectFactory.GetObject("frmDieuChuyenTaiSan_ChiTiet");
                    if ((frm.Show_Form(obj_tscd.Id, obj_TSDC.Id, FormGlobals.DataInputState.EditMode)))
                    {
                        this.Load_grv_BoPhan(obj_tscd.Id);
                        grvBoPhan.FocusedRowHandle = grvBoPhan.RowCount - 1;
                    }
                }
            }
            else
            {
                FormGlobals.Message_Warning("Không có bản ghi nào!");
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        private void Delete()
        {
            //Try
            if (grvBoPhan.RowCount != 0)
            {
                obj_TSDC = (TsDieuchuyen)grvBoPhan.GetRow(grvBoPhan.FocusedRowHandle);
                if ((obj_TSDC.ThuTu < lst_ts_dc.Count))
                {
                    FormGlobals.Message_Warning("Bạn không được xóa bản ghi này");
                }
                else if ((MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
                {
                    _TsDieuchuyenService.Delete(obj_TSDC);
                    this.Load_grv_BoPhan(obj_tscd.Id);
                    grvBoPhan.RefreshData();
                }
            }
            else
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được chọn!");
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }
        #endregion

        #region "Events"

        private void grvTSCD_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if ((lst_tscd.Count != 0))
                {
                    obj_tscd = (DmTscd)grvTSCD.GetRow(grvTSCD.FocusedRowHandle);
                    Load_grv_BoPhan(obj_tscd.Id);
                    grvBoPhan.RefreshData();
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnCreate_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Create();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnModify_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Edit();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnDelete_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Delete();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmDieuChuyenTaiSan_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F3:
                        Create();
                        break;
                    case Keys.F4:
                        Edit();
                        break;
                    case Keys.F8:
                        Delete();
                        break;
                    case Keys.Escape:
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private DmTaikhoan GetTen_TK(Guid TAI_KHOAN_ID, IList<DmTaikhoan> dt)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan dr in dt)
            {
                if (dr.Id == TAI_KHOAN_ID)
                {
                    obj_tk.Id = dr.Id;
                    obj_tk.TenTaikhoan = dr.TenTaikhoan;
                    obj_tk.MaTaikhoan = dr.MaTaikhoan;
                }
            }
            return obj_tk;
        }

        private DmTaikhoan GetTen_TK(string MaTaikhoan, IList<DmTaikhoan> dt)
        {
            DmTaikhoan obj_tk = new DmTaikhoan();
            foreach (DmTaikhoan dr in dt)
            {
                if (dr.MaTaikhoan == MaTaikhoan)
                {
                    obj_tk.Id = dr.Id;
                    obj_tk.TenTaikhoan = dr.TenTaikhoan;
                    obj_tk.MaTaikhoan = dr.MaTaikhoan;
                }
            }
            return obj_tk;
        }

        private void grvBoPhan_CustomUnboundColumnData(System.Object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            try
            {
                //set, get gia tri cho unbound coloumn
                List<DmTaikhoan> dt = new List<DmTaikhoan>();
                dt.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));

                if ((_TsDieuchuyenService.GetObjectByTSCD_ID(obj_tscd.Id).Count != 0))
                {
                    DmTscd objtemp = (DmTscd)grvTSCD.GetRow(grvTSCD.FocusedRowHandle);
                    if (e.Column.FieldName == "TK_TS" & e.IsGetData)
                    {
                        e.Value = GetTen_TK(objtemp.MdTkTs, dt).MaTaikhoan;
                    }
                    if (e.Column.FieldName == "TK_KH" & e.IsGetData)
                    {
                        e.Value = GetTen_TK(objtemp.MdTkKhauhao, dt).MaTaikhoan;
                    }
                    if (e.Column.FieldName == "TK_CP" & e.IsGetData)
                    {
                        e.Value = GetTen_TK(objtemp.MdTkChiphi, dt).MaTaikhoan;
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnClose_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        #endregion

    }
}