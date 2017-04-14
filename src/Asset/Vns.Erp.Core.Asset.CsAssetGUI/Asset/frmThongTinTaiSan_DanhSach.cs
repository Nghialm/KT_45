using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmThongTinTaiSan_DanhSach
    {

        #region Property
        private IDmLoaitaisanService _DmLoaitaisanService;
        public IDmLoaitaisanService DmLoaitaisanService
        {
            get { return _DmLoaitaisanService; }
            set { _DmLoaitaisanService = value; }
        }
        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }
        #endregion

        #region Variables

        Guid DM_TSCD_ID;
        #endregion
        DmTscd TSCD_new;

        #region Private functions

        private void AddEvents()
        {
            grvTSCD.FocusedRowChanged += grvTSCD_FocusedRowChanged;
            btnDelete.Click += btnDelete_Click;
            this.Load += frmThongTinTaiSan_Load;
            btnAdd.Click += btnCreate_Click;
            btnModify.Click += btnModify_Click;
            this.KeyDown += frmThongTinTaiSan_DanhSach_KeyDown;
            btnClose.Click += btnClose_Click;
            btnPrint.Click += btnIn_Click;
            btnSearch.Click += btnSearch_Click;
            grlLoaiTSCD.EditValueChanged += grlLoaiTSCD_EditValueChanged;
            btnXem.Click += btnXem_Click;
        }

        public frmThongTinTaiSan_DanhSach()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        private void BindData()
        {
            Guid DON_VI_ID = Generals.DON_VI.Id;
            ArrayList objColumnDefine = null;

            //Dim dt_DM_LoaiTS As DataTable = DM_LoaitaisanBO.Instance.GetAll.Tables(0)
            List<DmLoaitaisan> dt_DM_LoaiTS = new List<DmLoaitaisan>();

            dt_DM_LoaiTS.AddRange(_DmLoaitaisanService.GetAllSortByKyHieu());

            DmLoaitaisan dr = new DmLoaitaisan();
            dr.KyHieu = "";
            dr.Id = Null.NullGuid;
            dr.TenLoaitaisan = "<Không xác định>";
            dt_DM_LoaiTS.Insert(0, dr);

            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenLoaitaisan", "Tên loại tài sản"));
            FormGlobals.GridLookupEdit_BindData(grlLoaiTSCD, dt_DM_LoaiTS, "KyHieu", "Id", FormGlobals.COMBO_ITEM_BLANK, "TenLoaitaisan", txttenLoaiTS, objColumnDefine);
        }

        //bind data vao grid
        private void Load_GRV_TSCD()
        {
            IList<DmTscd> lst_TSCD = new List<DmTscd>();
            lst_TSCD = _DmTscdService.GetbyParameter((DateTime)dteTuNgay.DateTime, (DateTime)dteDenNgay.DateTime, txtTenTS.Text, VnsConvert.CGuid(grlLoaiTSCD.EditValue), Generals.DON_VI.Id);
            grcTSCD.DataSource = lst_TSCD;
            //grvTSCD.BestFitColumns()
        }

        private void Create()
        {
            frmThongTinTSCD_ChiTiet frm = (frmThongTinTSCD_ChiTiet)ObjectFactory.GetObject("frmThongTinTSCD_ChiTiet");
            TSCD_new = frm.Show_Form(Null.NullGuid, FormGlobals.DataInputState.AddMode);
            if (TSCD_new != null)
            {
                this.Load_GRV_TSCD();
                grv_focus();
            }
        }

        private void Edit()
        {
            if (grvTSCD.RowCount != 0)
            {
                int i = grvTSCD.FocusedRowHandle;
                //DM_TSCD_ID = Grid_GetDataRowItemString(grvTSCD, "Id")
                DM_TSCD_ID = ((DmTscd)grvTSCD.GetRow(i)).Id;

                if ((FormGlobals.Grid_GetDataRowItemInteger(grvTSCD, "GIAM_TSCD") == 1))
                {
                    FormGlobals.Message_Information("Tài sản đã khai báo giảm");
                    return;
                }

                frmThongTinTSCD_ChiTiet frm = (frmThongTinTSCD_ChiTiet)ObjectFactory.GetObject("frmThongTinTSCD_ChiTiet");
                TSCD_new = frm.Show_Form(DM_TSCD_ID, FormGlobals.DataInputState.EditMode);
                if (TSCD_new != null)
                {
                    this.Load_GRV_TSCD();
                    //grv_focus()
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete()
        {
            if (grvTSCD.RowCount != 0)
            {
                int i = grvTSCD.FocusedRowHandle;
                //DM_TSCD_ID = Grid_GetDataRowItemString(grvTSCD, "Id")
                DM_TSCD_ID = ((DmTscd)grvTSCD.GetRow(i)).Id;

                if ((FormGlobals.Grid_GetDataRowItemInteger(grvTSCD, "GIAM_TSCD") == 1))
                {
                    FormGlobals.Message_Information("Tài sản đã khai báo giảm");
                    return;
                }
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
                {
                    DmTscdService.DeleteTscd(DM_TSCD_ID);
                    this.Load_GRV_TSCD();
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void grv_focus()
        {
            //TNCommon.GridControl_SetRowFocus(grcTSCD, "MaTscd", TSCD_new.MaTscd)
        }
        #endregion

        #region "Events"

        private void frmThongTinTaiSan_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                //btnPrint.Visible = False

                BindData();
                System.DateTime F_ngay = System.DateTime.Now.Date;
                System.DateTime S_ngay = new System.DateTime(F_ngay.Year, 1, 1);
                dteTuNgay.DateTime = S_ngay;
                dteDenNgay.DateTime = F_ngay;
                Load_GRV_TSCD();
                grvTSCD.FixedLineWidth = 0;
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



        private void frmThongTinTaiSan_DanhSach_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void btnIn_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                In_The_TSCD frm = (In_The_TSCD) ObjectFactory.GetObject("In_The_TSCD", new object[] {
				dteTuNgay.DateTime,
				dteDenNgay.DateTime,
				txtTenTS.Text,
				grlLoaiTSCD.EditValue,
				Generals.DON_VI.Id
			});
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnSearch_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                frmProgress.Instance().Thread = Load_GRV_TSCD;
                frmProgress.Instance().Show_Progress();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grlLoaiTSCD_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                DmLoaitaisan dr = (DmLoaitaisan)ComboHelper.GetSelectData(grlLoaiTSCD);
                if (dr != null)
                {
                    txttenLoaiTS.Text = dr.TenLoaitaisan;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
        #endregion

        private void btnXem_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (grvTSCD.RowCount != 0)
                {
                    int i = grvTSCD.FocusedRowHandle;
                    //DM_TSCD_ID = Grid_GetDataRowItemString(grvTSCD, "Id")
                    DM_TSCD_ID = ((DmTscd)grvTSCD.GetRow(i)).Id;

                    frmThongTinTSCD_ChiTiet frm = new frmThongTinTSCD_ChiTiet();
                    TSCD_new = frm.Show_Form(DM_TSCD_ID, FormGlobals.DataInputState.ViewMode);
                    if (TSCD_new != null)
                    {
                        this.Load_GRV_TSCD();
                        grv_focus();
                    }
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvTSCD_FocusedRowChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (FormGlobals.Grid_GetDataRowItemInteger(grvTSCD, "GIAM_TSCD") == 1)
                {
                    btnXem.Enabled = true;
                    btnModify.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnXem.Enabled = false;
                    btnModify.Enabled = true;
                    btnDelete.Enabled = true;
                }
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
    }
}