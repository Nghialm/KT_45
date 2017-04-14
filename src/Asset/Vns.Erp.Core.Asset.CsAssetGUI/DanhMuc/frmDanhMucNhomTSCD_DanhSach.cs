using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

using Vns.Erp.Core;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucNhomTSCD_DanhSach : FrmBaseDmDanhSach
    {

        #region "Variables and properties"


        IDmNhomTscdService _DmNhomTscdService;
        public IDmNhomTscdService DmNhomTscdService
        {
            get { return _DmNhomTscdService; }
            set { _DmNhomTscdService = value; }
        }

        private string DM_NHOM_TSCD_ID;

        private IList<DmNhomTscd> lstobj_dm_NTSCD;
        frmDanhMucNhomTSCD_ChiTiet _FormChiTiet;
        public frmDanhMucNhomTSCD_ChiTiet FormChiTiet
        {
            get { return _FormChiTiet; }
            set { _FormChiTiet = value; }
        }
        #endregion

        #region "Functions"
        private void BindataCBO()
        {
            IList<DmNhomTscd> dt_NHOM = DmNhomTscdService.GetAllByDonviID(Generals.DON_VI.Id);
            //'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
            ArrayList SearchHelperColumnDefine = new ArrayList();
            SearchHelperColumnDefine.Add(new ColumnInfo("MaNhomTscd", "Tên nhóm TS", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("TenNhomTscd", "Mã nhóm TS", 0, true, ""));
            TNCommon.BindData_GridLookUp(_SearchHelper, dt_NHOM, "MaNhomTscd", "Id", SearchHelperColumnDefine, true);

            ArrayList arr = new ArrayList();
            arr.Add(new ColumnInfo("Display", "Tìm kiếm theo", 0, true, ""));
            DataTable tbl_TK = new DataTable();
            tbl_TK.Columns.Add("Value");
            tbl_TK.Columns.Add("Display");

            tbl_TK.Rows.Add("MaNhomTscd", "Mã nhóm tài sản");
            tbl_TK.Rows.Add("TenNhomTscd", "Tên nhóm tài sản");

            TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, true);

        }

        private void Load_Grid()
        {
            lstobj_dm_NTSCD = DmNhomTscdService.GetAllByDonviID(Generals.DON_VI.Id);
            _GridControl.DataSource = lstobj_dm_NTSCD;
        }

        private bool GetRowSelect()
        {
            int selrow = 0;
            if ((_GridView.GetSelectedRows().Length > 0))
            {
                if ((_GridView.RowCount != 0))
                {
                    DM_NHOM_TSCD_ID = FormGlobals.Grid_GetDataRowItemString(_GridView, "Id");
                    IList<DmNhomTscd> listDmNhomTscd = _GridView.DataSource as IList<DmNhomTscd>;
                    DM_NHOM_TSCD_ID = listDmNhomTscd[_GridView.FocusedRowHandle].Id.ToString();
                    return true;
                }
            }
            return false;
        }

        private void AddNew()
        {
            frmDanhMucNhomTSCD_ChiTiet f = FormChiTiet;
            DmNhomTscd obj = f.Show_Form(null, FormGlobals.DataInputState.AddMode);
            if (obj != null)
            {
                this.Load_Grid();
                TNCommon.GridView_SetRowFocus(_GridView, "Id", obj.Id);
            }
        }

        private void Edit()
        {
            if (_GridView.FocusedRowHandle < 0)
            {
                FormGlobals.Message_Warning("Chưa chọn bản ghi");
                return;
            }
            if ((GetRowSelect()))
            {
                frmDanhMucNhomTSCD_ChiTiet f = FormChiTiet;
                DmNhomTscd obj = f.Show_Form(DM_NHOM_TSCD_ID, FormGlobals.DataInputState.EditMode);
                if (obj != null)
                {
                    this.Load_Grid();
                    TNCommon.GridView_SetRowFocus(_GridView, "Id", obj.Id);
                }
            }
            else
            {
                FormGlobals.Message_Information("Không có bản ghi nào");
            }

        }

        private void Delete()
        {
            if (_GridView.FocusedRowHandle < 0)
            {
                FormGlobals.Message_Warning("Chưa chọn bản ghi");
                return;
            }
            if ((GetRowSelect()))
            {
                if (!(FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa?")))
                    return;
                DmNhomTscdService.DeleteById(new Guid(DM_NHOM_TSCD_ID));
                this.Load_Grid();
            }
        }

        private void SetKeyValue(object value)
        {
            if (value == null)
            {
                return;
            }
            TNCommon.GridView_SetRowFocus(_GridView, "Id", value);
        }
        #endregion

        #region "Events"

        private void frmDanhMucNhomTSCD_DanhSach_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                TNCommon.setIconControl(this);
                Load_Grid();
                BindataCBO();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }


        private void frmDanhMucNhomKhachHang_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break; // TODO: might not be correct. Was : Exit Select

                    case Keys.F3:
                        AddNew();
                        break; // TODO: might not be correct. Was : Exit Select

                    case Keys.F4:
                        Edit();
                        break; // TODO: might not be correct. Was : Exit Select

                    case Keys.F8:
                        Delete();
                        break; // TODO: might not be correct. Was : Exit Select

                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }


        private void _FieldChooser_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Globals.DB_GetString(_FieldChooser.EditValue)))
                {
                    _SearchHelper.Properties.DisplayMember = _FieldChooser.EditValue.ToString();
                    _SearchHelper.Focus();
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void _SearchHelper_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Globals.DB_GetString(_SearchHelper.EditValue)))
                {
                    SetKeyValue(_SearchHelper.EditValue);
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        public frmDanhMucNhomTSCD_DanhSach()
        {
            InitializeComponent();
            KeyDown += frmDanhMucNhomKhachHang_DanhSach_KeyDown;
            Load += frmDanhMucNhomTSCD_DanhSach_DanhSach_Load;
        }
        #endregion

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                AddNew();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnModify_Click_1(object sender, EventArgs e)
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

        private void btnDelete_Click_1(object sender, EventArgs e)
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

        private void btnClose_Click_1(object sender, EventArgs e)
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

        private void btExport_Load(object sender, EventArgs e)
        {

        }

        private void btnPri_Click(object sender, EventArgs e)
        {

        }

    }
}