using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Accounting.Domain
{
    public partial class KtCtDKhac : DomainObject<System.Guid>
    {
        private CtHoadon _CT_HOADON;
        private List<CtThue> _lstCT_THUE;
        private List<CtThue> _lstDelCT_THUE;

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
	}
}