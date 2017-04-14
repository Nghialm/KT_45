using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

using System.Windows.Forms;

using Vns.Erp.Core;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucNguonVon_tscd_DanhSach : FrmBaseDmDanhSach
    {

        #region "Varibales"

        private frmDanhMucNguonVon_tscd_ChiTiet FormChiTiet;
        //Public Property FormChiTiet() As frmDanhMucNguonVon_tscd_ChiTiet
        //    Get
        //        Return _FormChiTiet
        //    End Get
        //    Set(ByVal value As frmDanhMucNguonVon_tscd_ChiTiet)
        //        _FormChiTiet = value
        //    End Set
        //End Property

        Guid DMNVTSCD;
        IDmNguonTscdService _DmNguonTscdService;
        public IDmNguonTscdService DmNguonTscdService
        {
            get { return _DmNguonTscdService; }
            set { _DmNguonTscdService = value; }
        }
        #endregion

        #region "Overrides Functions and Property"
        //Private lstobj_nvtscd As List(Of DmNguonTscd) = New List(Of DmNguonTscd)

        private IList<DmNguonTscd> _DataSource;
        public IList<DmNguonTscd> DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }

        public override void InitComponent()
        {
        }
        public override void InitProperty()
        {
            Title = "Danh mục nguồn vốn TSCD";
            Viewer = _GridView;
            KeyName = "Id";

            ArrayList SearchHelperColumnDefine = new ArrayList();
            SearchHelperColumnDefine.Add(new ColumnInfo("MaDmNguonTscd", "Mã nguồn", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("TenDmNguonTscd", "Tên nguồn", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("KyHieu", "Ký hiệu nguồn", 0, true, ""));

            ArrayList arr = new ArrayList();
            arr.Add(new ColumnInfo("Display", "Tìm kiếm theo", 0, true, ""));
            DataTable tbl_TK = new DataTable();
            tbl_TK.Columns.Add("Value");
            tbl_TK.Columns.Add("Display");

            tbl_TK.Rows.Add("TenDmNguonTscd", "Mã nguồn");
            tbl_TK.Rows.Add("TenDmNguonTscd", "Tên nguồn");
            tbl_TK.Rows.Add("KyHieu", "Ký hiệu");
            TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, true);


            //----------------------------------------------
            ButtonCreate = btnCreate;
            ButtonModify = btnModify;
            ButtonDelete = btnDelete;

            FieldChooser = _FieldChooser;
            SearchHelper = _SearchHelper;
        }
        public override void Loading()
        {
            IList<DmNguonTscd> dt_NHOM = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id);
            TNCommon.BindData_GridLookUp(_SearchHelper, dt_NHOM, "MaDmNguonTscd", "MaDmNguonTscd", SearchHelperColumnDefine, true);
            LoadGrid();
        }
        #endregion

        #region "Functions"
        public frmDanhMucNguonVon_tscd_DanhSach()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }

        private void Grid_SetFocus(string _Key)
        {
            List<DmNguonTscd> lst = (List<DmNguonTscd>)_GridView.DataSource;
            for (int i = 0; i <= lst.Count - 1; i++)
            {
                if (lst[i].Id == VnsConvert.CGuid(_Key))
                {
                    _GridView.FocusedRowHandle = i;
                }
            }
        }

        private void BindataCBO()
        {
            IList<DmNguonTscd> dt_NHOM = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id);
            //'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
            ArrayList SearchHelperColumnDefine = new ArrayList();
            SearchHelperColumnDefine.Add(new ColumnInfo("MaDmNguonTscd", "Mã nguồn", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("TenDmNguonTscd", "Tên nguồn", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("KyHieu", "Ký hiệu nguồn", 0, true, ""));
            TNCommon.BindData_GridLookUp(_SearchHelper, dt_NHOM, "MaDmNguonTscd", "MaDmNguonTscd", SearchHelperColumnDefine, true);

            ArrayList arr = new ArrayList();
            arr.Add(new ColumnInfo("Display", "Tìm kiếm theo", 0, true, ""));
            DataTable tbl_TK = new DataTable();
            tbl_TK.Columns.Add("Value");
            tbl_TK.Columns.Add("Display");

            tbl_TK.Rows.Add("TenDmNguonTscd", "Mã nguồn");
            tbl_TK.Rows.Add("TenDmNguonTscd", "Tên nguồn");
            tbl_TK.Rows.Add("KyHieu", "Ký hiệu");
            TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, true);

        }

        private void LoadGrid()
        {
            //Dim lstNguonVonTSCD As List(Of DmNguonTscd) = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id)
            this.DataSource = DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id);
            _GridControl.DataSource = DataSource;
            _GridView.Columns["ChoPhepSua"].ColumnEdit = TNCommon.COSUDUNG_ColumnEdit();
            _GridView.Columns["CoSuDung"].ColumnEdit = TNCommon.COSUDUNG_ColumnEdit();
        }

        private void LoadGRV(string DM_NGUON_TSCD_ID)
        {
            //Dim lstobjdmnv_tscd As List(Of DmNguonTscd) = DmNguonTscdService.GetAllByDonviID(New Guid(DM_NGUON_TSCD_ID))
            this.DataSource = DmNguonTscdService.GetAllByDonviID(new Guid(DM_NGUON_TSCD_ID));
            _GridControl.DataSource = DataSource;
        }

        private bool GetRowSelect()
        {
            int selrow = 0;
            if ((_GridView.GetSelectedRows().Length > 0))
            {
                if ((_GridView.RowCount != 0))
                {
                    DmNguonTscd griNV = (DmNguonTscd)_GridView.GetRow(_GridView.GetSelectedRows()[0]);
                    DMNVTSCD = griNV.Id;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region "Events"

        //Private Sub frmDanhMucNguonVon_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        //    Try
        //        InitComponent()
        //        InitProperty()
        //        CommonInit()
        //        'An nut in
        //        btnPri.Visible = False
        //    Catch ex As Exception
        //        Message_Error(ex)
        //    End Try
        //End Sub

        private void _GridView_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if ((_GridView.RowCount != 0))
                {
                    DmNguonTscd gridcth = (DmNguonTscd)_GridView.GetRow(_GridView.FocusedRowHandle);
                    if ((gridcth != null))
                    {
                        DMNVTSCD = gridcth.Id;
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
                    Grid_SetFocus(_SearchHelper.EditValue.ToString());
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

        }

        #endregion

        #region "Override"
        public override void DoCreate()
        {
            object obj = ShowFormChiTiet(FormGlobals.DataInputState.AddMode);
            if (obj != null)
            {
                //Dim NewObj As Object = DmNguonTscdService.GetById(obj)
                DoRefressData(FormGlobals.DataInputState.AddMode, null, obj);
                this.KeyValue = obj;
            }
        }

        public override void DoModify()
        {
            if (this.KeyValue == null)
            {
                NotifyNoSelectRecord();
                return;
            }
            object OldObj = GetObjectValue();
            object obj = ShowFormChiTiet(FormGlobals.DataInputState.EditMode);
            if (obj != null)
            {
                //Dim NewObj As Object = DmNguonTscdService.GetById(obj)
                DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, obj);
                this.KeyValue = obj;
            }
        }

        public override void DoRefressData(FormGlobals.DataInputState _mode, object OldObj, object NewObj)
        {
            frmProgress.Instance().Thread = this.Loading;
            frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE);
            //Select Case _mode
            //    Case DataInputState.AddMode
            //        'DataSource.Add(NewObj)
            //    Case DataInputState.EditMode
            //        DataSource.Remove(OldObj)
            //        DataSource.Add(NewObj)
            //    Case DataInputState.Delete
            //        DataSource.Remove(OldObj)
            //End Select
            TNCommon.BindData4Refresh(Viewer, DataSource);
        }
        public override void Deleting()
        {
            try
            {
                DmNguonTscdService.DeleteById(VnsConvert.CGuid(KeyValue));
                AfterDeleteSuccess();
            }
            catch (System.Exception ex)
            {
                TNCommon.NotifyError(ex);
            }
        }
        #endregion

    }
}