using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;

using Vns.Erp.Core;

namespace Vns.Erp.Core.Asset.CsAssetGUI
{
    public partial class frmDieuChuyenTaiSan_ChiTiet
    {

        #region Variables

        private FormGlobals.DataInputState m_InputState;
        private Guid m_DM_TSCD_ID;
        private Guid m_ts_dc;
        private List<DmTscd> lst_tscd = new List<DmTscd>();
        private List<TsDieuchuyen> lst_tsdc = new List<TsDieuchuyen>();
        private DmTscd obj_tscd = new DmTscd();
        private TsDieuchuyen obj_tsdc = new TsDieuchuyen();
        #endregion
        private Guid str_pb_hienTai;

        #region Property
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
        #endregion

        #region Show_form
        private void AddEvents()
        {
            KeyDown += frmDieuChuyenTaiSan_ChiTiet_KeyDown;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        public frmDieuChuyenTaiSan_ChiTiet()
        {
            InitializeComponent();
            AddEvents();
            TNCommon.setIconControl(this);
        }

        public bool Show_Form(Guid p_DM_TSCD_ID, Guid p_TS_DC, FormGlobals.DataInputState eState)
        {
            try
            {
                FormGlobals.Form_SetText(this, "Điều chuyển tài sản cố định", eState);
                FormGlobals.Form_InitDialog(this);
                m_InputState = eState;
                m_DM_TSCD_ID = p_DM_TSCD_ID;
                m_ts_dc = p_TS_DC;
                obj_tscd = _DmTscdService.GetById(m_DM_TSCD_ID);
                lst_tsdc = new List<TsDieuchuyen>();
                lst_tsdc.AddRange(_TsDieuchuyenService.GetObjectByTSCD_ID(m_DM_TSCD_ID));
                frmProgress.Instance().Thread = Init_Data;
                frmProgress.Instance().Show_Progress();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }

            return (this.ShowDialog() == DialogResult.OK);
        }

        #endregion

        #region Private functions

        private void Init_Data()
        {
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    bindLookUp();
                    GanGT();
                    dteNGAY_DC.DateTime = System.DateTime.Now;
                    string str = txtLY_DO_DC.Text;
                    break;
                case FormGlobals.DataInputState.EditMode:
                    bindLookUp();
                    SetObjectToControl();
                    break;
            }
        }

        private void bindLookUp()
        {
            //bind  phong ban
            ArrayList objColumnDefine = null;
            List<DmPhongban> lstDM_PB = new List<DmPhongban>();
            lstDM_PB.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id));
            objColumnDefine = new ArrayList();
            objColumnDefine.Add(new LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"));
            objColumnDefine.Add(new LookupEdit_ColumnInfo("TenPhongban", "Tên phòng ban"));
            FormGlobals.GridLookupEdit_BindData(grlPHONG_BAN_DC, lstDM_PB, "TenPhongban", "Id", FormGlobals.COMBO_ITEM_REQUIRE, objColumnDefine);
        }


        private void GetControlToObject()
        {
            int THU_TU = _TsDieuchuyenService.GetObjectByTSCD_ID(obj_tscd.Id).Count + 1;
            obj_tsdc.TscdId = obj_tscd.Id;
            obj_tsdc.MaTscd = obj_tscd.MaTscd;
            obj_tsdc.TenTscd = obj_tscd.TenTscd;
            obj_tsdc.KyHieuTscd = obj_tscd.KyHieu;
            if ((grlPHONG_BAN_DC.EditValue != null))
            {
                obj_tsdc.BoPhanDcId = VnsConvert.CGuid( grlPHONG_BAN_DC.EditValue);
            }
            obj_tsdc.NgayDc = dteNGAY_DC.DateTime;
            obj_tsdc.LyDoDc = txtLY_DO_DC.Text;
            switch (m_InputState)
            {
                case FormGlobals.DataInputState.AddMode:
                    obj_tsdc.ThuTu = THU_TU;
                    obj_tsdc.NguoiTao = Generals.USER.Id;
                    _TsDieuchuyenService.Save(obj_tsdc);
                    break;
                case FormGlobals.DataInputState.EditMode:
                    obj_tsdc.NguoiSua = Generals.USER.Id;
                    _TsDieuchuyenService.SaveOrUpdate(obj_tsdc);
                    break;
            }
        }

