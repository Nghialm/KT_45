using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Spa.Domain;
using Vns.Erp.Core.Spa.Dao;
using Vns.Erp.Core.Spa.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Spring.Transaction.Interceptor;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Spa.Common;
using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Spa.Service
{
	public class SpaDmTheService:GenericService<SpaDmThe,System.Guid>, ISpaDmTheService
    {
        #region Property
        public ISpaDmTheDao SpaDmTheDao
        {
            get { return (ISpaDmTheDao)Dao; }
            set { Dao = value; }
        }

        private ISpaLsTheDao _SpaLsTheDao;
        public ISpaLsTheDao SpaLsTheDao
        {
            get { return _SpaLsTheDao; }
            set { _SpaLsTheDao = value; }
        }

        public IBcKetoanDao BcKetoanDao { get; set; }
        #endregion

        public IList<SpaDmThe> GetAllByDonviID(Guid DonviId)
        {
            return SpaDmTheDao.GetAllByDonviID(DonviId);
        }

        [Transaction]
        public SpaDmThe SaveWithHis(Boolean IsInsert, SpaDmThe dmThe)
        {
            if (IsInsert)
                SpaDmTheDao.Save(dmThe);
            else
                SpaDmTheDao.SaveOrUpdate(dmThe);

            //Update to history
            SpaLsThe tmpls = new SpaLsThe(dmThe);
            SpaLsTheDao.SaveOrUpdate(tmpls);

            //Update to Accounting
            BcKetoanDao.DeleteByChungTu(dmThe.Id, Null.NullGuid);
            BcKetoan bcKt = dmThe.GenBcKetoan(SpaGeneral.TkTienMatInfo, SpaGeneral.TkDoanhThuChuaThucHienInfo, SpaGeneral.NoiTe, null);
            BcKetoanDao.SaveOrUpdate(bcKt);

            return dmThe;
        }
        
        [Transaction]
        public Boolean DeleteWithHis(Guid dmThe)
        {
            SpaDmTheDao.DeleteById(dmThe);
            _SpaLsTheDao.DeleteByThe(dmThe);
            BcKetoanDao.DeleteByChungTu(dmThe, Null.NullGuid);

            return true;
        }

        

	}
}