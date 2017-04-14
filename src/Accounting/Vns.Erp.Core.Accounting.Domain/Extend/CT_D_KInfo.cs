using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using Vns.Erp.Core.Accounting.Domain;

namespace Vns.Erp.Core.Accounting.Domain.Extend
{
    public class CT_D_KInfo
    {

        #region "Private Variable"
        private Guid _CTD_ID;
        private Guid _CTH_ID;
        private Guid _TK_ID;
        private string _MA_TK;
        private string _TEN_TK;
        private decimal _PS_NO;
        private decimal _PS_CO;
        private decimal _PS_NO_NT;
        private decimal _PS_CO_NT;
        private string _NOI_DUNG;
        private Guid _ID_DM_HOPDONG;
        private string _MA_HOPDONG;
        private string _KY_HIEU_HOPDONG;
        private string _TEN_HOPDONG;
        private Guid _ID_DM_PTQT;
        private Guid _ID_DM_PHONGBAN;
        private Guid _ID_CT_GHISO;
        private string _MA_CT_GHISO_SO;
        private string _CT_GHISO_TRICHYEU;
        private DateTime? _CT_GHISO_NGAY;
        private decimal _DA_GHISO;
        private Guid _ID_DM_VUVIEC;
        private string _MA_VUVIEC;
        private string _KY_HIEU_VUVIEC;
        private Guid _ID_DM_TUDO_1;
        private Guid _ID_DM_TUDO_2;
        private Guid _ID_DM_TUDO_3;
        private Guid _ID_DM_TUDO_4;
        private Guid _ID_DM_TUDO_5;
        private decimal _LOAI_NGHIEP_VU;
        private Guid _ID_KHANG;
        private string _MA_KHANG;
        private string _KY_HIEU_KHANG;
        private string _TEN_KHANG;
        private Guid _ID_DOITUONG_1;
        private string _MA_DOITUONG_1;
        private string _TEN_DOITUONG_1;
        private Guid _ID_DOITUONG_2;
        private string _MA_DOITUONG_2;
        private string _TEN_DOITUONG_2;
        private Guid _ID_DOITUONG_3;
        private string _MA_DOITUONG_3;
        private string _TEN_DOITUONG_3;
        private Guid _ID_DM_KHOANPHI;
        private decimal _NHOM;
        private CtHoadon _CT_HOADON;
        private List<CtThue> _lstCT_THUE;
        private List<CtThue> _lstDelCT_THUE;
        private decimal _SO_DU;
        private Guid _ID_DOITUONG_HOADON;
        private string _MA_HOADON;
        private string _KY_HIEU_HOADON;
        private string _MA_RO;

        private string _TEN_RO;
        private decimal _PHAN_HE;
        private string _BX_1;
        private string _BX_2;

        private string _BX_3;
        #endregion

        #region "Property"
        public Guid CTD_ID
        {
            get { return _CTD_ID; }
            set { _CTD_ID = value; }
        }

        public Guid CTH_ID
        {
            get { return _CTH_ID; }
            set { _CTH_ID = value; }
        }

        public Guid TK_ID
        {
            get { return _TK_ID; }
            set { _TK_ID = value; }
        }

        public string MA_TK
        {
            get { return _MA_TK; }
            set { _MA_TK = value; }
        }

        public string TEN_TK
        {
            get { return _TEN_TK; }
            set { _TEN_TK = value; }
        }






        public decimal PS_NO
        {
            get { return _PS_NO; }
            set { _PS_NO = value; }
        }

        public decimal PS_CO
        {
            get { return _PS_CO; }
            set { _PS_CO = value; }
        }

        public decimal PS_NO_NT
        {
            get { return _PS_NO_NT; }
            set { _PS_NO_NT = value; }
        }

        public decimal PS_CO_NT
        {
            get { return _PS_CO_NT; }
            set { _PS_CO_NT = value; }
        }

        public string NOI_DUNG
        {
            get { return _NOI_DUNG; }
            set { _NOI_DUNG = value; }
        }

        public Guid ID_DM_HOPDONG
        {
            get { return _ID_DM_HOPDONG; }
            set { _ID_DM_HOPDONG = value; }
        }

        public string MA_HOPDONG
        {
            get { return _MA_HOPDONG; }
            set { _MA_HOPDONG = value; }
        }

        public string KY_HIEU_HOPDONG
        {
            get { return _KY_HIEU_HOPDONG; }
            set { _KY_HIEU_HOPDONG = value; }
        }

