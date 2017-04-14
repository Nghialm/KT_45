using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Asset.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CtTscdService : GenericService<CtTscd, System.Guid>, ICtTscdService
    {
        public ICtTscdDao CtTscdDao
        {
            get { return (ICtTscdDao)Dao; }
            set { Dao = value; }
        }
        public IList<CtTscd> GetObjectByIdDM_TSCD_DC(Guid TscdId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            IList<Core.Domain.VnsOrder> lstorder = new List<Core.Domain.VnsOrder>();
            lstorder.Add(new Core.Domain.VnsOrder(true, "ThuTu"));
            props.Add("TscdId");
            values.Add(TscdId);
            IList<CtTscd> lst = List(-1, -1, props, values, lstorder);

            return lst;
        }

        public CtTscd GetByIdDM_TSCD(Guid TscdId)
        {
            Decimal ThuTu = 1;
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("TscdId");
            values.Add(TscdId);
            props.Add("ThuTu"); //Mac dinh thu tu = 1
            values.Add(ThuTu);
            IList<CtTscd> lst = List(-1, -1, props, values, null);

            if (lst == null || lst.Count == 0)
                return null;
            else
                return lst[0];
        }

        public CtTscd GetObject_TOP1(Guid TscdId, DateTime NgayTinh)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("TscdId");
            values.Add(TscdId);
            IList<CtTscd> lst = List(-1, -1, props, values, null);

            Decimal thutu = 0;
            CtTscd ctTop = null;
            foreach (CtTscd ct in lst)
            {
                DateTime d = ct.NgayBdKh.Value;
                if (d.Day <= 15)
                {
                    d = new DateTime(d.Year, d.Month, 1);
                }
                else
                {
                    d = new DateTime(d.Year, d.Month + 1, 1);
                }

                if (d <= NgayTinh)
                {
                    if (thutu < ct.ThuTu)
                    {
                        thutu = ct.ThuTu;
                        ctTop = ct;
                    }
                }
            }

            return ctTop;
        }

        public CtTscd GetByTRANG_THAI(Guid TscdId, Decimal TangTscd)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("TscdId");
            values.Add(TscdId);
            props.Add("TangTscd"); //Mac dinh thu tu = 1
            values.Add(TangTscd);
            IList<CtTscd> lst = List(-1, -1, props, values, null);

            if (lst == null || lst.Count == 0)
                return null;
            else
                return lst[0];
        }

        public TsLsKhauhao KHAUHAO_VET_CUOI(Guid DmTscdId, DateTime Ngay)
        {
            return CtTscdDao.KHAUHAO_VET_CUOI(DmTscdId, Ngay);
        }
    }
}
