/*
insert license info here
*/
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
namespace Vns.Erp.Core.Asset.Dao
{
	/// <summary>
	///	Generated by MyGeneration using the NHibernate Object Mapping adapted by Gustavo
	/// </summary>	
	public interface IDmNhomTscdDao:IDao<DmNhomTscd,Guid>
	{
        IList<DmNhomTscd> GetAllByDonviID(Guid DonviId);
        IList<DmNhomTscd> GetMA_NHOM_TSCD(string MaNhom);
	}
}