        public string TEN_HOPDONG
        {
            get { return _TEN_HOPDONG; }
            set { _TEN_HOPDONG = value; }
        }



        public Guid ID_DM_PTQT
        {
            get { return _ID_DM_PTQT; }
            set { _ID_DM_PTQT = value; }
        }



        public Guid ID_DM_PHONGBAN
        {
            get { return _ID_DM_PHONGBAN; }
            set { _ID_DM_PHONGBAN = value; }
        }



        public Guid ID_CT_GHISO
        {
            get { return _ID_CT_GHISO; }
            set { _ID_CT_GHISO = value; }
        }

        public string MA_CT_GHISO_SO
        {
            get { return _MA_CT_GHISO_SO; }
            set { _MA_CT_GHISO_SO = value; }
        }

        public string CT_GHISO_TRICHYEU
        {
            get { return _CT_GHISO_TRICHYEU; }
            set { _CT_GHISO_TRICHYEU = value; }
        }

        public DateTime? CT_GHISO_NGAY
        {
            get { return _CT_GHISO_NGAY; }
            set { _CT_GHISO_NGAY = value; }
        }

        public decimal DA_GHISO
        {
            get { return _DA_GHISO; }
            set { _DA_GHISO = value; }
        }

        public Guid ID_DM_VUVIEC
        {
            get { return _ID_DM_VUVIEC; }
            set { _ID_DM_VUVIEC = value; }
        }

        public string MA_VUVIEC
        {
            get { return _MA_VUVIEC; }
            set { _MA_VUVIEC = value; }
        }

        public string KY_HIEU_VUVIEC
        {
            get { return _KY_HIEU_VUVIEC; }
            set { _KY_HIEU_VUVIEC = value; }
        }



        public Guid ID_DM_TUDO_1
        {
            get { return _ID_DM_TUDO_1; }
            set { _ID_DM_TUDO_1 = value; }
        }


        public Guid ID_DM_TUDO_2
        {
            get { return _ID_DM_TUDO_2; }
            set { _ID_DM_TUDO_2 = value; }
        }



        public Guid ID_DM_TUDO_3
        {
            get { return _ID_DM_TUDO_3; }
            set { _ID_DM_TUDO_3 = value; }
        }



        public Guid ID_DM_TUDO_4
        {
            get { return _ID_DM_TUDO_4; }
            set { _ID_DM_TUDO_4 = value; }
        }



        public Guid ID_DM_TUDO_5
        {
            get { return _ID_DM_TUDO_5; }
            set { _ID_DM_TUDO_5 = value; }
        }



        public decimal LOAI_NGHIEP_VU
        {
            get { return _LOAI_NGHIEP_VU; }
            set { _LOAI_NGHIEP_VU = value; }
        }

        public Guid ID_KHANG
        {
            get { return _ID_KHANG; }
            set { _ID_KHANG = value; }
        }

        public string MA_KHANG
        {
            get { return _MA_KHANG; }
            set { _MA_KHANG = value; }
        }

        public string TEN_KHANG
        {
            get { return _TEN_KHANG; }
            set { _TEN_KHANG = value; }
        }



        public Guid ID_DOITUONG_1
        {
            get { return _ID_DOITUONG_1; }
            set { _ID_DOITUONG_1 = value; }
        }

        public string MA_DOITUONG_1
        {
            get { return _MA_DOITUONG_1; }
            set { _MA_DOITUONG_1 = value; }
        }

        public string TEN_DOITUONG_1
        {
            get { return _TEN_DOITUONG_1; }
            set { _TEN_DOITUONG_1 = value; }
        }

        public Guid ID_DOITUONG_2
        {
            get { return _ID_DOITUONG_2; }
            set { _ID_DOITUONG_2 = value; }
        }

        public string MA_DOITUONG_2
        {
            get { return _MA_DOITUONG_2; }
            set { _MA_DOITUONG_2 = value; }
        }

        public string TEN_DOITUONG_2
        {
            get { return _TEN_DOITUONG_2; }
            set { _TEN_DOITUONG_2 = value; }
        }

        public Guid ID_DOITUONG_3
        {
            get { return _ID_DOITUONG_3; }
            set { _ID_DOITUONG_3 = value; }
        }

        public string MA_DOITUONG_3
        {
            get { return _MA_DOITUONG_3; }
            set { _MA_DOITUONG_3 = value; }
        }

