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
	public class SpaDmNhanvienService:GenericService<SpaDmNhanvien,System.Guid>, ISpaDmNhanvienService
	{
	    public ISpaDmNhanvienDao SpaDmNhanvienDao
        {
            get { return (ISpaDmNhanvienDao)Dao; }
            set { Dao = value; }
        }

        public IList<SpaDmNhanvien> GetAllByDonviID(Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DonviId");
            values.Add(DonviId);

            return SpaDmNhanvienDao.List(-1, -1, props, values);
        }

        public IList<SpaDmNhanvien> GetByTrangThai(bool trangThai)
        {
            return SpaDmNhanvienDao.GetByTrangThai(trangThai);
        }
       
	}
}