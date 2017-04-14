#region License

/*
 * Copyright © 2002-2011 the original author or authors.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region Imports

using System;

using Spring.Context;
using Spring.Context.Support;

using System.Collections.Generic;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Wcf.Client;

#endregion

namespace Vns.Erp.Core.ClientApp
{
	class Program
	{
        static WcfAuthenticationService _LoginService = new WcfAuthenticationService();

        public static WcfAuthenticationService LoginService
        {
            get { return _LoginService; }
            set { _LoginService = value; }
        }

		[STAThread]
		static void Main()
		{
			try
			{
                
                //bool ok = LoginService.Login("admin", "admin", "", true);
                //Pause();                
				IApplicationContext ctx = ContextRegistry.GetContext();

                IHtDanhmucService HtDanhmucService = (IHtDanhmucService)ctx.GetObject("HtDanhmucService");
                IList<HtDanhmuc> list = HtDanhmucService.GetAll();
                IAppCtStatusService AppCtStatusService = (IAppCtStatusService)ctx.GetObject("WcfAppCtStatusService");
                IList<AppCtStatus> listAppCtStatus = AppCtStatusService.GetAll();
                Console.WriteLine("Get AppDvBcService...");
                IAppDvBcService firstCalc = (IAppDvBcService)ctx.GetObject("AppDvBcService");
                //AppDvBc o = firstCalc.Get((decimal)1.00);
                //IList <AppDvBc> list = firstCalc.List(1, 10, null, null, null);

                //IAppUsersService appUsersService = (IAppUsersService)ctx.GetObject("AppUsersService");
                IDmDonviService test = (IDmDonviService)ctx.GetObject("DmDonviService");
                IAppUsersService appUsersService = (IAppUsersService)ctx.GetObject("AppUsersService");
                
                IAppGroupsService AppGroupsService = (IAppGroupsService)ctx.GetObject("AppGroupsService");
                IList<AppGroups> listAppGroups = AppGroupsService.List(-1, -1, null, null, null);
			}
			catch (Exception e)
			{
                Console.WriteLine(e);
			}
			finally
			{
                Pause();
			}
		}

        public static void Pause()
        {
            Console.Write("--- Press <return> to continue ---");
            Console.ReadLine();
        }
	}
}