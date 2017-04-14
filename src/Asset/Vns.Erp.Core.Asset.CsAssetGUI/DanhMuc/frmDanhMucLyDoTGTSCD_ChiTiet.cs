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
using DevExpress.XtraEditors.DXErrorProvider;

using Vns.Erp.Core;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDanhMucLyDoTGTSCD_ChiTiet : FrmBaseDmChiTiet
    {

        private IHtDanhmucService _HtDanhmucService;
        public IHtDanhmucService HtDanhmucService
        {
            get { return _HtDanhmucService; }
            set { _HtDanhmucService = value; }
        }

        private IDmLydoTgTscdService _DmLydoTgTscdService;
        public IDmLydoTgTscdService DmLydoTgTscdService
        {
            get { return _DmLydoTgTscdService; }
            set { _DmLydoTgTscdService = value; }
        }
        #region "Modify here"
        /// <summary>
        /// Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
        /// </summary>
        public override void InitProperty()
        {
            //Size = new Size();
            //Tiêu d? 
            Title = "Danh mục lý do tăng giảm tài sản cố định";

            //Tên b?ng truy v?n trong DB
            TableName = "DM_LYDO_TG_TSCD";

            //Thêm các control b?t bu?c nh?p vào dây
            //Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
            RequireInputControls = new Control[] {
			txtMA_LYDO_TG_TSCD,
			txtTEN_LYDO_TG_TSCD,
			txtKY_HIEU,
			cboLOAI_LG1
		};

            //---------------------------------------------------------------------
            ButtonSave = btnSave;
            ButtonClear = btnClear;
            ButtonCancel = btnCancel;
            GroupControlObjectInfo = _GroupControlObjectInfo;
        }

        /// <summary>
        /// X? lư b?t l?i d? li?u
        /// </summary>
        /// <param name="sender"></param>
        // <param name="e"></param>
        private string MaCu;
        public override void ValidateData(object sender, CancelEventArgs e)
        {
            try
            {
                if (object.ReferenceEquals(sender, txtMA_LYDO_TG_TSCD))
                {
                    string Ma_LyDoTGTSCD = txtMA_LYDO_TG_TSCD.Text;
                    switch (Mode)
                    {
                        case FormGlobals.DataInputState.AddMode:
                            KiemTraMa(Ma_LyDoTGTSCD, e);
                            break;
                        case FormGlobals.DataInputState.EditMode:

                            if (MaCu != Ma_LyDoTGTSCD)
                            {
                                KiemTraMa(Ma_LyDoTGTSCD, e);
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void KiemTraMa(string Ma_LyDoTGTSCD, CancelEventArgs e)
        {
            //Try
            //Dim kiemtra As Boolean = HeThong_UtilBO.Instance().KiemTraMaDanhMuc("DM_LYDO_TG_TSCD", "MA_LYDO_TG_TSCD", Ma_LyDoTGTSCD, Generals.DON_VI.Id)
            //If (Not kiemtra) Then
            //    ErrorProvider.SetError(txtMA_LYDO_TG_TSCD, "Mã đã tồn tại")
            //    e.Cancel = True

            //End If
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        /// <summary>
        /// Luu d? li?u vào DB (thêm m?i ho?c s?a)
        /// </summary>
        public override void Saving()
        {
            try
            {
                DmLydoTgTscd info = ObjectInfo;
                switch (Mode)
                {
                    case FormGlobals.DataInputState.AddMode:
                        info.Id = Guid.NewGuid();
                        ID = DmLydoTgTscdService.Save(info).Id;
                        cboLOAI_LG1.ItemIndex = 0;

                        break;
                    case FormGlobals.DataInputState.EditMode:
                        DmLydoTgTscdService.SaveOrUpdate(info);
                        break;
                }
                AfterSaveSuccess();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// Chuy?n d?i d? li?u qua l?i gi?a d?i tu?ng Info và form
        /// </summary>
        public DmLydoTgTscd ObjectInfo
        {
            //L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
            get
            {
                DmLydoTgTscd info = new DmLydoTgTscd();
                if ((ID != null))
                {
                    info = this.DmLydoTgTscdService.Get(VnsConvert.CGuid(ID));
                }
                //FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
                info.KyHieu = this.txtKY_HIEU.Text;
                info.MaLydoTgTscd = this.txtMA_LYDO_TG_TSCD.Text;
                info.TenLydoTgTscd = this.txtTEN_LYDO_TG_TSCD.Text;
                info.LoaiLg = decimal.Parse(cboLOAI_LG1.EditValue.ToString());
                info.DonviId = Generals.DON_VI.Id;
                info.MaDonvi = Generals.DON_VI.MaDonvi;
                info.GiaTri = 0;
                info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked);

                base.ResultObject = info;
                return info;
            }

            //L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
            set
            {
                if ((value != null))
                {
                    DmLydoTgTscd obj = value as DmLydoTgTscd;
                    //FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                    this.txtKY_HIEU.Text = obj.KyHieu;
                    this.txtMA_LYDO_TG_TSCD.Text = obj.MaLydoTgTscd;
                    this.txtTEN_LYDO_TG_TSCD.Text = obj.TenLydoTgTscd;
                    cboLOAI_LG1.EditValue = obj.LoaiLg;
                    chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung);
                    //cboLOAI_LG1.EditValue = obj.LOAILG
                }
            }
        }

        /// <summary>
        /// Kh?i t?o d? li?u cho các GridLookupEdit
        /// </summary>
        public override void BindLookUpEdit()
        {
            try
            {
                //Bind lo?i tang gi?m
                List<HtDanhmuc> dtLoaiTG = new List<HtDanhmuc>();
                dtLoaiTG.AddRange(HtDanhmucService.GetByDoiTuong("KIEU_THAYDOI_TSCD"));

                ArrayList LoaiTGComlumnDefine = new ArrayList();
                LoaiTGComlumnDefine.Add(new ColumnInfo("TenDanhmuc", "Tên", 0, true, ""));
                TNCommon.BindData_LookupEdit(cboLOAI_LG1, dtLoaiTG, "TenDanhmuc", "GiaTri", LoaiTGComlumnDefine, false);
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BindData()
        {
            try
            {
                ObjectInfo = DmLydoTgTscdService.GetById(VnsConvert.CGuid(ID));
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        //Public Overrides Sub InitComponet()
        //    InitializeComponent()
        //End Sub
        public frmDanhMucLyDoTGTSCD_ChiTiet()
        {

            InitializeComponent();
            Load += frmDanhMucLyDoTGTSCD_ChiTiet_Load;
        }
        private void frmDanhMucLyDoTGTSCD_ChiTiet_Load(object sender, EventArgs e)
        {
            InitProperty();
            CommonInit();
            TNCommon.setIconControl(this);
            try
            {
                MaCu = txtMA_LYDO_TG_TSCD.Text;
                switch (Mode)
                {
                    case FormGlobals.DataInputState.AddMode:
                        cboLOAI_LG1.ItemIndex = 0;

                        break;
                    case FormGlobals.DataInputState.EditMode:
                        break;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }
    }
}