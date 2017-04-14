using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Views.Grid;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucLyDoTGTSCD_DanhSach : FrmBaseDmDanhSach
    {

        private IDmLydoTgTscdService _DmLydoTgTscdService;
        public IDmLydoTgTscdService DmLydoTgTscdService
        {
            get { return _DmLydoTgTscdService; }
            set { _DmLydoTgTscdService = value; }
        }
        public override void InitProperty()
        {
            //Tiêu d? form
            Title = "Danh mục lý do tăng giảm tài sản cố định";

            //Ki?u hi?n th? là TreeList ho?c GridView
            Viewer = _GridView;

            //Áp d?ng d?i v?i TreeList
            KeyName = "Id";
            //ParentKeyName = "DM_TUDO_2_ID_CHA";

            //Đ?i tu?ng BO tuong ?ng v?i form
            //BO = DmLydoTgTscdService

            //Định nghĩa các cột của lưới hiển thị
            ViewerColumnDefine = new ArrayList();
            ViewerColumnDefine.Add(new ColumnInfo("MaLydoTgTscd", "Mă lý do TG", 100, true, ""));
            ViewerColumnDefine.Add(new ColumnInfo("KyHieu", "Kí hiệu", 100, true, ""));
            ViewerColumnDefine.Add(new ColumnInfo("TenLydoTgTscd", "Tên lý do TG", 0, true, ""));
            ViewerColumnDefine.Add(new ColumnInfo("LoaiLg", "Loại", 0, true, ""));
            //ViewerColumnDefine.Add(New ColumnInfo("GIA_TRI", "Giá trị", 0, True, ""))
            ViewerColumnDefine.Add(new ColumnInfo("CoSuDung", "Có sử dụng", 80, true, ""));


            //Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
            SearchHelperColumnDefine = new ArrayList();
            SearchHelperColumnDefine.Add(new ColumnInfo("MaLydoTgTscd", "Mã", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("KyHieu", "Kí hiệu", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("True", "Tên lý do", 0, true, ""));


            //Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
            FieldChooserColumnDefine = new ArrayList();
            FieldChooserColumnDefine.Add(new ColumnInfo("Caption", "Tên trường", 0, true, ""));

            //----------------------------------------------
            ButtonCreate = btnCreate;
            ButtonModify = btnModify;
            ButtonDelete = btnDelete;
            //ButtonSearch = btnSearch
            //ButtonView = btnView
            //Pagger = _Pagger

            FieldChooser = _FieldChooser;
            SearchHelper = _SearchHelper;
        }
        public override void Loading()
        {
            //Try
            DataSource = DmLydoTgTscdService.GetAllByDonviID(Generals.DON_VI.Id);
            TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine);

            GridView obj = Viewer as GridView;
            obj.Columns["CoSuDung"].ColumnEdit = TNCommon.COSUDUNG_ColumnEdit();

            DataRow dr = null;
            DataTable dtLoaiTG = new DataTable();
            dtLoaiTG.Columns.Add("ID", typeof(string));
            dtLoaiTG.Columns.Add("Ten", typeof(string));
            dr = dtLoaiTG.NewRow();
            dr["ID"] = 1;
            dr["Ten"] = "Tăng TSCD";
            dtLoaiTG.Rows.Add(dr);
            dr = dtLoaiTG.NewRow();
            dr["ID"] = 2;
            dr["Ten"] = "Điều chỉnh tăng TSCD";
            dtLoaiTG.Rows.Add(dr);
            dr = dtLoaiTG.NewRow();
            dr["ID"] = 3;
            dr["Ten"] = "Điều chỉnh giảm TSCD";
            dtLoaiTG.Rows.Add(dr);
            dr = dtLoaiTG.NewRow();
            dr["ID"] = 4;
            dr["Ten"] = "Giảm TSCD";
            dtLoaiTG.Rows.Add(dr);

            dr = dtLoaiTG.NewRow();
            dr["ID"] = 5;
            dr["Ten"] = "Thay đổi thông tin";
            dtLoaiTG.Rows.Add(dr);

            obj.Columns["LoaiLg"].ColumnEdit = TNCommon.LookupEdit_ColumnEdit(dtLoaiTG, "Ten", "ID");

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, ((ColumnInfo)SearchHelperColumnDefine[0]).FieldName, KeyName, SearchHelperColumnDefine, true, false);
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, false, true);
            //Catch ex As Exception
            //    TNCommon.NotifyError(ex)
            //End Try
        }

        #region "Do not modify"

        private object _DataSource;
        public IList<DmLydoTgTscd> DataSource
        {
            get { return (IList<DmLydoTgTscd>)_DataSource; }
            set { _DataSource = value; }
        }

        public override void InitComponent()
        {
            InitializeComponent();
        }
        #endregion

        private void btnPri_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = (DataTable)DataSource;
                //Dim i_n As New frmInDanhMuc(data, "DM_LYDO_TG_TSCD")
                //i_n.ShowDialog()
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
                Close();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmDanhMucLyDoTGTSCD_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                InitComponent();
                InitProperty();
                CommonInit();
                //Me.InitSearchEvent()
                TNCommon.setIconControl(this);
                //Dim view As DataView = CType(DataSource, DataTable).DefaultView
                //view.Sort = "LoaiLg"
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        #region "Override"
        public override void DoCreate()
        {
            object obj = ShowFormChiTiet(FormGlobals.DataInputState.AddMode);
            if (obj != null)
            {
                //Dim NewObj As Object = DmLydoTgTscdService.GetById(obj)
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
                //Dim NewObj As Object = DmLydoTgTscdService.GetById(obj)
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
                DmLydoTgTscdService.DeleteById(VnsConvert.CGuid(KeyValue));
                AfterDeleteSuccess();
            }
            catch (System.Exception ex)
            {
                TNCommon.NotifyError(ex);
            }
        }
        public frmDanhMucLyDoTGTSCD_DanhSach()
        {
            Load += frmDanhMucLyDoTGTSCD_DanhSach_Load;
        }
        #endregion

    }
}