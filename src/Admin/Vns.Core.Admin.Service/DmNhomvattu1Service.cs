/*
insert license info here
*/
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
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
	/// </summary>	
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class DmNhomvattu1Service:GenericService<DmNhomvattu1,Guid>, IDmNhomvattu1Service
	{
	     public IDmNhomvattu1Dao DmNhomvattu1Dao
        {
            get { return (IDmNhomvattu1Dao)Dao; }
            set { Dao = value; }
        }
         public IList<DmNhomvattu1> GetObjectAllByDonviID(Guid DonViId)
         {
             return DmNhomvattu1Dao.GetObjectAllByDonviID(DonViId);
         }


         public IList<DmNhomvattu1> GetByMaNhomVT(string MaNhom, Guid DonViId)
         {
             return DmNhomvattu1Dao.GetByMaNhomVT(MaNhom,DonViId);
         }
         public IList<DmNhomvattu1> GetAllByNhom(Guid DonViId, Decimal LoaiNhom)
         {
             return DmNhomvattu1Dao.GetAllByNhom(DonViId, LoaiNhom);
         }
    }
}
