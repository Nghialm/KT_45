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
    public class AppDvGroupUserService : GenericService<AppDvGroupUser, Guid>, IAppDvGroupUserService
    {
        public IAppDvGroupUserDao AppDvGroupUserDao
        {
            get { return (IAppDvGroupUserDao)Dao; }
            set { Dao = value; }
        }

        public void DeleteByG(Guid groupid)
        {
            AppDvGroupUserDao.DeleteByG(groupid);
        }
        public void DeleteByU(Guid USER_ID)
        {
            AppDvGroupUserDao.DeleteByU(USER_ID); 
        }
        public IList<AppDvGroupUser> GetByUser(Guid UserId)
        {
            //ArrayList props = new ArrayList();
            //ArrayList values = new ArrayList();
            //props.Add("UserId");
            //values.Add(UserId);
            return AppDvGroupUserDao.GetByUser(UserId);
        }
        public IList<AppDvGroupUser> GetDVUser(Guid donviID, Guid UserId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("DvId");
            props.Add("UserId");
            values.Add(donviID);
            values.Add(UserId);
            return AppDvGroupUserDao.List(-1, -1,props, values, null);
        }


        public void DeleteByDU(Guid DV_ID, Guid USER_ID)
        {
            AppDvGroupUserDao.DeleteByDU(DV_ID, USER_ID); 
        }

        public void DeleteByDVGU(Guid DV_ID, Guid GROUP_ID, Guid USER_ID)
        {
            AppDvGroupUserDao.DeleteByDVGU(DV_ID, GROUP_ID, USER_ID);
        }

        public void DeleteByDVG(Guid DV_ID, Guid GROUP_ID)
        {
            AppDvGroupUserDao.DeleteByDVG(DV_ID, GROUP_ID);
        }

    }
}