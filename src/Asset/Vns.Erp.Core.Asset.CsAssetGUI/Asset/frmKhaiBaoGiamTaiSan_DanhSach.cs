using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Accounting.Service.Interface;
//using Vns.Erp.Core.Common.Controls;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmKhaiBaoGiamTaiSan_DanhSach
    {

        #region Property
        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }

        private ICtTscdService _CtTscdService;
        public ICtTscdService CtTscdService
        {
            get { return _CtTscdService; }
            set { _CtTscdService = value; }
        }

        private ICtHService _CtHService;
        public ICtHService CtHService
        {
            get { return _CtHService; }
            set { _CtHService = value; }
        }
        #endregion

        #region Variables

        private DmTscd obj_DM_TSCD;
        #endregion
        private string p_MA_LOAI_CT;

        #region Private functions

        private void AddEvents()
        {
            KeyDown += frmKhaiBaoGiamTaiSan_DanhSach_KeyDown;
            Load += frmKhaiBaoGiamTaiSan_DanhSach_Load;
            grv_TSCD.FocusedRowChanged += grv_TSCD_FocusedRowChanged;
            btnGiam.Click += btnCreate_Click;
            btnModify.Click += btnModify_Click;
            btnDelete.Click += btnDelete_Click;
            btnClose.Click += btnClose_Click;
        }

        public frmKhaiBaoGiamTaiSan_DanhSach()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        private void LoadGRV()
        {
            List<DmTscd> lstobj_DM_TSCD = new List<DmTscd>();
            lstobj_DM_TSCD = new List<DmTscd>();
            int ctemp = 0;
            lstobj_DM_TSCD.AddRange(_DmTscdService.GetObjectAllByDonviID(PagerControl1.PageIndex, PagerControl1.PageSize, Generals.DON_VI.Id, out ctemp ));
            PagerControl1.TotalResult = ctemp;

            grc_TSCD.DataSource = lstobj_DM_TSCD;

            string para_str = this.AccessibleDescription;
            List<ParamInfo> lst_para = DataMining.GetParams(para_str);
            if (lst_para.Count > 0)
            {
                //obj_loaichungtu.TEN_LOAI_CT = lst_para(1).PARAMVALUE
                p_MA_LOAI_CT = lst_para[0].PARAMVALUE;
            }
            PagerControl1.RefreshPage();
        }

        private void Create()
        {
            //Try
            if ((grv_TSCD.RowCount != 0))
            {
                obj_DM_TSCD = (DmTscd)grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle);
                if ((obj_DM_TSCD.GiamTscd != 1))
                {
                    int i = grv_TSCD.FocusedRowHandle;
                    frmKhaiBaoGiamTaiSan_ChiTiet frm = (frmKhaiBaoGiamTaiSan_ChiTiet)ObjectFactory.GetObject("frmKhaiBaoGiamTaiSan_ChiTiet");
                    if (frm.Show_Form(obj_DM_TSCD.Id, FormGlobals.DataInputState.AddMode, p_MA_LOAI_CT))
                    {
                        this.LoadGRV();
                        grv_TSCD.RefreshData();
                        grv_TSCD.FocusedRowHandle = i;
                        btnDelete.Enabled = true;
                        btnGiam.Enabled = false;
                        btnModify.Enabled = true;
                    }
                }
                else
                {
                    FormGlobals.Message_Information("Tài sản này đã được khai báo giảm");
                }
            }

            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        private void Edit()
        {
            //Try
            if ((grv_TSCD.RowCount != 0))
            {
                obj_DM_TSCD = (DmTscd)grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle);
                if ((obj_DM_TSCD.GiamTscd == 1))
                {
                    frmKhaiBaoGiamTaiSan_ChiTiet frm = (frmKhaiBaoGiamTaiSan_ChiTiet)ObjectFactory.GetObject("frmKhaiBaoGiamTaiSan_ChiTiet");
                    int i = grv_TSCD.FocusedRowHandle;
                    if ((frm.Show_Form(obj_DM_TSCD.Id, FormGlobals.DataInputState.EditMode, p_MA_LOAI_CT)))
                    {
                        this.LoadGRV();
                        grv_TSCD.RefreshData();
                        grv_TSCD.FocusedRowHandle = i;
                    }
                }
                else
                {
                    FormGlobals.Message_Information("Tài sản cố định đang ở trạng thái tăng");
                }
            }
            else
            {
                FormGlobals.Message_Information("Không có bản ghi nào");
            }
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        private void Delete()
        {
            //Try
            if ((grv_TSCD.RowCount != 0))
            {
                obj_DM_TSCD = (DmTscd)grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle);
                int i = grv_TSCD.FocusedRowHandle;
                if ((obj_DM_TSCD.GiamTscd == 1))
                {
                    if ((MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
                    {
                        //Update DM_TSCS(GIAM_TSCD=0)

                        DmTscd tmpDM = _DmTscdService.GetById(obj_DM_TSCD.Id);
                        tmpDM.GiamTscd = 0;
                        tmpDM.NgayGiam = null;
                        _DmTscdService.SaveOrUpdate(tmpDM);

                        CtTscd obj_del_ct_TSCD = _CtTscdService.GetByTRANG_THAI(obj_DM_TSCD.Id, 4);

                        //Xoa CT_TSCD
                        if ((obj_del_ct_TSCD != null))
                        {
                            _CtTscdService.DeleteById(obj_del_ct_TSCD.Id);
                        }

                        //Xoa CTH, CTD
                        if (!(obj_del_ct_TSCD.CthId == Null.NullGuid))
                        {
                            CtH tmpCth = new CtH();
                            tmpCth.Id = obj_del_ct_TSCD.CthId;
                            _CtHService.DeleteChungTuCTH(tmpCth, null, null);
                        }

                        this.LoadGRV();
                        grv_TSCD.FocusedRowHandle = i;

                        btnDelete.Enabled = false;
                        btnGiam.Enabled = true;
                        btnModify.Enabled = false;
                    }
                }
                else
                {
                    FormGlobals.Message_Warning("Tài sản này đang ở trạng thái tăng");
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

        private RepositoryItemLookUpEdit TANGGIAM_ColumnEdit()
        {
            RepositoryItemLookUpEdit result = new RepositoryItemLookUpEdit();
            DataTable dt = new DataTable();
            dt.Columns.Add("Text", typeof(string));
            dt.Columns.Add("Value", typeof(decimal));
            DataRow dr = null;

            dr = dt.NewRow();
            dr["Text"] = "Giảm";
            dr["Value"] = 1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Text"] = "Tăng";
            dr["Value"] = 0;
            dt.Rows.Add(dr);

            result.DisplayMember = "Text";
            result.ValueMember = "Value";
            result.DataSource = dt;

            return result;
        }

        #endregion

        #region "Events"

        private void frmKhaiBaoGiamTaiSan_DanhSach_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                LoadGRV();
                //PagerControl1.display = new DisplayResult(LoadGRV);
                //PagerControl1.display()
                grv_TSCD.Columns["GiamTscd"].ColumnEdit = TANGGIAM_ColumnEdit();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grv_TSCD_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                obj_DM_TSCD = (DmTscd)grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle);
                if ((obj_DM_TSCD.GiamTscd == 1))
                {
                    btnGiam.Enabled = false;
                    btnDelete.Enabled = true;
                    btnModify.Enabled = true;
                }
                else
                {
                    btnGiam.Enabled = true;
                    btnDelete.Enabled = false;
                    btnModify.Enabled = false;
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

        private void frmKhaiBaoGiamTaiSan_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
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