using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Vns.UpdateProgram
{
    public class UpdateHelper
    {
        //http://kt45.somee.com/kt45/Vns.Core.Admin.Dao.dll
        public string remoteUri = "http://kt45.somee.com/kt45/";

        public UploadResponse DownloadFile(string folder, string fileName)
        {
            UploadResponse objResponse = new UploadResponse();
            try
            {
                remoteUri = Global.Download;
                // Create a new WebClient instance.
                WebClient myWebClient = new WebClient();
                // Concatenate the domain with the Web resource filename.
                string myStringWebResource = remoteUri + fileName;
                // Check folder
                if (!string.IsNullOrEmpty(folder))
                {
                    string[] arrfolder = folder.Split('/');
                    string parentfolder = "";
                    foreach (string fol in arrfolder)
                    {
                        if (!Directory.Exists(fol) && !string.IsNullOrEmpty(fol))
                        {
                            string createfolder = "";
                            if (!string.IsNullOrEmpty(parentfolder))
                                createfolder = parentfolder + @"\" + fol;
                            else
                                createfolder = fol;
                            Directory.CreateDirectory(createfolder);
                            parentfolder = createfolder;
                        }
                    }
                }
                // Download the Web resource and save it into the current filesystem folder.
                // Rename client if has ext is .zip
                fileName = fileName.Replace(".zip", "");
                myWebClient.DownloadFile(myStringWebResource, fileName);
                objResponse.code = 0;
                objResponse.message = String.Format("Successfully Downloaded File {0}", fileName);
                return objResponse;
            }
            catch (Exception ex)
            {
                objResponse.code = 1;
                objResponse.message = String.Format("UnSuccessfully Downloaded File {0}", fileName);
                return objResponse;
            }
        }
    }

    public class UploadResponse
    {
        public int code
        { get; set; }

        public string message
        { get; set; }
    }
}
