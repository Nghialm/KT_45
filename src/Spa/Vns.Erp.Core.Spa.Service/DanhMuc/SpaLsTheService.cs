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

namespace Vns.Erp.Core.Spa.Service
{
	public class SpaLsTheService:GenericService<SpaLsThe,String>, ISpaLsTheService
	{
	    public ISpaLsTheDao SpaLsTheDao
        {
            get { return (ISpaLsTheDao)Dao; }
            set { Dao = value; }
        }

        public Decimal GetRemainCard(Guid TheId, Guid CtHId)
        {
            IList<SpaLsThe> lst = SpaLsTheDao.GetHistoryCard(TheId);

            Decimal RemainCard = 0;
            foreach (SpaLsThe tmp in lst)
            {
                if (VnsCheck.IsNullGuid(tmp.Mphieuid))
                    RemainCard += tmp.Sotien;
                else
                    if (tmp.Mphieuid != CtHId)
                        RemainCard -= tmp.Sotien;
            }

            return RemainCard;
        }

        public SpaLsThe GetRemainCardInfo(Guid TheId, Guid CtHId)
        {
            IList<SpaLsThe> lst = SpaLsTheDao.GetHistoryCard(TheId);

            SpaLsThe RemainCard = new SpaLsThe();
            foreach (SpaLsThe tmp in lst)
            {
                if (VnsCheck.IsNullGuid(tmp.Mphieuid))
                {
                    RemainCard.Sotien += tmp.Sotien;
                    RemainCard.TienThe += tmp.TienThe;
                    RemainCard.TienKhuyenMai += tmp.TienKhuyenMai;
                }
                else
                    if (tmp.Mphieuid != CtHId)
                    {
                        RemainCard.Sotien -= tmp.Sotien;
                        RemainCard.TienThe -= tmp.TienThe;
                        RemainCard.TienKhuyenMai -= tmp.TienKhuyenMai;
                    }
            }

            return RemainCard;
        }

        public IList<SpaLsThe> GetHistoryCard(Guid Theid)
        {
            return SpaLsTheDao.GetHistoryCard(Theid);
        }
	}
}