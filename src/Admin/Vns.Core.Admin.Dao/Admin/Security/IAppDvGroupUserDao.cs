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
    public interface IAppDvGroupUserDao : IDao<AppDvGroupUser, Guid>
	{
        IList<AppDvGroupUser> GetByUser(Guid UserId);
        void DeleteByG(Guid groupid);
        void DeleteByDU(Guid DV_ID, Guid USER_ID);
        void DeleteByU(Guid USER_ID);
        void DeleteByDVGU(Guid DV_ID, Guid GROUP_ID, Guid USER_ID);
        void DeleteByDVG(Guid DV_ID, Guid GROUP_ID);
	}
}
