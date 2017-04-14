using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core;
using System.Collections;
using System.IO;

namespace Vns.Erp.UtilGUI
{
    public partial class FrmBackupDb : Form
    {
        #region Property
        private ICtHService _CtHService;
        public ICtHService CtHService
        {
            get { return _CtHService; }
            set { _CtHService = value; }
        }

        private ICtHNxService _CtHNxService;
        public ICtHNxService CtHNxService
        {
            get { return _CtHNxService; }
            set { _CtHNxService = value; }
        }

        private IKtCtHHddvService _KtCtHHddvService;
        public IKtCtHHddvService KtCtHHddvService
        {
            get { return _KtCtHHddvService; }
            set { _KtCtHHddvService = value; }
        }

        private IKtCtHKhacService _KtCtHKhacService;
        public IKtCtHKhacService KtCtHKhacService
        {
            get { return _KtCtHKhacService; }
            set { _KtCtHKhacService = value; }
        }
        #endregion

        public FrmBackupDb()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string sfolder = txtBackupPath.Text;
            string stmpfolder = sfolder + "\\Data";
            if (!Directory.Exists(stmpfolder))
            {
                Directory.CreateDirectory(stmpfolder);
            }

            IList<CtH> lst = new List<CtH>();
            lst = _CtHService.GetByDonviId(Generals.DonviID);
            SerializerUtil.writeObject((IList)lst, stmpfolder + "\\cth.scr");

            IList<CtHNx> lstNx = new List<CtHNx>();
            lstNx = _CtHNxService.GetByDonviId(Generals.DonviID);
            SerializerUtil.writeObject((IList)lstNx, stmpfolder + "\\cthnx.scr");

            IList<KtCtHHddv> lstHddv = new List<KtCtHHddv>();
            lstHddv = _KtCtHHddvService.GetByDonviId(Generals.DonviID);
            SerializerUtil.writeObject((IList)lstHddv, stmpfolder + "\\cthhddv.scr");

            IList<KtCtHKhac> lstKhac = new List<KtCtHKhac>();
            lstKhac = _KtCtHKhacService.GetByDonviId(Generals.DonviID);
            SerializerUtil.writeObject((IList)lstKhac, stmpfolder + "\\cthkhac.scr");

            DateTime currentTime = System.DateTime.Now;
            String strTime = currentTime.Year + "_" + currentTime.Month + "_" + currentTime.Day.ToString() + currentTime.Hour.ToString() + currentTime.Minute.ToString();
            String zipFilePath = sfolder + "\\" + "data" + strTime + ".zip";



            ZipUtil.CompressDirectory(stmpfolder, zipFilePath);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string sFile = txtRestoreFile.Text;
            ZipUtil.DecompressToDirectory(sFile, "data");

            IList<CtH> lst = new List<CtH>();
            lst = (IList<CtH>) SerializerUtil.readObject("data\\cth.scr");

            IList<CtHNx> lstNx = new List<CtHNx>();
            lstNx = (IList<CtHNx>)SerializerUtil.readObject("data\\cthnx.scr");

            IList<KtCtHHddv> lstHddv = new List<KtCtHHddv>();
            lstHddv = (IList<KtCtHHddv>)SerializerUtil.readObject("data\\cthhddv.scr");

            IList<KtCtHKhac> lstKhac = new List<KtCtHKhac>();
            lstKhac = (IList<KtCtHKhac>)SerializerUtil.readObject("data\\cthkhac.scr");
        }



    }
}
