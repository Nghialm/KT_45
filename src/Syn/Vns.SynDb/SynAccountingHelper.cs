using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Service.Interface;

namespace Vns.Erp.Core.SynDb
{
    public class SynAccountingHelper
    {
        #region Property
        private Boolean _IsSynAll = false;

        public bool IsSynAll
        {
            get
            {
                return _IsSynAll;
            }

            set
            {
                _IsSynAll = value;
            }
        }
        #endregion

        #region CtH, CtD
        private ICtHService _CtHService;
        private ICtHService _CtHServiceSyn;

        public ICtHService CtHService
        {
            get
            {
                return _CtHService;
            }

            set
            {
                _CtHService = value;
            }
        }

        public ICtHService CtHServiceSyn
        {
            get
            {
                return _CtHServiceSyn;
            }

            set
            {
                _CtHServiceSyn = value;
            }
        }
        public void SynCtH(Guid DonviId)
        {
            IList<CtH> lstClient = new List<CtH>();
            lstClient = new List<CtH>(_CtHService.GetByLoaiChungTu(DonviId, String.Empty));

            foreach (CtH client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    List<CtD> lst = new List<CtD>(client.LstCtD);
                    client.SynDate = DateTime.Now;
                    _CtHServiceSyn.SaveData4Syn(client, lst);
                    _CtHService.SaveData4Syn(client, lst);
                }
            }
        }
        #endregion

        #region CtHoadon, CtThue
        private ICtHoadonService _CtHoadonService;
        private ICtHoadonService _CtHoadonServiceSyn;

        public ICtHoadonService CtHoadonService
        {
            get
            {
                return _CtHoadonService;
            }

            set
            {
                _CtHoadonService = value;
            }
        }

        public ICtHoadonService CtHoadonServiceSyn
        {
            get
            {
                return _CtHoadonServiceSyn;
            }

            set
            {
                _CtHoadonServiceSyn = value;
            }
        }
        public void SynCtHoadon(Guid DonviId)
        {
            IList<CtHoadon> lstClient = new List<CtHoadon>();
            lstClient = new List<CtHoadon>(_CtHoadonService.GetAllByDonviID(DonviId));

            foreach (CtHoadon client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    List<CtThue> lst = new List<CtThue>(client.LstCtThue);
                    client.SynDate = DateTime.Now;
                    _CtHoadonServiceSyn.SaveData4Syn(client, lst);
                }
            }
        }
        #endregion

        #region KCtHKhac, KCtDKhac
        private IKtCtHKhacService _KtCtHKhacService;
        private IKtCtHKhacService _KtCtHKhacServiceSyn;

        public IKtCtHKhacService KtCtHKhacService
        {
            get
            {
                return _KtCtHKhacService;
            }

            set
            {
                _KtCtHKhacService = value;
            }
        }

        public IKtCtHKhacService KtCtHKhacServiceSyn
        {
            get
            {
                return _KtCtHKhacServiceSyn;
            }

            set
            {
                _KtCtHKhacServiceSyn = value;
            }
        }
        public void SynKtCtHKhac(Guid DonviId)
        {
            IList<KtCtHKhac> lstClient = new List<KtCtHKhac>();
            lstClient = new List<KtCtHKhac>(_KtCtHKhacService.GetByDonviId(DonviId));

            foreach (KtCtHKhac client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    List<KtCtDKhac> lst = new List<KtCtDKhac>(client.LstKtCtDKhac);
                    client.SynDate = DateTime.Now;
                    KtCtHKhacServiceSyn.SaveData4Syn(client, lst);
                }
            }
        }
        #endregion
    }
}
