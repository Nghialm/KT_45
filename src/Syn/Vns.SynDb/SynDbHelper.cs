using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Asset.Domain;
using Vns.Erp.Core.Asset.Service.Interface;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.SynDb
{
    public class SynDbHelper
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
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    client.NgayTao = DateTime.Now;
                    client.NgaySua = DateTime.Now;
                    _DmTaiKhoanServiceSyn.SaveOrUpdate(client);
                    _DmTaiKhoanService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm khach hang
        private IDmKhangService _DmKhangService;
        private IDmKhangService _DmKhangServiceSyn;

        public IDmKhangService DmKhangService
        {
            get
            {
                return _DmKhangService;
            }

            set
            {
                _DmKhangService = value;
            }
        }

        public IDmKhangService DmKhangServiceSyn
        {
            get
            {
                return _DmKhangServiceSyn;
            }

            set
            {
                _DmKhangServiceSyn = value;
            }
        }

        public void SynDmKhang(Guid DonviId)
        {
            IList<DmKhang> lstClient = new List<DmKhang>();
            lstClient = new List<DmKhang>(_DmKhangService.GetAllByDonviID(DonviId));

            foreach (DmKhang client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmKhangServiceSyn.SaveOrUpdate(client);
                    _DmKhangService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm hang hoa
        private IDmHanghoaService _DmHanghoaService;
        private IDmHanghoaService _DmHanghoaServiceSyn;

        public IDmHanghoaService DmHanghoaService
        {
            get
            {
                return _DmHanghoaService;
            }

            set
            {
                _DmHanghoaService = value;
            }
        }

        public IDmHanghoaService DmHanghoaServiceSyn
        {
            get
            {
                return _DmHanghoaServiceSyn;
            }

            set
            {
                _DmHanghoaServiceSyn = value;
            }
        }

        public void SynDmHanghoa(Guid DonviId)
        {
            IList<DmHanghoa> lstClient = new List<DmHanghoa>();
            lstClient = new List<DmHanghoa>(_DmHanghoaService.GetAllByDonviID(DonviId));

            foreach (DmHanghoa client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmHanghoaServiceSyn.SaveOrUpdate(client);
                    _DmHanghoaService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm hop dong
        private IDmHopdongService _DmHopdongService;
        private IDmHopdongService _DmHopdongServiceSyn;

        public IDmHopdongService DmHopdongService
        {
            get
            {
                return _DmHopdongService;
            }

            set
            {
                _DmHopdongService = value;
            }
        }

        public IDmHopdongService DmHopdongServiceSyn
        {
            get
            {
                return _DmHopdongServiceSyn;
            }

            set
            {
                _DmHopdongServiceSyn = value;
            }
        }

        public void SynDmHopdong(Guid DonviId)
        {
            IList<DmHopdong> lstClient = new List<DmHopdong>();
            lstClient = new List<DmHopdong>(_DmHopdongService.GetAllByDonviID(DonviId));

            foreach (DmHopdong client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmHopdongServiceSyn.SaveOrUpdate(client);
                    _DmHopdongService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm don vi tinh
        private IDmDvtService _DmDvtService;
        private IDmDvtService _DmDvtServiceSyn;

        public IDmDvtService DmDvtService
        {
            get
            {
                return _DmDvtService;
            }

            set
            {
                _DmDvtService = value;
            }
        }

        public IDmDvtService DmDvtServiceSyn
        {
            get
            {
                return _DmDvtServiceSyn;
            }

            set
            {
                _DmDvtServiceSyn = value;
            }
        }

        public void SynDmDvt(Guid DonviId)
        {
            IList<DmDvt> lstClient = new List<DmDvt>();
            lstClient = new List<DmDvt>(_DmDvtService.GetAllByDonviID(DonviId));

            foreach (DmDvt client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmDvtServiceSyn.SaveOrUpdate(client);
                    _DmDvtService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm kho
        private IDmKhoService _DmKhoService;
        private IDmKhoService _DmKhoServiceSyn;

        public IDmKhoService DmKhoService
        {
            get
            {
                return _DmKhoService;
            }

            set
            {
                _DmKhoService = value;
            }
        }

        public IDmKhoService DmKhoServiceSyn
        {
            get
            {
                return _DmKhoServiceSyn;
            }

            set
            {
                _DmKhoServiceSyn = value;
            }
        }

        public void SynDmKho(Guid DonviId)
        {
            IList<DmKho> lstClient = new List<DmKho>();
            lstClient = new List<DmKho>(_DmKhoService.GetAllByDonviID(DonviId));

            foreach (DmKho client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmKhoServiceSyn.SaveOrUpdate(client);
                    _DmKhoService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm Khoan phi
        private IDmKhoanphiService _DmKhoanphiService;
        private IDmKhoanphiService _DmKhoanphiServiceSyn;

        public IDmKhoanphiService DmKhoanphiService
        {
            get
            {
                return _DmKhoanphiService;
            }

            set
            {
                _DmKhoanphiService = value;
            }
        }

        public IDmKhoanphiService DmKhoanphiServiceSyn
        {
            get
            {
                return _DmKhoanphiServiceSyn;
            }

            set
            {
                _DmKhoanphiServiceSyn = value;
            }
        }

        public void SynDmKhoanphi(Guid DonviId)
        {
            IList<DmKhoanphi> lstClient = new List<DmKhoanphi>();
            lstClient = new List<DmKhoanphi>(_DmKhoanphiService.GetAllByDonviID(DonviId));

            foreach (DmKhoanphi client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmKhoanphiServiceSyn.SaveOrUpdate(client);
                    _DmKhoanphiService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm Don vi
        private IDmDonviService _DmDonviService;
        private IDmDonviService _DmDonviServiceSyn;

        public IDmDonviService DmDonviService
        {
            get
            {
                return _DmDonviService;
            }

            set
            {
                _DmDonviService = value;
            }
        }

        public IDmDonviService DmDonviServiceSyn
        {
            get
            {
                return _DmDonviServiceSyn;
            }

            set
            {
                _DmDonviServiceSyn = value;
            }
        }

        public void SynDmDonvi(Guid DonviId)
        {
            IList<DmDonvi> lstClient = new List<DmDonvi>();
            lstClient.Add(_DmDonviService.GetById(DonviId));

            foreach (DmDonvi client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmDonviServiceSyn.SaveOrUpdate(client);
                    _DmDonviService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm Loai tai san
        private IDmLoaitaisanService _DmLoaitaisanService;
        private IDmLoaitaisanService _DmLoaitaisanServiceSyn;

        public IDmLoaitaisanService DmLoaitaisanService
        {
            get
            {
                return _DmLoaitaisanService;
            }

            set
            {
                _DmLoaitaisanService = value;
            }
        }

        public IDmLoaitaisanService DmLoaitaisanServiceSyn
        {
            get
            {
                return _DmLoaitaisanServiceSyn;
            }

            set
            {
                _DmLoaitaisanServiceSyn = value;
            }
        }

        public void SynDmLoaitaisan(Guid DonviId)
        {
            IList<DmLoaitaisan> lstClient = new List<DmLoaitaisan>();
            lstClient = new List<DmLoaitaisan>(_DmLoaitaisanService.GetAll());

            foreach (DmLoaitaisan client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmLoaitaisanServiceSyn.SaveOrUpdate(client);
                    _DmLoaitaisanService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm Ly do tg Tscd
        private IDmLydoTgTscdService _DmLydoTgTscdService;
        private IDmLydoTgTscdService _DmLydoTgTscdServiceSyn;

        public IDmLydoTgTscdService DmLydoTgTscdService
        {
            get
            {
                return _DmLydoTgTscdService;
            }

            set
            {
                _DmLydoTgTscdService = value;
            }
        }

        public IDmLydoTgTscdService DmLydoTgTscdServiceSyn
        {
            get
            {
                return _DmLydoTgTscdServiceSyn;
            }

            set
            {
                _DmLydoTgTscdServiceSyn = value;
            }
        }

        public void SynDmLydoTgTscd(Guid DonviId)
        {
            IList<DmLydoTgTscd> lstClient = new List<DmLydoTgTscd>();
            lstClient = new List<DmLydoTgTscd>(_DmLydoTgTscdService.GetAllByDonviID(DonviId));

            foreach (DmLydoTgTscd client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmLydoTgTscdServiceSyn.SaveOrUpdate(client);
                    _DmLydoTgTscdService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm ngoai te
        private IDmNgoaiteService _DmNgoaiteService;
        private IDmNgoaiteService _DmNgoaiteServiceSyn;

        public IDmNgoaiteService DmNgoaiteService
        {
            get
            {
                return _DmNgoaiteService;
            }

            set
            {
                _DmNgoaiteService = value;
            }
        }

        public IDmNgoaiteService DmNgoaiteServiceSyn
        {
            get
            {
                return _DmNgoaiteServiceSyn;
            }

            set
            {
                _DmNgoaiteServiceSyn = value;
            }
        }

        public void SynDmNgoaite(Guid DonviId)
        {
            IList<DmNgoaite> lstClient = new List<DmNgoaite>();
            lstClient = new List<DmNgoaite>(_DmNgoaiteService.GetAll());

            foreach (DmNgoaite client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmNgoaiteServiceSyn.SaveOrUpdate(client);
                    _DmNgoaiteService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm nguon tai san co dinh
        private IDmNguonTscdService _DmNguonTscdService;
        private IDmNguonTscdService _DmNguonTscdServiceSyn;

        public IDmNguonTscdService DmNguonTscdService
        {
            get
            {
                return _DmNguonTscdService;
            }

            set
            {
                _DmNguonTscdService = value;
            }
        }

        public IDmNguonTscdService DmNguonTscdServiceSyn
        {
            get
            {
                return _DmNguonTscdServiceSyn;
            }

            set
            {
                _DmNguonTscdServiceSyn = value;
            }
        }

        public void SynDmNguonTscd(Guid DonviId)
        {
            IList<DmNguonTscd> lstClient = new List<DmNguonTscd>();
            lstClient = new List<DmNguonTscd>(_DmNguonTscdService.GetAllByDonviID(DonviId));

            foreach (DmNguonTscd client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmNguonTscdServiceSyn.SaveOrUpdate(client);
                    _DmNguonTscdService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm nhom tscd
        private IDmNhomTscdService _DmNhomTscdService;
        private IDmNhomTscdService _DmNhomTscdServiceSyn;

        public IDmNhomTscdService DmNhomTscdService
        {
            get
            {
                return _DmNhomTscdService;
            }

            set
            {
                _DmNhomTscdService = value;
            }
        }

        public IDmNhomTscdService DmNhomTscdServiceSyn
        {
            get
            {
                return _DmNhomTscdServiceSyn;
            }

            set
            {
                _DmNhomTscdServiceSyn = value;
            }
        }

        public void SynDmNhomTscd(Guid DonviId)
        {
            IList<DmNhomTscd> lstClient = new List<DmNhomTscd>();
            lstClient = new List<DmNhomTscd>(_DmNhomTscdService.GetAllByDonviID(DonviId));

            foreach (DmNhomTscd client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmNhomTscdServiceSyn.SaveOrUpdate(client);
                    _DmNhomTscdService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm nhom tscd
        private IDmNhomKhangService _DmNhomKhangService;
        private IDmNhomKhangService _DmNhomKhangServiceSyn;

        public IDmNhomKhangService DmNhomKhangService
        {
            get
            {
                return _DmNhomKhangService;
            }

            set
            {
                _DmNhomKhangService = value;
            }
        }

        public IDmNhomKhangService DmNhomKhangServiceSyn
        {
            get
            {
                return _DmNhomKhangServiceSyn;
            }

            set
            {
                _DmNhomKhangServiceSyn = value;
            }
        }

        public void SynDmNhomKhang(Guid DonviId)
        {
            IList<DmNhomKhang> lstClient = new List<DmNhomKhang>();
            lstClient = new List<DmNhomKhang>(_DmNhomKhangService.GetObjectAllByDonviID(DonviId));

            foreach (DmNhomKhang client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmNhomKhangServiceSyn.SaveOrUpdate(client);
                    _DmNhomKhangService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm nhom vat tu 1
        private IDmNhomvattu1Service _DmNhomvattu1Service;
        private IDmNhomvattu1Service _DmNhomvattu1ServiceSyn;

        public IDmNhomvattu1Service DmNhomvattu1Service
        {
            get
            {
                return _DmNhomvattu1Service;
            }

            set
            {
                _DmNhomvattu1Service = value;
            }
        }

        public IDmNhomvattu1Service DmNhomvattu1ServiceSyn
        {
            get
            {
                return _DmNhomvattu1ServiceSyn;
            }

            set
            {
                _DmNhomvattu1ServiceSyn = value;
            }
        }

        public void SynDmNhomvattu1(Guid DonviId)
        {
            IList<DmNhomvattu1> lstClient = new List<DmNhomvattu1>();
            lstClient = new List<DmNhomvattu1>(_DmNhomvattu1Service.GetObjectAllByDonviID(DonviId));

            foreach (DmNhomvattu1 client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmNhomvattu1ServiceSyn.SaveOrUpdate(client);
                    _DmNhomvattu1Service.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm phong ban
        private IDmPhongbanService _DmPhongbanService;
        private IDmPhongbanService _DmPhongbanServiceSyn;

        public IDmPhongbanService DmPhongbanService
        {
            get
            {
                return _DmPhongbanService;
            }

            set
            {
                _DmPhongbanService = value;
            }
        }

        public IDmPhongbanService DmPhongbanServiceSyn
        {
            get
            {
                return _DmPhongbanServiceSyn;
            }

            set
            {
                _DmPhongbanServiceSyn = value;
            }
        }

        public void SynDmPhongban(Guid DonviId)
        {
            IList<DmPhongban> lstClient = new List<DmPhongban>();
            lstClient = new List<DmPhongban>(_DmPhongbanService.GetAllByDonviID(DonviId));

            foreach (DmPhongban client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmPhongbanServiceSyn.SaveOrUpdate(client);
                    _DmPhongbanService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm ptqt
        private IDmPtqtService _DmPtqtService;
        private IDmPtqtService _DmPtqtServiceSyn;

        public IDmPtqtService DmPtqtService
        {
            get
            {
                return _DmPtqtService;
            }

            set
            {
                _DmPtqtService = value;
            }
        }

        public IDmPtqtService DmPtqtServiceSyn
        {
            get
            {
                return _DmPtqtServiceSyn;
            }

            set
            {
                _DmPtqtServiceSyn = value;
            }
        }

        public void SynDmPtqt(Guid DonviId)
        {
            IList<DmPtqt> lstClient = new List<DmPtqt>();
            lstClient = new List<DmPtqt>(_DmPtqtService.GetAllByDonviID(DonviId));

            foreach (DmPtqt client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmPtqtServiceSyn.SaveOrUpdate(client);
                    _DmPtqtService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm thue
        private IDmThueService _DmThueService;
        private IDmThueService _DmThueServiceSyn;

        public IDmThueService DmThueService
        {
            get
            {
                return _DmThueService;
            }

            set
            {
                _DmThueService = value;
            }
        }

        public IDmThueService DmThueServiceSyn
        {
            get
            {
                return _DmThueServiceSyn;
            }

            set
            {
                _DmThueServiceSyn = value;
            }
        }

        public void SynDmThue(Guid DonviId)
        {
            IList<DmThue> lstClient = new List<DmThue>();
            lstClient = new List<DmThue>(_DmThueService.GetAll());

            foreach (DmThue client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmThueServiceSyn.SaveOrUpdate(client);
                    _DmThueService.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm tu do 1
        private IDmTudo1Service _DmTudo1Service;
        private IDmTudo1Service _DmTudo1ServiceSyn;

        public IDmTudo1Service DmTudo1Service
        {
            get
            {
                return _DmTudo1Service;
            }

            set
            {
                _DmTudo1Service = value;
            }
        }

        public IDmTudo1Service DmTudo1ServiceSyn
        {
            get
            {
                return _DmTudo1ServiceSyn;
            }

            set
            {
                _DmTudo1ServiceSyn = value;
            }
        }

        public void SynDmTudo1(Guid DonviId)
        {
            IList<DmTudo1> lstClient = new List<DmTudo1>();
            lstClient = new List<DmTudo1>(_DmTudo1Service.GetAllByDonviID(DonviId));

            foreach (DmTudo1 client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmTudo1ServiceSyn.SaveOrUpdate(client);
                    _DmTudo1Service.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm tu do 2
        private IDmTudo2Service _DmTudo2Service;
        private IDmTudo2Service _DmTudo2ServiceSyn;

        public IDmTudo2Service DmTudo2Service
        {
            get
            {
                return _DmTudo2Service;
            }

            set
            {
                _DmTudo2Service = value;
            }
        }

        public IDmTudo2Service DmTudo2ServiceSyn
        {
            get
            {
                return _DmTudo2ServiceSyn;
            }

            set
            {
                _DmTudo2ServiceSyn = value;
            }
        }

        public void SynDmTudo2(Guid DonviId)
        {
            IList<DmTudo2> lstClient = new List<DmTudo2>();
            lstClient = new List<DmTudo2>(_DmTudo2Service.GetAllByDonviID(DonviId));

            foreach (DmTudo2 client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmTudo2ServiceSyn.SaveOrUpdate(client);
                    _DmTudo2Service.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm tu do 3
        private IDmTudo3Service _DmTudo3Service;
        private IDmTudo3Service _DmTudo3ServiceSyn;

        public IDmTudo3Service DmTudo3Service
        {
            get
            {
                return _DmTudo3Service;
            }

            set
            {
                _DmTudo3Service = value;
            }
        }

        public IDmTudo3Service DmTudo3ServiceSyn
        {
            get
            {
                return _DmTudo3ServiceSyn;
            }

            set
            {
                _DmTudo3ServiceSyn = value;
            }
        }

        public void SynDmTudo3(Guid DonviId)
        {
            IList<DmTudo3> lstClient = new List<DmTudo3>();
            lstClient = new List<DmTudo3>(_DmTudo3Service.GetAllByDonviID(DonviId));

            foreach (DmTudo3 client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmTudo3ServiceSyn.SaveOrUpdate(client);
                    _DmTudo3Service.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm tu do 4
        private IDmTudo4Service _DmTudo4Service;
        private IDmTudo4Service _DmTudo4ServiceSyn;

        public IDmTudo4Service DmTudo4Service
        {
            get
            {
                return _DmTudo4Service;
            }

            set
            {
                _DmTudo4Service = value;
            }
        }

        public IDmTudo4Service DmTudo4ServiceSyn
        {
            get
            {
                return _DmTudo4ServiceSyn;
            }

            set
            {
                _DmTudo4ServiceSyn = value;
            }
        }

        public void SynDmTudo4(Guid DonviId)
        {
            IList<DmTudo4> lstClient = new List<DmTudo4>();
            lstClient = new List<DmTudo4>(_DmTudo4Service.GetAllByDonviID(DonviId));

            foreach (DmTudo4 client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmTudo4ServiceSyn.SaveOrUpdate(client);
                    _DmTudo4Service.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm tu do 5
        private IDmTudo5Service _DmTudo5Service;
        private IDmTudo5Service _DmTudo5ServiceSyn;

        public IDmTudo5Service DmTudo5Service
        {
            get
            {
                return _DmTudo5Service;
            }

            set
            {
                _DmTudo5Service = value;
            }
        }

        public IDmTudo5Service DmTudo5ServiceSyn
        {
            get
            {
                return _DmTudo5ServiceSyn;
            }

            set
            {
                _DmTudo5ServiceSyn = value;
            }
        }

        public void SynDmTudo5(Guid DonviId)
        {
            IList<DmTudo5> lstClient = new List<DmTudo5>();
            lstClient = new List<DmTudo5>(_DmTudo5Service.GetAllByDonviID(DonviId));

            foreach (DmTudo5 client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmTudo5ServiceSyn.SaveOrUpdate(client);
                    _DmTudo5Service.SaveOrUpdate(client);
                }
            }
        }
        #endregion

        #region Dm vu viec
        private IDmVuviecService _DmVuviecService;
        private IDmVuviecService _DmVuviecServiceSyn;

        public IDmVuviecService DmVuviecService
        {
            get
            {
                return _DmVuviecService;
            }

            set
            {
                _DmVuviecService = value;
            }
        }

        public IDmVuviecService DmVuviecServiceSyn
        {
            get
            {
                return _DmVuviecServiceSyn;
            }

            set
            {
                _DmVuviecServiceSyn = value;
            }
        }


        public void SynDmVuviec(Guid DonviId)
        {
            IList<DmVuviec> lstClient = new List<DmVuviec>();
            lstClient = new List<DmVuviec>(_DmVuviecService.GetAllByDonviID(DonviId));

            foreach (DmVuviec client in lstClient)
            {
                if (client.SynDate == Null.MIN_DATE || _IsSynAll)
                {
                    client.SynDate = DateTime.Now;
                    _DmVuviecServiceSyn.SaveOrUpdate(client);
                    _DmVuviecService.SaveOrUpdate(client);
                }
            }
        }
        #endregion
    }
}