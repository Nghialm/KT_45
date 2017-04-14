
	/*
	insert license info here
	*/
	using System.Collections;
	using System.ComponentModel;
	using System.Data;	
	using Vns.Erp.Core.Admin.Service;
	using Vns.Erp.Core.Admin.Domain;
    using Vns.Erp.Core.Service.Interface;
using System.ServiceModel;
using System;	
	namespace Vns.Erp.Core.Admin.Service.Interface
	{
        [ServiceContract(Namespace = "http://SpringSample.Core.Service")]
		public interface IAppUsersService:IErpService<AppUsers, Guid>
		{
            [OperationContract]
            void ChangePassword(AppUsers objInfo);
            [OperationContract]
            string EncryptPassword(string Username, string Password);
            //Vns.Erp.Core.Admin.Domain.AppUsers GetById(decimal USERID);
            [OperationContract]
            Vns.Erp.Core.Admin.Domain.AppUsers GetByUsername(string Username);
            [OperationContract]
            Vns.Erp.Core.Admin.Domain.AppUsers GetByUsernameAndPass(string Username, string PASSWORD);
            [OperationContract]
            Vns.Erp.Core.Admin.Domain.AppUsers GetLast();
            [OperationContract]
            System.Collections.Generic.IList<AppUsers> GetUserByDV(System.Guid DONVI_ID);
            [OperationContract]
            System.Data.DataSet GetUserMenu(Guid USERID);
            [OperationContract]
            AppUsers Login(string userName, string password, Guid DonViId);
            [OperationContract]
            AppUsers LoginWithoutDonvi(string userName, String password);
		}
	}
	