
using System;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using System.Collections;
using NHibernate;
namespace Vns.Erp.Core.Asset.Dao.NHibernate
{
	[Serializable]
	public sealed class CcCtCcdcDao:GenericDao<CcCtCcdc,System.Guid>,ICcCtCcdcDao
	{
        public IList<CcCtCcdc> GetByCCDCId(Guid CcdcId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CcdcId");
            values.Add(CcdcId);
            return List(-1, -1, props, values, null);
        }

        public IList<CcCtCcdc> GetByCCDCIdAndTT(Guid CcdcId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CcdcId");
            values.Add(CcdcId);
            props.Add("ThuTu");
            values.Add(1);
            return List(-1, -1, props, values, null);
        }
        
        //---------------------------
        // GiamCcdc = 1: Tang
        // GiamCcdc = 2: Giam han
        // GiamCcdc = 3: DC Tang
        // GiamCcdc = 4: DC giam
        //---------------------------
        public IList<CcCtCcdc> GetByTrangThai(decimal GiamCcdc, Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("GiamCcdc");
            values.Add(GiamCcdc);
            props.Add("DonviId");
            values.Add(DonviId);
            return List(-1, -1, props, values, null);
        }

        
        public Boolean DeleteByCcdcId(Guid CcdcId)
        {
            String sql = " delete from CcCtCcdc a where " +
                         " a.CcdcId=:CcdcId ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CcdcId", CcdcId);
            int i = q.ExecuteUpdate();

            return true;
        }

        public Boolean DeleteByTrangThai(Guid CcdcId, Decimal GiamCcdc)
        {
            String sql = " delete from CcCtCcdc a where " +
                         " a.CcdcId=:CcdcId " +
                         " a.GiamCcdc =:GiamCcdc ";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("CcdcId", CcdcId);
            q.SetParameter("GiamCcdc", GiamCcdc);
            int i = q.ExecuteUpdate();
            return true;
        }


        public IList<CcCtCcdc> GetByCcDcId_TrangThai(Guid CcdcId, decimal GiamCcdc)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CcdcId");
            values.Add(CcdcId);
            props.Add("GiamCcdc");
            values.Add(GiamCcdc);
            return List(-1, -1, props, values, null);
        }

        public IList<CcCtCcdc> GetByNgayThangKhauhao(DateTime NgayTinh, Guid DonviId)
        {
            String SQL = " SELECT a from CcCtCcdc a " +
                " where a.DonviId = :DonviId and " +
                " a.NgayBdpb <= :NgayTinh " +
                "";
                //" NgayKtpb >= :NgayTinh";

            IQuery qbcketoan = NHibernateSession.CreateQuery(SQL);
            qbcketoan.SetParameter("NgayTinh", NgayTinh);
            qbcketoan.SetParameter("DonviId", DonviId);

            IList<CcCtCcdc> lst = qbcketoan.List<CcCtCcdc>();
            return lst;
        }

           
	}
}
