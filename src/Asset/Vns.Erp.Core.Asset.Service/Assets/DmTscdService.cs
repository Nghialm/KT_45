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
using Spring.Transaction.Interceptor;

namespace Vns.Erp.Core.Asset.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DmTscdService : GenericService<DmTscd, System.Guid>, IDmTscdService
    {
        public IDmTscdDao DmTscdDao
        {
            get { return (IDmTscdDao)Dao; }
            set { Dao = value; }
        }

        public ITsLsKhauhaoDao TsLsKhauhaoDao;
        public ICtTscdDao CtTscdDao;
        public ITsTscdPtungDao TsTscdPtungDao;
        public ITsDieuchuyenDao TsDieuchuyenDao;
        public ITsCtTscdNvonDao TsCtTscdNvonDao;

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

        public IList<DmTscd> GetByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            ArrayList expression = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);
            expression.Add("=");
            IList<DmTscd> lst = List(-1, -1, props, values, null);
            return lst;
        }

        [Transaction]
        public void DeleteTscd(Guid TscdId)
        {
            TsLsKhauhaoDao.DeleteByTscdId(TscdId);

            CtTscdDao.DeleteByDmTscdId(TscdId);

            DmTscdDao.DeleteById(TscdId);
        }

        #region Syn function
        /// <summary>
        /// Ham dong bo du lieu len server
        /// </summary>
        /// <param name="_cthInfo"></param>
        /// <param name="_lstctd"></param>
        [Transaction]
        public void SaveData4Syn(DmTscd objdmtscd, List<CtTscd> lsCtTscd, List<TsCtTscdNvon> lsTsCtTscdNvon,
            List<TsDieuchuyen> lsTsDieuChuyen, List<TsLsKhauhao> lsTsLsKhauhao, List<TsTscdPtung> lsTsTscdPtung)
        {
            //Xoa du lieu
            TsLsKhauhaoDao.DeleteByTscdId(objdmtscd.Id);
            TsDieuchuyenDao.DeleteByDmTscdId(objdmtscd.Id);
            TsCtTscdNvonDao.DeleteByDmTscdId(objdmtscd.Id);
            CtTscdDao.DeleteByDmTscdId(objdmtscd.Id);
            TsTscdPtungDao.DeleteByTscdId(objdmtscd.Id);
            //DmTscdDao.DeleteById(objdmtscd.Id);

            DmTscdDao.SaveOrUpdate(objdmtscd);

            foreach (CtTscd tmp in lsCtTscd)
                CtTscdDao.SaveOrUpdate(tmp);

            foreach (TsTscdPtung tmp in lsTsTscdPtung)
                TsTscdPtungDao.SaveOrUpdate(tmp);

            foreach (TsCtTscdNvon tmp in lsTsCtTscdNvon)
                TsCtTscdNvonDao.SaveOrUpdate(tmp);

            foreach (TsDieuchuyen tmp in lsTsDieuChuyen)
                TsDieuchuyenDao.SaveOrUpdate(tmp);

            foreach (TsLsKhauhao tmp in lsTsLsKhauhao)
                TsLsKhauhaoDao.SaveOrUpdate(tmp);
        }

        public void UpdateSynFlag(Guid id)
        {
            DmTscdDao.UpdateSynFlag(id);
        }
        #endregion
    }
}
