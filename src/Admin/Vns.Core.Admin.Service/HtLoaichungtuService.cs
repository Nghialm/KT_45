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
using Spring.Transaction.Interceptor;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class HtLoaichungtuService : GenericService<HtLoaichungtu, System.Guid>, IHtLoaichungtuService
    {
        public IHtLoaichungtuDao HtLoaichungtuDao
        {
            get { return (IHtLoaichungtuDao)Dao; }
            set { Dao = value; }
        }

        private IHtSoChungtuMaxDao _HtSoChungtuMaxDao;

        public IHtSoChungtuMaxDao HtSoChungtuMaxDao
        {
            get { return _HtSoChungtuMaxDao; }
            set { _HtSoChungtuMaxDao = value; }
        }

        public HtLoaichungtu GetByMA_LOAI_CT(string p_MA_CT)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("MaLoaiCt");
            values.Add(p_MA_CT);

            IList<HtLoaichungtu> lst = HtLoaichungtuDao.List(-1, -1, props, values, null);
            if (lst == null || lst.Count == 0) return null;
            else
                return lst[0];
        }

        public IList<HtLoaichungtu> LikeObjetMA_LOAI_CT(string p_MA_CT, Guid DONVI_ID)
        {
            return HtLoaichungtuDao.LikeObjetMA_LOAI_CT(p_MA_CT, DONVI_ID);
        }

        public IList<HtLoaichungtu> GetByDonvi(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);

            IList<HtLoaichungtu> lst = HtLoaichungtuDao.List(-1, -1, props, values, null);
            return lst;
        }

        [Transaction]
        public List<string> GetSoCT_prefix(Guid LOAICHUNGTU_ID, decimal THANG, decimal NAM, Guid DONVI_ID)
        {
            List<string> lst_str = new List<string>();
            string Prefix = "";
            string So_CT = "";
            decimal m_SoCT_old = _HtSoChungtuMaxDao.GetByThangNamEtc(LOAICHUNGTU_ID, THANG, NAM, DONVI_ID).SoChungtuMax;
            HtLoaichungtu obj = Get(LOAICHUNGTU_ID);

            if (!string.IsNullOrEmpty(obj.PrefixCt))
            {
                string m_prefix_old = obj.PrefixCt;
                Prefix = GetPrefix(m_prefix_old, NAM, THANG);
            }

            if (!string.IsNullOrEmpty(obj.MauSoCt))
            {
                So_CT = GetSoCT(m_SoCT_old, decimal.Parse(obj.MauSoCt));
            }
            lst_str.Add(Prefix);
            lst_str.Add(So_CT);
            return lst_str;
        }

        public List<HtLoaichungtu> ImportList(List<HtLoaichungtu> lst, Guid DONVI_ID)
        {
            lst.Sort(HtLoaichungtu.CompareMaLoaiCt);

            string mactcha = "XXXXXXXXXXXXXX";
            Guid idcha = new Guid();
            foreach (HtLoaichungtu tmp in lst)
            {
                tmp.Id = Guid.NewGuid();
                tmp.DonviId = DONVI_ID;

                foreach (HtLoaichungtu tmp1 in lst)
                {
                    if (tmp1.MaLoaiCt.StartsWith(tmp.MaLoaiCt) && tmp1.MaLoaiCt != tmp.MaLoaiCt)
                    {
                        tmp1.LoaiCtIdCha = tmp.Id;
                    }
                    //else
                    //{
                    //    tmp.LoaiCtIdCha = new Guid();
                    //    idcha = tmp.Id;
                    //    mactcha = tmp.MaLoaiCt;
                    //}
                }
                
            }

            HtLoaichungtuDao.DeleteByDonViId(DONVI_ID);

            foreach (HtLoaichungtu tmp in lst)
            {
                HtLoaichungtuDao.SaveOrUpdate(tmp);
            }
            return lst;
        }

        private string GetPrefix(string p_prefix, decimal p_Nam, decimal p_Thang)
        {
            string m_Prefix = "";
            DateTime dttmp = new DateTime(Convert.ToInt32(p_Nam), Convert.ToInt32(p_Thang), 1);

            string p_thang_temp = "";
            if (p_Thang < 10)
            {
                p_thang_temp = "0" + p_Thang.ToString();
            }
            else
            {
                p_thang_temp = p_Thang.ToString();
            }

            //Lay gia tri cau hinh thang nam
            int p_s = 0;
            int p_e = 0;
            int dem = 0;
            foreach (char c in p_prefix)
            {
                if (c == '[') p_s = dem;
                if (c == ']') p_e = dem;

                dem++;
            }

            string tientongaythang = "";
            string formatngaythang = "";
            string replatengaythang = "";
            if (p_s != p_e && p_e > p_s)
            {
                formatngaythang = p_prefix.Substring(p_s + 1, p_e - p_s - 1);
                replatengaythang = p_prefix.Substring(p_s, p_e - p_s + 1);

                tientongaythang = dttmp.ToString(formatngaythang);
                //p_prefix.Replace(formatngaythang, tientongaythang);
                m_Prefix = p_prefix.Replace(replatengaythang, tientongaythang);
            }
            else
                m_Prefix = p_prefix;


            //switch (p_prefix)
            //{
            //    case "[YYMM]":
            //        m_Prefix = p_Nam.ToString().Substring(2, 2) + p_thang_temp;
            //        break;
            //    case "[YYYYMM]":
            //        m_Prefix = p_Nam.ToString() + p_thang_temp;
            //        break;
            //    case "[YYYYMM-]":
            //        m_Prefix = p_Nam.ToString() + p_thang_temp + "-";
            //        break;
            //    case "[YYYY/MM]":
            //        m_Prefix = p_Nam.ToString() + "/" + p_thang_temp;
            //        break;
            //    case "[YYYY/MM-]":
            //        m_Prefix = p_Nam.ToString() + "/" + p_thang_temp + "-";
            //        break;
            //    case "[MM/YYYY-]":
            //        m_Prefix = p_thang_temp + "/" + p_Nam.ToString() + "-";
            //        break;
            //    default:
            //        m_Prefix = p_prefix;
            //        break;
            //}

            return m_Prefix;
        }

        private string GetSoCT(decimal p_old, decimal So_kt)
        {
            string m_SoCT = "";

            if (p_old.ToString().Length >= So_kt)
            {
                m_SoCT = p_old.ToString();
            }
            else
            {
                decimal perleng = So_kt - p_old.ToString().Length;
                m_SoCT = str(So_kt).Substring(0, Convert.ToInt32(perleng)) + p_old.ToString();
            }

            return m_SoCT;
        }

        private string str(decimal kt)
        {
            string r_str = "";
            for (int i = 1; i <= kt; i++)
            {
                r_str = r_str + "0";
            }
            return r_str;
        }

        public HtLoaichungtu GetByMA_LOAI_CT(string p_MA_CT, Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("MaLoaiCt");
            values.Add(p_MA_CT);
            props.Add("DonviId");
            values.Add(DonviId);

            IList<HtLoaichungtu> lst = HtLoaichungtuDao.List(-1, -1, props, values, null);
            if (lst == null || lst.Count == 0) return null;
            else
                return lst[0];
        }
    }
}
