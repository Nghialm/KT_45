using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AppLogbookService : GenericService<AppLogbook, Guid>, IAppLogbookService
    {
        public enum UserActionEnum
        {
            UserLogin = 1,
            UserLogOut = 2,
            UserOpenScreen = 3,
            UserCloseScreen = 4
        }

        public IAppLogbookDao AppLogbookDao
        {
            get { return (IAppLogbookDao)Dao; }
            set { Dao = value; }
        }

        #region "Bussiness Functions"
        public void UserLogin(Decimal LogInUser)
        {
            Insert(LogInUser, UserActionEnum.UserLogin, "User Login", "");
        }
        //
        public void UserLogOut(Decimal LogInUser)
        {
            Insert(LogInUser, UserActionEnum.UserLogOut, "User LogOut", "");
        }
        //
        public void UserOpenScreen(Decimal LogInUser, string FormDesc, string FormName)
        {
            Insert(LogInUser, UserActionEnum.UserOpenScreen, FormDesc, FormName);
        }
        //
        public void UserCloseScreen(Decimal LogInUser, string FormDesc, string FormName)
        {
            Insert(LogInUser, UserActionEnum.UserCloseScreen, FormDesc, FormName);
        }

        public void Insert(Decimal LogInUser, UserActionEnum LogAction, string LogDescription, string FormName)
        {
            string ComputerName = Environment.MachineName;
            string WindowsUser = Environment.UserName;

            AppLogbook applogbook = new AppLogbook();
            applogbook.ComputerName = ComputerName;
            applogbook.WindowsUser = WindowsUser;
            applogbook.LogAction = LogAction.ToString();
            applogbook.LogDescription = LogDescription;
            applogbook.FormName = FormName;
            applogbook.UserId = LogInUser;

            AppLogbookDao.Save(applogbook);
        }
        #endregion
    }
}