        public string TEN_DOITUONG_3
        {
            get { return _TEN_DOITUONG_3; }
            set { _TEN_DOITUONG_3 = value; }
        }

        public Guid ID_DM_KHOANPHI
        {
            get { return _ID_DM_KHOANPHI; }
            set { _ID_DM_KHOANPHI = value; }
        }

        public decimal NHOM
        {
            get { return _NHOM; }
            set { _NHOM = value; }
        }



        public CtHoadon CT_HOADON
        {
            get { return _CT_HOADON; }
            set { _CT_HOADON = value; }
        }

        public List<CtThue> LstCtThue
        {
            get { return _lstCT_THUE; }
            set { _lstCT_THUE = value; }
        }

        public List<CtThue> LstDelCtThue
        {
            get { return _lstDelCT_THUE; }
            set { _lstDelCT_THUE = value; }
        }

        public decimal SO_DU
        {
            get { return _SO_DU; }
            set { _SO_DU = value; }
        }

        public Guid ID_DOITUONG_HOADON
        {
            get { return _ID_DOITUONG_HOADON; }
            set { _ID_DOITUONG_HOADON = value; }
        }

        public string MA_HOADON
        {
            get { return _MA_HOADON; }
            set { _MA_HOADON = value; }
        }

        public string KY_HIEU_HOADON
        {
            get { return _KY_HIEU_HOADON; }
            set { _KY_HIEU_HOADON = value; }
        }

        public string MA_RO
        {
            get { return _MA_RO; }
            set { _MA_RO = value; }
        }

        public string TEN_RO
        {
            get { return _TEN_RO; }
            set { _TEN_RO = value; }
        }


        public string KY_HIEU_KHANG
        {
            get { return _KY_HIEU_KHANG; }
            set { _KY_HIEU_KHANG = value; }
        }



        public decimal PHAN_HE
        {
            get { return _PHAN_HE; }
            set { _PHAN_HE = value; }
        }

        public string BX_1
        {
            get { return _BX_1; }
            set { _BX_1 = value; }
        }

        public string BX_2
        {
            get { return _BX_2; }
            set { _BX_2 = value; }
        }

        public string BX_3
        {
            get { return _BX_3; }
            set { _BX_3 = value; }
        }

        #endregion

        #region "Init Class"
        public CT_D_KInfo()
        {
        }