        private void SetObjectToControl()
        {
            GanGT();
            obj_tsdc = _TsDieuchuyenService.GetById(m_ts_dc);
            grlPHONG_BAN_DC.EditValue = obj_tsdc.BoPhanDcId;
            dteNGAY_DC.DateTime = obj_tsdc.NgayDc.Value;
            txtLY_DO_DC.Text = obj_tsdc.LyDoDc;
        }

        private void GanGT()
        {
            txtMA_TSCD.Text = obj_tscd.MaTscd;
            txtTenTS.Text = obj_tscd.TenTscd;
            txtNGAY_MUA.EditValue = obj_tscd.NgayMua.Value;
            if ((lst_tsdc.Count == 0))
            {
                txtPHONG_BAN_HT.Text = obj_tscd.TenPhongban;
                str_pb_hienTai = obj_tscd.PhongbanId;
            }
            else
            {
                switch (m_InputState)
                {
                    case FormGlobals.DataInputState.AddMode:
                        foreach (TsDieuchuyen obj in lst_tsdc)
                        {
                            if ((obj.ThuTu == lst_tsdc.Count & obj.ThuTu != null))
                            {
                                DmPhongban obj_PB = _DmPhongbanService.GetById(obj.BoPhanDcId);
                                txtPHONG_BAN_HT.Text = obj_PB.TenPhongban;
                                str_pb_hienTai = obj_PB.Id;
                            }
                        }

                        break;
                    case FormGlobals.DataInputState.EditMode:
                        if ((lst_tsdc.Count == 1))
                        {
                            txtPHONG_BAN_HT.Text = obj_tscd.TenPhongban;
                            str_pb_hienTai = obj_tscd.PhongbanId;
                        }
                        else
                        {
                            foreach (TsDieuchuyen obj in lst_tsdc)
                            {
                                if ((obj.ThuTu == lst_tsdc.Count - 1 & obj.ThuTu != null))
                                {
                                    DmPhongban obj_PB = _DmPhongbanService.GetById(obj.BoPhanDcId);
                                    txtPHONG_BAN_HT.Text = obj_PB.TenPhongban;
                                    str_pb_hienTai = obj_PB.Id;
                                }
                            }
                        }
                        break;
                }
            }
        }

        #endregion

        #region Events

        private void frmDieuChuyenTaiSan_ChiTiet_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
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

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (dteNGAY_DC.DateTime == null)
                {
                    FormGlobals.Message_Warning("Bạn chưa nhập ngày điều chuyển!");
                    dteNGAY_DC.Focus();
                    return;
                }
                else
                {
                    if (obj_tscd.NgayMua != null)
                    {
                        if (dteNGAY_DC.DateTime < obj_tscd.NgayMua)
                        {
                            FormGlobals.Message_Warning("Ngày điều chuyển phải >=Ngày mua");
                            dteNGAY_DC.Focus();
                            return;
                        }
                    }
                }
                if (grlPHONG_BAN_DC.EditValue == null)
                {
                    FormGlobals.Message_Information("Bạn chưa nhập phòng ban điều chuyển đến");
                    grlPHONG_BAN_DC.Focus();
                    return;
                }
                else
                {
                    if (VnsConvert.CGuid(grlPHONG_BAN_DC.EditValue) == str_pb_hienTai)
                    {
                        FormGlobals.Message_Information("Phòng ban điều chuyển đến không hợp lệ!");
                        grlPHONG_BAN_DC.Focus();
                        return;
                    }
                }

                frmProgress.Instance().Thread = GetControlToObject;
                frmProgress.Instance().Show_Progress();
                frmProgress.Instance().SetFinishText("Ghi dữ liệu thành công");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void btnCancel_Click(System.Object sender, System.EventArgs e)
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