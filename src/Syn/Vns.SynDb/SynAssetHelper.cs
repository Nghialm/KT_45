using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.SynDb
{
    public class SynAssetHelper
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

        #region DmTscd
        private IDmTscdService _DmTscdService;

        private IDmTscdService _DmTscdServiceSyn;

        public IDmTscdService DmTscdService
        {
            get
            {
                return _DmTscdService;
            }

            set
            {
                _DmTscdService = value;
            }
        }

        public ICtTscdService CtTscdService;
        public ITsLsKhauhaoService TsLsKhauhaoService;
        public ITsTscdPtungService TsTscdPtungService;
        public ITsDieuchuyenService TsDieuchuyenService;
        public ITsCtTscdNvonService TsCtTscdNvonService;

        public IDmTscdService DmTscdServiceSyn
        {
            get
            {
                return _DmTscdServiceSyn;
            }

            set
            {
                _DmTscdServiceSyn = value;
            }
        }

        public void SynDmTscd(Guid DonviId)
        {
            IList<DmTscd> lstClient = new List<DmTscd>();
            lstClient = new List<DmTscd>(_DmTscdService.GetByDonviID(DonviId));

            foreach (DmTscd client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    List<CtTscd> lsCtTscd = new List<CtTscd>(CtTscdService.GetByDmTscdId(client.Id));
                    List<TsCtTscdNvon> lsTsCtTscdNVon = new List<TsCtTscdNvon>(TsCtTscdNvonService.GetByDmTscdId(client.Id));
                    List<TsTscdPtung> lsTsTscdPtung = new List<TsTscdPtung>(TsTscdPtungService.GetByTscdId(client.Id));
                    List<TsDieuchuyen> lsTsDieuchuyen = new List<TsDieuchuyen>(TsDieuchuyenService.GetByDmTscdId(client.Id));
                    List<TsLsKhauhao> lsTsLsKhauhao = new List<TsLsKhauhao>(TsLsKhauhaoService.GetByTscdId(client.Id));

                    client.SynDate = DateTime.Now;
                    _DmTscdServiceSyn.SaveData4Syn(client, lsCtTscd, lsTsCtTscdNVon, lsTsDieuchuyen,
                        lsTsLsKhauhao, lsTsTscdPtung);

                    _DmTscdService.SaveOrUpdate(client);
                }
            }
        }
        #endregion
    }
}
