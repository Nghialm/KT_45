using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Accounting.Domain
{
	public partial class CtHNx : DomainObject<System.Guid>
    {
        private IList<CtDNx> _LstCtDNx;
        [DataMember]
        public virtual IList<CtDNx> LstCtDNx
        {
            get { return _LstCtDNx; }
            set { _LstCtDNx = value; }
        }

        #region Extend property
        public String LenhSanXuatLq
        {
            get
            {
                if (_LstCtDNx == null) return "";

                List<CtDNx> lsttmp = new List<CtDNx>(_LstCtDNx);
                lsttmp.Sort(CtDNx.CompareLenhSX);

                String lsxflg = String.Empty;
                String lsxLq = String.Empty;
                foreach (CtDNx tmp in lsttmp)
                {
                    if (!String.IsNullOrEmpty(tmp.MaLenhSanXuatNhap) || !String.IsNullOrEmpty(tmp.MaLenhSanXuatXuat))
                    {
                        string s = tmp.MaLenhSanXuatNhap + tmp.MaLenhSanXuatXuat;
                        if (lsxflg != s)
                        {
                            lsxflg = s;
                            if (!String.IsNullOrEmpty(lsxLq)) lsxLq += ", ";
                            lsxLq += tmp.MaLenhSanXuatNhap + tmp.MaLenhSanXuatXuat;
                        }
                    }   
                }

                return lsxLq;
            }
        }

        public String PhanXuongLq
        {
            get
            {
                if (_LstCtDNx == null) return "";

                List<CtDNx> lsttmp = new List<CtDNx>(_LstCtDNx);
                lsttmp.Sort(CtDNx.ComparePhanXuongSX);

                String lsxflg = String.Empty;
                String lsxLq = String.Empty;
                foreach (CtDNx tmp in lsttmp)
                {
                    if (!String.IsNullOrEmpty(tmp.MaPhanXuongNhap) || !String.IsNullOrEmpty(tmp.MaPhanXuongXuat))
                    {
                        string s = tmp.MaPhanXuongNhap + tmp.MaPhanXuongXuat;
                        if (lsxflg != s)
                        {
                            lsxflg = s;
                            if (!String.IsNullOrEmpty(lsxLq)) lsxLq += ", ";
                            lsxLq += s;
                        }
                    }
                }

                return lsxLq;
            }
        }
        #endregion

    }
}