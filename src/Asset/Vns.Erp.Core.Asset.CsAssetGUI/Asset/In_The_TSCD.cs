using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Asset.Domain;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class In_The_TSCD
    {

        #region "Property"
        private IDmTscdService _DmTscdService;
        public IDmTscdService DmTscdService
        {
            get { return _DmTscdService; }
            set { _DmTscdService = value; }
        }

        private IDmLoaitaisanService _DmLoaitaisanService;
        public IDmLoaitaisanService DmLoaitaisanService
        {
            get { return _DmLoaitaisanService; }
            set { _DmLoaitaisanService = value; }
        }
        #endregion

        #region "variables"
        private List<DmTscd> dt = new List<DmTscd>();
        private GridCheckMarksSelection selection;
        #endregion
        string LoaiTS_id;

        #region "Private functions"

        private void AddEvents()
        {
            KeyDown += In_The_TSCD_KeyDown;
            Load += In_The_TSCD_Load;
            grvTSCD.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(grvTSCD_CellValueChanged);
            btnQuit.Click += new EventHandler(SimpleButton1_Click);
            btnPrint.Click += new EventHandler(btnIn_Click);
            btnSearch.Click += new EventHandler(btnSearch_Click);
            grlLoaiTSCD.EditValueChanged += new EventHandler(grlLoaiTSCD_EditValueChanged);
        }

        public In_The_TSCD()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
            DateTime _date = DateTime.Now.Date;
            dteTuNgay.DateTime = new System.DateTime(_date.Year, 1, 1);
            dteDenNgay.DateTime = _date;
        }

        public In_The_TSCD(System.DateTime TU_NGAY, System.DateTime DEN_NGAY, string TEN_TSCD, string LOAI_TSCD, Guid DON_VI_ID)
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
            dteTuNgay.DateTime = TU_NGAY;
            dteDenNgay.DateTime = DEN_NGAY;
            txtTenTS.Text = TEN_TSCD;
            LoaiTS_id = LOAI_TSCD;
        }

        private void load_Data()
        {
            dt = new List<DmTscd>();
            dt.AddRange(_DmTscdService.GetbyParameter((DateTime)dteTuNgay.DateTime, (DateTime)dteDenNgay.DateTime, txtTenTS.Text.Trim(), VnsConvert.CGuid(grlLoaiTSCD.EditValue), Generals.DON_VI.Id));
            grcTSCD.DataSource = dt;
            CheckKry();
        }

        private void BindData()
        {
            Guid DON_VI_ID = Generals.DON_VI.Id;
            ArrayList objColumnDefine = null;

            List<DmLoaitaisan> dt_DM_LoaiTS = new List<DmLoaitaisan>();
            dt_DM_LoaiTS.AddRange(_DmLoaitaisanService.GetAll());

            DmLoaitaisan dr = new DmLoaitaisan();
            dr.KyHieu = "";
            dr.Id = Null.NullGuid;
            dr.TenLoaitaisan = "<Không xác định>";
            dt_DM_LoaiTS.Add(dr);

            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenLoaichungtu", "Tên loại tài sản"));
            FormGlobals.GridLookupEdit_BindData(grlLoaiTSCD, dt_DM_LoaiTS, "KyHieu", "Id", FormGlobals.COMBO_ITEM_BLANK, "TenLoaichungtu", txttenLoaiTS, objColumnDefine);

        }

        private void CheckKry()
        {
            if ((selection != null))
            {
                selection.ClearSelection();
            }
            else
            {
                selection = new GridCheckMarksSelection(grvTSCD);
                selection.CheckMarkColumn.VisibleIndex = 0;
                selection.CheckMarkColumn.Width = 35;
                selection.CheckMarkColumn.OptionsColumn.AllowSize = false;
                selection.CheckMarkColumn.OptionsColumn.FixedWidth = true;
                selection.CheckMarkColumn.FieldName = "UNCHECK11";
            }
        }

        #endregion

        #region "Events"

        private void In_The_TSCD_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                BindData();
                txttenLoaiTS.Text = "<Không xác định>";
                grlLoaiTSCD.EditValue = LoaiTS_id;
                load_Data();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void grvTSCD_CellValueChanged(System.Object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //Dim dt1 As DataTable = dt
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void SimpleButton1_Click(System.Object sender, System.EventArgs e)
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
                IList<DmTscd> dt_Edit = (IList<DmTscd>)grvTSCD.DataSource;
                string str = "";
                IList<DmTscd> lstTscd = new List<DmTscd>();
                for (int i = 0; i <= grvTSCD.RowCount - 1; i++)
                {
                    if ((grvTSCD.GetRowCellValue(i, "UNCHECK11").ToString() == "True"))
                    {
                        if ((string.IsNullOrEmpty(str)))
                        {
                            str = str + grvTSCD.GetRowCellValue(i, "Id").ToString();
                        }
                        else
                        {
                            str = str + ";" + grvTSCD.GetRowCellValue(i, "Id").ToString();
                        }
                        lstTscd.Add(dt_Edit[i]);
                    }
                }
                if ((!string.IsNullOrEmpty(str)))
                {
                    The_TSCD rpt = (The_TSCD)ObjectFactory.GetObject("The_TSCD", new object[] {
					str,
					lstTscd
				});
                    rpt.ShowPreview();
                }
                else
                {
                    FormGlobals.Message_Information("Không có bản ghi nào được lựa chọn");
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void In_The_TSCD_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //try
            //{
            //    switch (e.KeyCode)
            //    {
            //        case Keys.Escape:
            //            this.Close();
            //            break;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    FormGlobals.Message_Error(ex);
            //}
        }

        private void btnSearch_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                frmProgress.Instance().Thread = load_Data;
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

    }
}