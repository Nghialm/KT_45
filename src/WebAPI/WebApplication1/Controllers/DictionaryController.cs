using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/Dictionary")]
    public class DictionaryController : ApiController
    {
        [HttpGet]
        [Route("ListDonvi")]
        public IHttpActionResult GetDonvi()
        {
            IDmDonviService DonviService = (IDmDonviService)ObjectFactory.GetObject("DonviService");
            IList<DmDonvi> lstDonVi = new List<DmDonvi>();
            lstDonVi = DonviService.GetListDonVi();

            return Ok(lstDonVi);
        }
    }
}
