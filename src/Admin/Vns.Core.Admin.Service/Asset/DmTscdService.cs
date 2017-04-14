using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DmTscdService : GenericService<DmTscd, System.Guid>, IDmTscdService
    {
        public IDmTscdDao DmTscdDao
        {
            get { return (IDmTscdDao)Dao; }
            set { Dao = value; }
        }

        public IList<DmTscd> GetbyParameter(DateTime TuNgay, DateTime DenNgay, String TenTscd, Guid LoaitaisanId, Guid DonviId)
        {
            return DmTscdDao.GetbyParameter(TuNgay, DenNgay, TenTscd, LoaitaisanId, DonviId);
        }

        public DmTscd GetByMaTSCD(String MaTscd, Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("MaTscd");
            values.Add(MaTscd);
            props.Add("DonviId");
            values.Add(DonviId);
            IList<DmTscd> lst =  List(-1, -1, props, values, null);

            if (lst == null || lst.Count == 0)
                return null;
            else
                return lst[0];

        }

        public IList<DmTscd> GetObjectAllByDonviID(int PageIndex, int PageSize, Guid DonviId, out int TotalResult)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            ArrayList expression = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            expression.Add("=");
            IList<DmTscd> lst = List(PageIndex , PageSize, props, values, null);
            TotalResult = this.GetCount(props, values, expression);
            return lst;
        }
    }
}
