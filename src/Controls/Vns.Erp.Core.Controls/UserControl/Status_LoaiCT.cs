using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core;
//using System.ComponentModel;

namespace Vns.Erp.Core.Controls.UserControl
{
    public partial class Status_LoaiCT
    {
        private Vns.Erp.Core.ValueInfo _Value_info = new ValueInfo();

        public Vns.Erp.Core.ValueInfo Value_info
        {
            get { return _Value_info; }
            set { _Value_info = value; }
        }
        //public Vns.Erp.Core.ValueInfo Value_info { get; set; }

        #region "Init Service"
        private void InitService()
        {
            bo_ct_status = (IAppCtStatusService)ObjectFactory.GetObject("AppCtStatusService");
            bo_status_detail = (IKtStatusCtService)ObjectFactory.GetObject("KtStatusCtService");
        }

        #endregion

        #region "Variables"
        IAppCtStatusService bo_ct_status;
        IKtStatusCtService bo_status_detail;
        private KtStatusCt info_detail = new KtStatusCt();
        private Guid DONVI_ID = new Guid();

        private List<Guid> LIST_UG = new List<Guid>();

        private List<KtStatusCt> LISTBIND = new List<KtStatusCt>();

        private Guid _LCT_STATUS = new Guid();
        public Guid LCT_STATUS
        {
            get { return _LCT_STATUS; }
            set { _LCT_STATUS = value; }
        }


        private string _STATUS_UPDATE = "-1";
        public string STATUS_UPDATE
        {
            get { return _STATUS_UPDATE; }
        }

        public void Set_Status(string _ss)
        {
            if (!(HasBindData))
                Loaddata();

            _STATUS_UPDATE = _ss;
            cboStatus.EditValue = _ss;
            if ((_LIST_STATUS_ALL == null) & !(_ss == "-1"))
            {
                _LIST_STATUS_ALL = bo_status_detail.GetAll();
            }
            LayTenTrangThai();
        }


        private bool _CheckStatus = true;
        public bool CheckStatus
        {
            get { return _CheckStatus; }
            set { _CheckStatus = value; }
        }

        /// <summary>
        /// Danh sach cac trang thai trong he thong
        /// </summary>
        /// <remarks></remarks>

        private IList<KtStatusCt> _LIST_STATUS_ALL;
        #endregion

        #region "Common Functions"
        public Status_LoaiCT()
        {
            InitializeComponent();

            if (!this.DesignMode) return;
            InitService();
        }

        private void InitData()
        {
            DONVI_ID = Generals.DON_VI.Id;
            LIST_UG = Vns.Erp.Core.Globals.LIST_USER_GROUP;
            //lblName.Text = ""

        }

        /// <summary>
        /// Lay danh sach tat ca trang thai chung tu
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private IList<KtStatusCt> GetListFilter()
        {
            return _LIST_STATUS_ALL;
        }