        public CT_D_KInfo(Guid CTD_ID, Guid CTH_ID, Guid TK_ID, string MA_TK, string TEN_TK, decimal PS_NO, decimal PS_CO, decimal PS_NO_NT, decimal PS_CO_NT, string NOI_DUNG,
        Guid ID_DM_HOPDONG, string MA_HOPDONG, string KY_HIEU_HOPDONG, string TEN_HOPDONG, Guid ID_DM_PTQT, Guid ID_DM_PHONGBAN, Guid ID_CT_GHISO, string MA_CT_GHISO_SO, string CT_GHISO_TRICHYEU, DateTime? CT_GHISO_NGAY,
        decimal DA_GHISO, Guid ID_DM_VUVIEC, string MA_VUVIEC, string KY_HIEU_VUVIEC, Guid ID_DM_TUDO_1, Guid ID_DM_TUDO_2, Guid ID_DM_TUDO_3, Guid ID_DM_TUDO_4, Guid ID_DM_TUDO_5, decimal LOAI_NGHIEP_VU,
        Guid ID_KHANG, string MA_KHANG, string TEN_KHANG, Guid ID_DOITUONG_1, string MA_DOITUONG_1, string TEN_DOITUONG_1, Guid ID_DOITUONG_2, string MA_DOITUONG_2, string TEN_DOITUONG_2, Guid ID_DOITUONG_3,
        string MA_DOITUONG_3, string TEN_DOITUONG_3, Guid ID_DM_KHOANPHI, decimal NHOM, CtHoadon CT_HOADON, List<CtThue> LstCtThue, List<CtThue> LstDelCtThue, decimal SO_DU, Guid ID_DOITUONG_HOADON, string MA_HOADON,
        string KY_HIEU_HOADON, string MA_RO, string TEN_RO, string KY_HIEU_KHANG, decimal PHAN_HE, string BX_1, string BX_2, string BX_3)
        {
            this.CTD_ID = CTD_ID;
            this.CTH_ID = CTH_ID;
            this.TK_ID = TK_ID;
            this.MA_TK = MA_TK;
            this.TEN_TK = TEN_TK;
            this.PS_NO = PS_NO;
            this.PS_CO = PS_CO;
            this.PS_NO_NT = PS_NO_NT;
            this.PS_CO_NT = PS_CO_NT;
            this.NOI_DUNG = NOI_DUNG;
            this.ID_DM_HOPDONG = ID_DM_HOPDONG;
            this.MA_HOPDONG = MA_HOPDONG;
            this.KY_HIEU_HOPDONG = KY_HIEU_HOPDONG;
            this.TEN_HOPDONG = TEN_HOPDONG;
            this.ID_DM_PTQT = ID_DM_PTQT;
            this.ID_DM_PHONGBAN = ID_DM_PHONGBAN;
            this.ID_CT_GHISO = ID_CT_GHISO;
            this.MA_CT_GHISO_SO = MA_CT_GHISO_SO;
            this.CT_GHISO_TRICHYEU = CT_GHISO_TRICHYEU;
            this.CT_GHISO_NGAY = CT_GHISO_NGAY;
            this.DA_GHISO = DA_GHISO;
            this.ID_DM_VUVIEC = ID_DM_VUVIEC;
            this.MA_VUVIEC = MA_VUVIEC;
            this.KY_HIEU_VUVIEC = KY_HIEU_VUVIEC;
            this.ID_DM_TUDO_1 = ID_DM_TUDO_1;
            this.ID_DM_TUDO_2 = ID_DM_TUDO_2;
            this.ID_DM_TUDO_3 = ID_DM_TUDO_3;
            this.ID_DM_TUDO_4 = ID_DM_TUDO_4;
            this.ID_DM_TUDO_5 = ID_DM_TUDO_5;
            this.LOAI_NGHIEP_VU = LOAI_NGHIEP_VU;
            this.ID_KHANG = ID_KHANG;
            this.MA_KHANG = MA_KHANG;
            this.TEN_KHANG = TEN_KHANG;
            this.KY_HIEU_KHANG = KY_HIEU_KHANG;
            this.ID_DOITUONG_1 = ID_DOITUONG_1;
            this.MA_DOITUONG_1 = MA_DOITUONG_1;
            this.TEN_DOITUONG_1 = TEN_DOITUONG_1;
            this.ID_DOITUONG_2 = ID_DOITUONG_2;
            this.MA_DOITUONG_2 = MA_DOITUONG_2;
            this.TEN_DOITUONG_2 = TEN_DOITUONG_2;
            this.ID_DOITUONG_3 = ID_DOITUONG_3;
            this.MA_DOITUONG_3 = MA_DOITUONG_3;
            this.TEN_DOITUONG_3 = TEN_DOITUONG_3;
            this.ID_DM_KHOANPHI = ID_DM_KHOANPHI;
            this.NHOM = NHOM;
            this.CT_HOADON = CT_HOADON;
            this.LstCtThue = LstCtThue;
            this.LstDelCtThue = LstDelCtThue;
            this.SO_DU = SO_DU;
            this.ID_DOITUONG_HOADON = ID_DOITUONG_HOADON;
            this.MA_HOADON = MA_HOADON;
            this.KY_HIEU_HOADON = KY_HIEU_HOADON;
            this.MA_RO = MA_RO;
            this.TEN_RO = TEN_RO;
            this.PHAN_HE = PHAN_HE;
            this.BX_1 = BX_1;
            this.BX_2 = BX_2;
            this.BX_3 = BX_3;
        }

