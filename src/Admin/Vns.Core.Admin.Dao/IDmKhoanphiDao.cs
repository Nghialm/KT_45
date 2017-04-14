/*
insert license info here
*/
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
namespace Vns.Erp.Core.Admin.Dao
{
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
	/// </summary>	
	public interface IDmKhoanphiDao:IDao<DmKhoanphi,Guid>
	{
        int GetNumberDmKhoanphiByKyHieu(Guid DonviId, string KyHieu);
        IList<DmKhoanphi> GetAllByDonviID(Guid DonviId);
	}
}
