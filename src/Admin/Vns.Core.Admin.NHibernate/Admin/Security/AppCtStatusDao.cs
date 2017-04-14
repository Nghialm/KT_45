
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Dao.NHibernate;
using System.Collections.Generic;
using System.Collections;
using NHibernate;
namespace Vns.Erp.Core.Admin.Dao.NHibernate
{
	[Serializable]
	public sealed class AppCtStatusDao:GenericDao<AppCtStatus,System.Guid>,IAppCtStatusDao
	{					
        public IList<AppCtStatus> GetAllByDonviID(Guid DONVI_ID)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DONVI_ID);
            return List(-1, -1, props, values, null);
        }

        public IList<HtLoaichungtu> GetLCTByDVG(Guid donvi_id, Guid group_id)
        {
/*    Select cast (ct.LOAI_CT_ID AS VARCHAR2(32)) AS LOAI_CT_ID,
        ct.MA_LOAI_CT,ct.KY_HIEU,ct.TEN_LOAI_CT,ct.MO_TA,
        ct.MA_TK_NO_LQ,ct.MA_TK_CO_LQ,cast (ct.LOAI_CT_ID_CHA AS VARCHAR2(32)) AS LOAI_CT_ID_CHA,ct.CAP,
        ct.CHI_TIET,ct.DUONG_DAN,ct.MAU_SO_CT,ct.MAU_BAO_CAO,
        ct.CHO_PHEP_SUA,ct.CO_SU_DUNG,ct.SD_TK_THUE_NGAMDINH,ct.TK_THUE_NGAMDINH,
        ct.DM_PTQT,ct.DM_PHONGBAN,ct.DM_TUDO1,ct.DM_TUDO2,
        ct.DM_TUDO3,ct.DM_TUDO4,ct.DM_TUDO5,ct.DM_VUVIEC,
        ct.KHO_XUAT,ct.PHIEU_XUAT,ct.NGUOI_TAO,ct.NGAY_TAO,
        ct.NGUOI_SUA,ct.NGAY_SUA,ct.SO_CT_HIENTHI,ct.DM_KHOANPHI,
        ct.DM_HOPDONG,ct.DM_KHANG,ct.DM_CBNV
    from ht_loaichungtu ct
    inner join app_ct_status s on cast(s.LOAI_CT_ID as varchar2(32)) = cast(ct.LOAI_CT_ID as varchar2(32))
    and s.DONVI_ID= p_DONVI_ID and s.GROUP_ID= p_GROUP_ID;
 * 
 */
            string sql = "select b from AppCtStatus a inner join a.HtLoaichungtu b where a.DonviId=:DonviId and a.GroupId=:GroupId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonviId", donvi_id);
            q.SetParameter("GroupId", group_id);  
            return q.List<HtLoaichungtu>(); 
        }
        public IList<AppCtStatus> GetByDVGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(donvi_id);
            props.Add("LoaiCtId");
            values.Add(LoaiCtId);
            props.Add("GroupId");
            values.Add(group_id);
            return List(-1, -1, props, values, null);
        }
        public void DeleteByDGCT(Guid donvi_id, Guid group_id, Guid LoaiCtId)
        {
            String sql = "delete from AppCtStatus a where a.DonviId=:DonviId and a.LoaiCtId=:LoaiCtId and a.GroupId=:GroupId";
            IQuery q = NHibernateSession.CreateQuery(sql);
            q.SetParameter("DonViId", donvi_id);
            q.SetParameter("GroupId", group_id);
            q.SetParameter("LoaiCtId", LoaiCtId);
            q.ExecuteUpdate();
        }
	}
}