        public CT_D_KInfo Clone()
        {
            CT_D_KInfo _temp = new CT_D_KInfo();
            if (this == null)
            {
                return null;
            }
            _temp.CTD_ID = CTD_ID;
            _temp.CTH_ID = CTH_ID;
            _temp.TK_ID = TK_ID;
            _temp.MA_TK = MA_TK;
            _temp.TEN_TK = TEN_TK;
            _temp.PS_NO = PS_NO;
            _temp.PS_CO = PS_CO;
            _temp.PS_NO_NT = PS_NO_NT;
            _temp.PS_CO_NT = PS_CO_NT;
            _temp.NOI_DUNG = NOI_DUNG;
            _temp.ID_DM_HOPDONG = ID_DM_HOPDONG;
            _temp.MA_HOPDONG = MA_HOPDONG;
            _temp.KY_HIEU_HOPDONG = KY_HIEU_HOPDONG;
            _temp.TEN_HOPDONG = TEN_HOPDONG;
            _temp.ID_DM_PTQT = ID_DM_PTQT;
            _temp.ID_DM_PHONGBAN = ID_DM_PHONGBAN;
            _temp.ID_CT_GHISO = ID_CT_GHISO;
            _temp.MA_CT_GHISO_SO = MA_CT_GHISO_SO;
            _temp.CT_GHISO_TRICHYEU = CT_GHISO_TRICHYEU;
            _temp.CT_GHISO_NGAY = CT_GHISO_NGAY;
            _temp.DA_GHISO = DA_GHISO;
            _temp.ID_DM_VUVIEC = ID_DM_VUVIEC;
            _temp.MA_VUVIEC = MA_VUVIEC;
            _temp.KY_HIEU_VUVIEC = KY_HIEU_VUVIEC;
            _temp.ID_DM_TUDO_1 = ID_DM_TUDO_1;
            _temp.ID_DM_TUDO_2 = ID_DM_TUDO_2;
            _temp.ID_DM_TUDO_3 = ID_DM_TUDO_3;
            _temp.ID_DM_TUDO_4 = ID_DM_TUDO_4;
            _temp.ID_DM_TUDO_5 = ID_DM_TUDO_5;
            _temp.LOAI_NGHIEP_VU = LOAI_NGHIEP_VU;
            _temp.ID_KHANG = ID_KHANG;
            _temp.MA_KHANG = MA_KHANG;
            _temp.TEN_KHANG = TEN_KHANG;
            _temp.KY_HIEU_KHANG = KY_HIEU_KHANG;
            _temp.ID_DOITUONG_1 = ID_DOITUONG_1;
            _temp.MA_DOITUONG_1 = MA_DOITUONG_1;
            _temp.TEN_DOITUONG_1 = TEN_DOITUONG_1;
            _temp.ID_DOITUONG_2 = ID_DOITUONG_2;
            _temp.MA_DOITUONG_2 = MA_DOITUONG_2;
            _temp.TEN_DOITUONG_2 = TEN_DOITUONG_2;
            _temp.ID_DOITUONG_3 = ID_DOITUONG_3;
            _temp.MA_DOITUONG_3 = MA_DOITUONG_3;
            _temp.TEN_DOITUONG_3 = TEN_DOITUONG_3;
            _temp.ID_DM_KHOANPHI = ID_DM_KHOANPHI;
            _temp.NHOM = NHOM;
            _temp.SO_DU = SO_DU;
            _temp.ID_DOITUONG_HOADON = ID_DOITUONG_HOADON;
            _temp.MA_HOADON = MA_HOADON;
            _temp.KY_HIEU_HOADON = KY_HIEU_HOADON;
            _temp.MA_RO = MA_RO;
            _temp.TEN_RO = TEN_RO;

            _temp.PHAN_HE = PHAN_HE;
            _temp.BX_1 = BX_1;
            _temp.BX_2 = BX_2;
            _temp.BX_3 = BX_3;

            if (CT_HOADON == null)
            {
                _temp.CT_HOADON = null;
            }
            else
            {
                _temp.CT_HOADON = CT_HOADON.Clone();
            }


            if (LstCtThue != null)
            {
                if (LstCtThue.Count != 0)
                {
                    _temp.LstCtThue = new List<CtThue>();
                    foreach (CtThue ctThueInfo in LstCtThue)
                    {
                        _temp.LstCtThue.Add(ctThueInfo.Clone());
                    }
                }
                else
                {
                    _temp.LstCtThue = new List<CtThue>();
                }
            }
            else
            {
                _temp.LstCtThue = new List<CtThue>();
            }


            if (LstDelCtThue != null)
            {
                if (LstDelCtThue.Count != 0)
                {
                    _temp.LstDelCtThue = new List<CtThue>();
                    foreach (CtThue ctThueInfo in LstDelCtThue)
                    {
                        _temp.LstDelCtThue.Add(ctThueInfo.Clone());
                    }
                }
                else
                {
                    _temp.LstDelCtThue = new List<CtThue>();
                }
            }
            else
            {
                _temp.LstDelCtThue = new List<CtThue>();
            }

            return _temp;

        }


        #endregion

        #region "Methods"
        public CT_D_KInfo Clone1()
        {
            return (CT_D_KInfo)this.MemberwiseClone();
        }
        #endregion
    }
}
