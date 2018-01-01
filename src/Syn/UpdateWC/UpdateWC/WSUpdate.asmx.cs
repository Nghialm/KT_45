using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UpdateWC
{
    /// <summary>
    /// Summary description for WSUpdate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSUpdate : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        [WebMethod]
        public List<FileVersion> UpdateVersion(List<FileVersion> lstcli)
        {
            // Read csv file
            

            List<FileVersion> lstser = FileHelper.ReadCsvFile();
            List<FileVersion> lstUpdate = FileHelper.ListFileUpdate(lstcli, lstser);
            
            return lstUpdate;
        } 
    }
}
