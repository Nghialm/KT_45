using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraGrid;
using System.Windows.Forms;

using Vns.Erp.Core;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucLoaiTaiSan1_DanhSach
    {
        IDmLoaitaisanService _DmLoaiTaisanService;
        public virtual IDmLoaitaisanService DmLoaiTaisanService
        {
            get { return _DmLoaiTaisanService; }
            set { _DmLoaiTaisanService = value; }
        }

        frmDanhMucLoaiTaiSan1_ChiTiet _frmDanhMucLoaiTaiSan1_ChiTiet;
        public virtual frmDanhMucLoaiTaiSan1_ChiTiet FormChitiet
        {
            get { return _frmDanhMucLoaiTaiSan1_ChiTiet; }
            set { _frmDanhMucLoaiTaiSan1_ChiTiet = value; }
        }
        #region "Variables and Messages"
        private int DELAY_MESSAGE = 300;
        #endregion
        private IList<DmLoaitaisan> DataSource;

        #region "Load Form"
        public frmDanhMucLoaiTaiSan1_DanhSach()
        {
            InitializeComponent();
            KeyDown += frmDanhMucLoaiTaiSan1_DanhSach_KeyDown;
            Load += frmDanhMucLoaiTaiSan1_DanhSach_Load;
            TNCommon.setIconControl(this);
        }

        #endregion

        #region "Private Function"

        private void LoadDanhSach()
        {
            FormGlobals.Form_SetText(this, "Danh mục loại tài sản", FormGlobals.DataInputState.NoCaption);

            DataSource = DmLoaiTaisanService.GetAll();
            ArrayList ViewerColumnDefine = new ArrayList();
            ViewerColumnDefine.Add(new ColumnInfo("KyHieu", "Kí hiệu", 0, true, ""));
            ViewerColumnDefine.Add(new ColumnInfo("TenLoaitaisan", "Tên", 0, true, ""));
            ViewerColumnDefine.Add(new ColumnInfo("KhungTgsd", "Số năm sử dụng ", 0, true, ""));
            ViewerColumnDefine.Add(new ColumnInfo("CoSuDung", "Có sử dụng", 80, true, ""));
            TNCommon.BindData_TreeList(_TreeList, DataSource, "Id", "LoaitaisanIdCha", ViewerColumnDefine, true);

            _TreeList.DataSource = DataSource;
            _TreeList.Columns["CoSuDung"].ColumnEdit = TNCommon.COSUDUNG_ColumnEdit();
            ArrayList SearchHelperColumnDefine = new ArrayList();
            SearchHelperColumnDefine.Add(new ColumnInfo("MaLoaitaisan", "Mã loại tài sản", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("KYHieu", "Kí hiệu", 0, true, ""));
            SearchHelperColumnDefine.Add(new ColumnInfo("TenLoaitaisan", "Tên loại tài sản", 0, true, ""));

            ArrayList FieldChooserColumnDefine = new ArrayList();
            FieldChooserColumnDefine.Add(new ColumnInfo("Caption", "Tên trường", 20, true, ""));

            TNCommon.BindData_GridLookUp(_SearchHelper, DataSource, ((ColumnInfo)SearchHelperColumnDefine[0]).FieldName, "Id", SearchHelperColumnDefine, true, false);
            TNCommon.BindData_GridLookUp(_FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, false, true);
            //SetFormat()
        }

        private void SetKeyValue(object value)
        {
            if (value == null)
            {
                return;
            }

            TNCommon.TreeList_SetNodeFocus(_TreeList, value);
        }

        private object GetKeyValue()
        {
            object _Value = null;
            _Value = TNCommon.TreeList_FocusKeyValue(_TreeList);
            return _Value;
        }

        private void Deleting()
        {
            try
            {
                DmLoaiTaisanService.DeleteById(VnsConvert.CGuid(GetKeyValue()));
                AfterDeleteSuccess();
            }
            catch (System.Exception ex)
            {
                TNCommon.NotifyError(ex);
            }
        }

        private void AfterDeleteSuccess()
        {
            frmProgress.Instance().SetFinishText(GeneralString.DELETE_SUCCESSFUL, DELAY_MESSAGE);
        }

        private void DoModify()
        {
            string eID = GetKeyValue().ToString();
            //Try
            frmDanhMucLoaiTaiSan1_ChiTiet f = FormChitiet;
            Guid ID = f.Show_Form(eID, FormGlobals.DataInputState.EditMode);
            if ((f.ID != Guid.Empty))
            {
                DoRefressData();
                SetKeyValue(ID);
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        public void DoRefressData()
        {
            frmProgress.Instance().Thread = this.LoadDanhSach;
            frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE);
        }

        private void DoCreate()
        {
            //Try
            frmDanhMucLoaiTaiSan1_ChiTiet f = FormChitiet;
            Guid ID = f.Show_Form(null, FormGlobals.DataInputState.AddMode);
            DoRefressData();
            SetKeyValue(ID);
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        //Private Sub DoDelete()
        //    'Try
        //    If GetKeyValue() Is Nothing Then
        //        NotifyNoSelectRecord()
        //        Return
        //    End If
        //    If (Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?")) Then
        //        frmProgress.Instance().Thread = AddressOf Me.Deleting
        //        'frmProgress.Instance().Show_Progress("Đang xóa...")
        //        frmProgress.Instance().SetFinishText(GeneralString.DELETE_SUCCESSFUL, DELAY_MESSAGE)
        //        LoadDanhSach()
        //    End If
        //    'Catch ex As System.Exception
        //    '    TNCommon.NotifyError(ex)
        //    'End Try
        //End Sub

        #endregion

        #region "Events"
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            try
            {
                DoModify();
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
                if (_FieldChooser.EditValue != null)
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
                if (_SearchHelper.EditValue != null)
                {
                    SetKeyValue(_SearchHelper.EditValue);
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                DoCreate();
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

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = (DataTable)DataSource;
                //Dim i_n As New frmInDanhMuc(data, "DM_TUDO1")
                //i_n.ShowDialog()
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }


        private void frmDanhMucLoaiTaiSan1_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                LoadDanhSach();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void frmDanhMucLoaiTaiSan1_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                    case Keys.F4:
                        DoCreate();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                    case Keys.F3:
                        DoModify();
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                    case Keys.F8:
                        if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?"))
                        {
                            Deleting();
                            LoadDanhSach();
                        }
                        break; // TODO: might not be correct. Was : Exit Select

                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        #endregion

        #region "Notify"
        public bool ConfirmDelete()
        {
            return (DialogResult.Yes == MessageBox.Show(GeneralString.CONFIRM_DELETE_MESSAGE, GeneralString.CONFIRM_DELETE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
        }
        public void NotifyNoSelectRecord()
        {
            MessageBox.Show(GeneralString.NOTIFY_NO_SELECT_RECORD_MESSAGE, GeneralString.NOTIFY_NO_SELECT_RECORD_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?"))
                {
                    Deleting();
                    // DoDelete()

                    LoadDanhSach();
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btExport_Load(object sender, EventArgs e)
        {

        }





    }
}