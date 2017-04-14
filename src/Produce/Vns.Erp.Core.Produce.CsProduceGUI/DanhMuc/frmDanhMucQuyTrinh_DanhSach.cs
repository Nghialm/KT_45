using System;
using Vns.Erp.Core.Produce.Service.Interface;
using System.Collections;
using System.Collections.Generic;
using Vns.Erp.Core.Produce.Domain;
using System.Windows.Forms;
using System.Data;

namespace Vns.Erp.Core.Produce.CsProduceGUI
{
    public partial class frmDanhMucQuyTrinh_DanhSach : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        public ISxDmQuytrinhService SxDmQuytrinhService;
        #endregion

        #region Contructor
        public frmDanhMucQuyTrinh_DanhSach()
        {
            InitializeComponent();
            TNCommon.setIconControl(this);
        }
        #endregion

        #region Private function

        private void LoadData()
        {
            IList<SxDmQuytrinh> lstQuyTrinh = new List<SxDmQuytrinh>();
            lstQuyTrinh = SxDmQuytrinhService.GetByDonviId(Generals.DonviID);
            grcQuyTrinh.DataSource = lstQuyTrinh;
        }

        private void Edit()
        {
            if (grvQuyTrinh.RowCount == 0)
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                return;
            }

            int i = grvQuyTrinh.FocusedRowHandle;
            SxDmQuytrinh obj = (SxDmQuytrinh)grvQuyTrinh.GetRow(grvQuyTrinh.FocusedRowHandle);
            frmDanhMucQuyTrinh_DinhMuc frm = (frmDanhMucQuyTrinh_DinhMuc)ObjectFactory.GetObject("frmDanhMucQuyTrinh_DinhMuc");
            SxDmQuytrinh objReturn = frm.Show_Form(FormGlobals.DataInputState.EditMode, obj);
            if (objReturn != null)
            {
                LoadData();
                grvQuyTrinh.FocusedRowHandle = i;
            }
        }

        private void AddNew()
        {
            FrmDanhMucQuyTrinh_ChiTiet frm = (FrmDanhMucQuyTrinh_ChiTiet)ObjectFactory.GetObject("FrmDanhMucQuyTrinh_ChiTiet");
            SxDmQuytrinh obj = frm.Show_Form(FormGlobals.DataInputState.AddMode, null);
            if (obj != null)
            {
                LoadData();
            }
        }

        private void Delete()
        {
            if (grvQuyTrinh.RowCount == 0)
            {
                FormGlobals.Message_Warning("Không có bản ghi nào được lựa chọn");
                return;
            }
            
            SxDmQuytrinh obj = (SxDmQuytrinh)grvQuyTrinh.GetRow(grvQuyTrinh.FocusedRowHandle);
            if (FormGlobals.Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?"))
            {
                SxDmQuytrinhService.DeleteById(obj.Id);
                LoadData();
            }
        }

        #endregion

        #region Event

        private void btnThem_Click(object sender, EventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
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

        private void btnSua_Click(object sender, EventArgs e)
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
        
        private void grvQuyTrinh_DoubleClick(object sender, EventArgs e)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDanhMucQuyTrinhDanhSach_Load(object sender, EventArgs e)
        {
            try
            {
                frmProgress.Instance().Thread = LoadData;
                frmProgress.Instance().Show_Progress("Đang tải dữ liệu");
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion        

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();
            frm.ShowDialog();

            if ((!string.IsNullOrEmpty(frm.FileName)))
            {
                DataTable dt = NPOIExcelHelper.ReadDicFile(frm.FileName);

                if (FormGlobals.Message_Confirm("Bạn có muốn xóa dữ liệu cũ?", false)) 
                {
                    SxDmQuytrinhService.DeleteAllByDonviId(Generals.DON_VI.Id);
                }

                List<SxDmQuytrinh> lstNew = new List<SxDmQuytrinh>();
                IList<SxDmQuytrinh> lstOld = SxDmQuytrinhService.GetByDonviId(Generals.DON_VI.Id);

                foreach (DataRow dr in dt.Rows)
                {
                    SxDmQuytrinh tmp = new SxDmQuytrinh(dr);
                    tmp.DonviId = Generals.DON_VI.Id;

                    lstNew.Add(tmp);
                }

                foreach (SxDmQuytrinh objnew in lstNew)
                {
                    bool flg_exist = false;
                    foreach (SxDmQuytrinh objold in lstOld)
                    {
                        if (objnew.MaQuytrinh == objold.MaQuytrinh)
                        {
                            flg_exist = true;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }

                    if (!flg_exist)
                    {
                        SxDmQuytrinhService.Save(objnew);
                    }
                }

            }
        }
    }
}