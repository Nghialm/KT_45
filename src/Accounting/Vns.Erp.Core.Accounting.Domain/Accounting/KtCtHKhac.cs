using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Accounting.Domain
{
    public partial class KtCtHKhac : DomainObject<System.Guid>
    {
        private IList<KtCtDKhac> _LstKtCtDKhac;
        [DataMember]
        public IList<KtCtDKhac> LstKtCtDKhac
        {
            get { return _LstKtCtDKhac; }
            set { _LstKtCtDKhac = value; }
        }
    }
}