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
	public interface IDmLoaitaisanDao:IDao<DmLoaitaisan,Guid>
	{
        IList<DmLoaitaisan> GetByKyHieu(string KyHieu);
	}
}
