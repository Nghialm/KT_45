using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtDmBtPhanboService:GenericService<KtDmBtPhanbo,System.Guid>, IKtDmBtPhanboService
	{
	    public IKtDmBtPhanboDao KtDmBtPhanboDao
        {
            get { return (IKtDmBtPhanboDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtDmBtPhanbo> GetByDonviId(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            IList<Vns.Erp.Core.Domain.VnsOrder> lstOrder = new List<Vns.Erp.Core.Domain.VnsOrder>();
            lstOrder.Add(new Vns.Erp.Core.Domain.VnsOrder(true , "Nhom"));
            return List(-1, -1, props, values, lstOrder);
        }

        public void DeleteByNhom(Decimal NHOM, Guid DonviId)
        {
            KtDmBtPhanboDao.DeleteByNhom(NHOM, DonviId);
        }

        public KtDmBtPhanbo GetNhomMax(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            IList<Vns.Erp.Core.Domain.VnsOrder> lstOrder = new List<Vns.Erp.Core.Domain.VnsOrder>();
            lstOrder.Add(new Vns.Erp.Core.Domain.VnsOrder(false, "Nhom"));
            IList<KtDmBtPhanbo> lst = List(1, -1, props, values, lstOrder);
            if ((lst != null) || (lst.Count > 0))
            {
                return lst[0];
            }
            else
                return null;
        }

	}
}