using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;

using Vns.Erp.Core;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDieuChinhGiaTriTaiSan_DanhSach
    {

        #region Property
        private ICtTscdService _CtTscdService;
        public ICtTscdService CtTscdService
        {
            get { return _CtTscdService; }
            set { _CtTscdService = value; }
        }
        private IDmTaikhoanService _DmTaikhoanService;
        public IDmTaikhoanService DmTaikhoanService
        {
            get { return _DmTaikhoanService; }
            set { _DmTaikhoanService = value; }
        }
        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }
        #endregion

        #region Variables
        private Guid CT_TSCD_ID;
        private Guid DM_TSCD_ID;
        #endregion
        CtTscd grv_con = new CtTscd();

        #region Private functions
        private void AddEvents()
        {
            KeyDown += frmDieuChinhGiaTriTaiSan_DanhSach_KeyDown;
            Load += frmDieuChinhGiaTriTaiSan_DanhSach_Load;
            grvDM_TSCD.FocusedRowChanged += grvDM_TSCD_FocusedRowChanged;
            grvCT_TSCD.FocusedRowChanged += grvCT_TSCD_FocusedRowChanged;
            btnAdd.Click += btnCreate_Click;
            btnModify.Click += btnModify_Click;
            btnDelete.Click += btnDelete_Click;
            btnClose.Click += btnClose_Click;
        }

        public frmDieuChinhGiaTriTaiSan_DanhSach()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }
        //load grv cha
        private void Load_DM_TSCD()
        {
            List<DmTaikhoan> dt_tk = new List<DmTaikhoan>();
            dt_tk.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id));

            List<DmTaikhoan> dt_tk_ts = dt_tk;

            cboMD_TK_TS.DataSource = dt_tk_ts;
            cboMD_TK_TS.ValueMember = "Id";
            cboMD_TK_TS.DisplayMember = "MaTaikhoan";

            IList<DmTaikhoan> dt_tk_cp = dt_tk;

            cboMD_TK_CHIPHI.DataSource = dt_tk_ts;
            cboMD_TK_CHIPHI.ValueMember = "Id";
            cboMD_TK_CHIPHI.DisplayMember = "MaTaikhoan";

            IList<DmTaikhoan> dt_tk_kh = dt_tk;

            cboMD_TK_KHAUHAO.DataSource = dt_tk_kh;
            cboMD_TK_KHAUHAO.ValueMember = "Id";
            cboMD_TK_KHAUHAO.DisplayMember = "MaTaikhoan";

            List<DmTscd> lst_DM_TSCD = new List<DmTscd>();
            int TotalResult = 0;
            lst_DM_TSCD.AddRange(_DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, out TotalResult));
            grcDM_TSCD.DataSource = lst_DM_TSCD;
        }

        //load grv con
        private void Load_CT_TSCD(Guid DM_TSCD_ID)
        {
            List<CtTscd> lst_CT_TSCD = new List<CtTscd>();
            lst_CT_TSCD.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(DM_TSCD_ID));
            grc_CT_TSCD.DataSource = lst_CT_TSCD;
            grvCT_TSCD.Columns["TangTscd"].ColumnEdit = TANGGIAM_ColumnEdit();
        }

        private void frmDieuChinhGiaTriTaiSan_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            Load_DM_TSCD();

        }
        //chuyen so thang text tren grid
        private RepositoryItemLookUpEdit TANGGIAM_ColumnEdit()
        {
            RepositoryItemLookUpEdit result = new RepositoryItemLookUpEdit();
            DataTable dt = new DataTable();
            dt.Columns.Add("Text", typeof(string));
            dt.Columns.Add("Value", typeof(decimal));
            DataRow dr = null;

            dr = dt.NewRow();
            dr["Text"] = "Giảm";
            dr["Value"] = 4;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Text"] = "Tăng";
            dr["Value"] = 1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Text"] = "Điều chỉnh tăng TSCĐ";
            dr["Value"] = 2;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Text"] = "Điều chỉnh giảm TSCĐ";
            dr["Value"] = 3;
            dt.Rows.Add(dr);

            result.DisplayMember = "Text";
            result.ValueMember = "Value";
            result.DataSource = dt;

            return result;


        }

        private void Create()
        {
            //Try
            if ((grvCT_TSCD.RowCount == 0))
            {
                FormGlobals.Message_Warning("Không có phần tử nào");
                return;
            }

            frmDieuChinhGiaTriTaiSan_ChiTiet frm = (frmDieuChinhGiaTriTaiSan_ChiTiet)ObjectFactory.GetObject("frmDieuChinhGiaTriTaiSan_ChiTiet");
            if ((frm.Show_Form(Null.NullGuid, DM_TSCD_ID, FormGlobals.DataInputState.AddMode)))
            {
                this.Load_CT_TSCD(DM_TSCD_ID);
                grvCT_TSCD.FocusedRowHandle = grvCT_TSCD.RowCount - 1;
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        private void Edit()
        {
            //Try
            if ((grvCT_TSCD.RowCount != 0))
            {
                grv_con = (CtTscd)grvCT_TSCD.GetRow(grvCT_TSCD.FocusedRowHandle);
                if ((grv_con.ThuTu == grvCT_TSCD.RowCount & grv_con.TangTscd != 1 & grv_con.TangTscd != 4))
                {
                    int i = grvDM_TSCD.FocusedRowHandle;
                    frmDieuChinhGiaTriTaiSan_ChiTiet frm = (frmDieuChinhGiaTriTaiSan_ChiTiet)ObjectFactory.GetObject("frmDieuChinhGiaTriTaiSan_ChiTiet");
                    if ((frm.Show_Form(CT_TSCD_ID, DM_TSCD_ID, FormGlobals.DataInputState.EditMode)))
                    {
                        this.Load_DM_TSCD();
                        this.Load_CT_TSCD(DM_TSCD_ID);
                        grvDM_TSCD.FocusedRowHandle = i;
                        grvCT_TSCD.FocusedRowHandle = grvCT_TSCD.RowCount - 1;
                    }
                }
                else
                {
                    FormGlobals.Message_Warning("Bạn không được sửa bản ghi này");
                }
            }
            else
            {
                FormGlobals.Message_Warning("Không có bản ghi nào");
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        private void Delete()
        {
            //Try
            if ((grvCT_TSCD.RowCount == 0))
            {
                FormGlobals.Message_Warning("Không có bản ghi nào");
                return;
            }
            btnDelete.Enabled = true;
            CtTscd gridCT = (CtTscd)grvCT_TSCD.GetRow(grvCT_TSCD.FocusedRowHandle);
            if ((gridCT.TangTscd == 1 | gridCT.TangTscd == 4 | gridCT.ThuTu < grvCT_TSCD.RowCount))
            {
                FormGlobals.Message_Warning("Bạn không được xóa bản ghi này");
            }
            else
            {
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
                {
                    _CtTscdService.Delete(gridCT);
                    Load_CT_TSCD(DM_TSCD_ID);
                }
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
            //End If
        }
        #endregion

        #region Events

        private void grvDM_TSCD_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if ((grvDM_TSCD.RowCount != 0))
                {
                    DmTscd grv_DM_TSCD = (DmTscd)grvDM_TSCD.GetRow(grvDM_TSCD.FocusedRowHandle);
                    if (grv_DM_TSCD != null)
                    {
                        Load_CT_TSCD(grv_DM_TSCD.Id);
                        DM_TSCD_ID = grv_DM_TSCD.Id;
                        List<CtTscd> lst = new List<CtTscd>();
                        lst.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(DM_TSCD_ID));
                        foreach (CtTscd obj in lst)
                        {
                            if ((obj.TangTscd == 4))
                            {
                                btnAdd.Enabled = false;
                                btnModify.Enabled = false;
                                btnDelete.Enabled = false;
                                break; // TODO: might not be correct. Was : Exit For
                            }
                            else
                            {
                                btnAdd.Enabled = true;
                                btnModify.Enabled = true;
                                btnDelete.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvCT_TSCD_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if ((grvCT_TSCD.RowCount != 0))
                {
                    CtTscd grv_CT_TSCD = (CtTscd)grvCT_TSCD.GetRow(grvCT_TSCD.FocusedRowHandle);
                    if (grv_CT_TSCD != null)
                    {
                        CT_TSCD_ID = grv_CT_TSCD.Id;
                        IList<CtTscd> lst_obj_DM_TSCD_DC = _CtTscdService.GetObjectByIdDM_TSCD_DC(grv_CT_TSCD.TscdId);
                        int thu_tu = lst_obj_DM_TSCD_DC.Count;
                    }
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

        private void frmDieuChinhGiaTriTaiSan_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break; // TODO: might not be correct. Was : Exit Select


                        break;
                    case Keys.F3:
                        Create();
                        break; // TODO: might not be correct. Was : Exit Select


                        break;
                    case Keys.F4:
                        Edit();
                        break; // TODO: might not be correct. Was : Exit Select


                        break;
                    case Keys.F8:
                        Delete();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
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