        /// <summary>
        /// Gan danh sach trang thai duoc phan quyen bind len combobox
        /// </summary>
        /// <remarks></remarks>
        private void GetListStatusFilter()
        {
            try
            {
                IList<KtStatusCt> listFilter = GetListFilter();
                if ((LIST_UG != null))
                {
                    if (LIST_UG.Count > 0)
                    {
                        for (int i = 0; i <= LIST_UG.Count - 1; i++)
                        {
                            Guid group_id = LIST_UG[i];
                            IList<AppCtStatus> dt = bo_ct_status.GetByDVGCT(DONVI_ID, group_id, LCT_STATUS);
                            if (dt.Count > 0)
                            {
                                string ds_status = dt[0].DsStatus;
                                string[] arr = ds_status.Split(';');
                                foreach (string lct_status in arr)
                                {
                                    if ((IsExistedItemInList(LISTBIND, lct_status) == false))
                                    {
                                        KtStatusCt obj = GetDataItem(lct_status);
                                        if ((obj != null))
                                        {
                                            LISTBIND.Add(GetDataItem(lct_status));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void BindData()
        {
            try
            {
                cboStatus.Properties.DataSource = LISTBIND;
                cboStatus.Properties.ValueMember = "Id";
                cboStatus.Properties.DisplayMember = "Id";
                if (LISTBIND.Count > 0)
                {
                    cboStatus.EditValue = LISTBIND[0].Id;
                }
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        private void CheckUpdate()
        {
            if (!STATUS_UPDATE.Equals("-1"))
            {
                cboStatus.EditValue = STATUS_UPDATE;
            }
        }

        public bool IsExistedItemInList(List<string> list, string item)
        {
            try
            {
                bool bReturn = false;
                foreach (string info in list)
                {
                    if (info.Equals(item))
                    {
                        bReturn = true;
                    }
                }
                return bReturn;
            }
            catch
            {
                return false;
            }
        }

        public bool IsExistedItemInList(List<KtStatusCt> list, string item)
        {
            try
            {
                bool bReturn = false;
                foreach (KtStatusCt info in list)
                {
                    if (info.Id.Equals(item))
                    {
                        bReturn = true;
                    }
                }
                return bReturn;
            }
            catch
            {
                return false;
            }
        }

        private KtStatusCt GetDataItem(string _Trang_thai)
        {
            foreach (KtStatusCt temp in _LIST_STATUS_ALL)
            {
                if ((temp.Id.ToString() == _Trang_thai))
                {
                    return temp;
                }
            }
            return null;
        }
        #endregion

        #region "Event Handles"
        private void Status_LoaiCT_Load(System.Object sender, System.EventArgs e)
        {
            if ((this.DesignMode))
                return;

            try
            {
                InitService();
                if (!(HasBindData))
                    Loaddata();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }


        bool HasBindData = false;
        private void Loaddata()
        {
            //Try
            if ((this.DesignMode))
                return;
            if (bo_ct_status == null)
            {
                InitService();
            }
            if ((_LIST_STATUS_ALL == null))
            {
                _LIST_STATUS_ALL = new List<KtStatusCt>(bo_status_detail.GetAll());
                //_LIST_STATUS_ALL ();
            }
            InitData();
            GetListStatusFilter();
            BindData();
            CheckUpdate();
            HasBindData = true;
            //Catch ex As Exception
            //    Message_Error(ex)
            //End Try
        }

        private void cboStatus_EditValueChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!Generals.Ts_PheDuyetChungTu)
                {
                    _Value_info.ParameterValue = 1;
                    _STATUS_UPDATE = "";
                    return;
                }
                _Value_info.ParameterValue = cboStatus.EditValue;
                _STATUS_UPDATE = _Value_info.ParameterValue.ToString();
                //info_detail = bo_status_detail.GetById(Decimal.Parse(cboStatus.EditValue))
                LayTenTrangThai();
            }
            catch (Exception ex)
            {
                FormGlobals.Message_Error(ex);
            }
        }

        #endregion

        //public void selectFirst()
        //{
        //    //cboStatus.Item
        //    //List<KtStatusCt> lst =  cboStatus.Properties.DataSource;
        //    //if (lst.Count != 0)
        //    //{
        //    //    TNCommon.SelectFirst(cboStatus);
        //    //}
        //}

        public bool ChoPhepSuaCT()
        {
            return true;
            //Tam thoi

            bool _bTemp = false;
            foreach (KtStatusCt i in LISTBIND)
            {
                if ((_STATUS_UPDATE == i.Id.ToString()))
                {
                    _bTemp = true;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            return (_bTemp & _CheckStatus);
        }

        private string LayTenTrangThai()
        {
            if ((_LIST_STATUS_ALL == null))
            {
                return "";
            }

            foreach (KtStatusCt obj in _LIST_STATUS_ALL)
            {
                if ((STATUS_UPDATE == obj.Id.ToString()))
                {
                    lblName.Text = obj.Ten;
                    return obj.Ten;
                }
            }
            lblName.Text = "";
            return "";
        }
        
    }
}