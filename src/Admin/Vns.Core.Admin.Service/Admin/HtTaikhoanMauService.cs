using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;


namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class HtTaikhoanMauService:GenericService<HtTaikhoanMau,System.Guid>, IHtTaikhoanMauService
	{
	    public IHtTaikhoanMauDao HtTaikhoanMauDao
        {
            get { return (IHtTaikhoanMauDao)Dao; }
            set { Dao = value; }
        }

        private IDmTaikhoanDao _DmTaikhoanDao;
        public IDmTaikhoanDao DmTaikhoanDao
        {
            get { return _DmTaikhoanDao; }
            set { _DmTaikhoanDao = value; }
        }

        [Transaction]
        public Boolean ImportDmTaiKhoan(Decimal Loai, Guid DonviId)
        {
            _DmTaikhoanDao.DeleteAllByDonvi(DonviId);

            IList<HtTaikhoanMau> lstMau = HtTaikhoanMauDao.GetByLoai(Loai);
            List<DmTaikhoan> lsTaikhoan = new List<DmTaikhoan>();
            for (int i = 0; i < lstMau.Count; i++)
            {
                lsTaikhoan.Add(lstMau[i].GenToDmTaikhoan());
            }

            for (int i = 0; i < lsTaikhoan.Count; i++)
            {
                lsTaikhoan[i].DonviId = DonviId;
                _DmTaikhoanDao.Save(lsTaikhoan[i]);
            }

            for (int i = 0; i < lsTaikhoan.Count; i++)
            {
                _DmTaikhoanDao.SetParentId(lsTaikhoan[i]);
            }
            return true;
        }
	}
}