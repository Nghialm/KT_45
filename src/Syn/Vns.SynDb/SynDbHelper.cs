using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Domain;

namespace Vns.SynDb
{
    public class SynDbHelper
    {
        #region Dm tai khoan
        private IDmTaikhoanService _DmTaiKhoanService;
        private IDmTaikhoanService _DmTaiKhoanServiceSyn;

        public IDmTaikhoanService DmTaiKhoanService
        {
            get
            {
                return _DmTaiKhoanService;
            }

            set
            {
                _DmTaiKhoanService = value;
            }
        }

        public IDmTaikhoanService DmTaiKhoanServiceSyn
        {
            get
            {
                return _DmTaiKhoanServiceSyn;
            }

            set
            {
                _DmTaiKhoanServiceSyn = value;
            }
        }

        public void SynDmTaiKhoan(Guid DonviId)
        {
            IList<DmTaikhoan> lstClient = new List<DmTaikhoan>();
            lstClient = new List<DmTaikhoan>(_DmTaiKhoanService.GetAllByDonviID(DonviId));

            foreach (DmTaikhoan client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE)
                {
                    client.SynDate = DateTime.Now;
                    _DmTaiKhoanServiceSyn.SaveOrUpdate(client);
                    _DmTaiKhoanService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        


    }
}
