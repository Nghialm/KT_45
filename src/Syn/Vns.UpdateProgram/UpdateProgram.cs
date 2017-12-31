using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Vns.UpdateProgram.WSUpdate;

namespace Vns.UpdateProgram
{
    public partial class UpdateProgram : Form
    {
        public UpdateProgram()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int errCount = 0;
            List<WSUpdate.FileVersion> lstFileVer = new List<WSUpdate.FileVersion>();

            //Check webservice
            lstFileVer = CheckUpdate();
            if (lstFileVer.Count > 0)
            {
                KillProcess();
            }
            else
            {
                lblSummary.Text = "Mesage: Nothing for update!";
                return;
            }

            UpdateHelper objUpdate = new UpdateHelper();
            StringBuilder sProgressLog = new StringBuilder();
            foreach (WSUpdate.FileVersion objDownLoad in lstFileVer)
            {
                UploadResponse sLog = objUpdate.DownloadFile(objDownLoad.Folder, objDownLoad.FileName);
                sProgressLog.AppendLine(sLog.message);
                if (sLog.code == 1) errCount++;

                txtLog.Text = sProgressLog.ToString();
            }

            if (errCount > 0) lblSummary.Text = string.Format("Message: Update not successfull {0}", errCount);
            else lblSummary.Text = "Message: Update successfull";
        }

        public static void KillProcess()
        {
            System.Diagnostics.Process[] procs = null;

            try
            {
                procs = Process.GetProcessesByName("VKetoan");

                Process mspaintProc = procs[0];

                if (!mspaintProc.HasExited)
                {
                    mspaintProc.Kill();
                }
            }
            finally
            {
                if (procs != null)
                {
                    foreach (Process p in procs)
                    {
                        p.Dispose();
                    }
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<WSUpdate.FileVersion> CheckUpdate()
        {
            WSUpdateSoapClient wsUpdate = new WSUpdateSoapClient(Global.Endpoint);
            List<WSUpdate.FileVersion> lstcli = new List<WSUpdate.FileVersion>();
            lstcli = FileHelper.ReadCsvFile("file_version.csv");
            List<WSUpdate.FileVersion> lstUpdate = new List<WSUpdate.FileVersion>(wsUpdate.UpdateVersion(lstcli.ToArray()));

            return lstUpdate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Global.Endpoint1 = ConfigurationManager.AppSettings["Endpoint1"].ToString();
            Global.Endpoint2 = ConfigurationManager.AppSettings["Endpoint2"].ToString();

            Global.Download1 = ConfigurationManager.AppSettings["Download1"].ToString();
            Global.Download2 = ConfigurationManager.AppSettings["Download2"].ToString();

            //WSUpdateSoapClient wsUpdate = new WSUpdateSoapClient();
            HttpWebRequest myRequest;
            HttpWebResponse response;

            try
            {
                myRequest = (HttpWebRequest)WebRequest.Create(Global.Endpoint1);
                response = (HttpWebResponse)myRequest.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Global.Endpoint = Global.Endpoint1;
                    Global.Download = Global.Download1;
                    return;
                }
            }
            catch
            { }

            try
            {
                myRequest = (HttpWebRequest)WebRequest.Create(Global.Endpoint2);
                response = (HttpWebResponse)myRequest.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Global.Endpoint = Global.Endpoint2;
                    Global.Download = Global.Download2;
                    return;
                }
            }
            catch
            { }
        }
    }
}
