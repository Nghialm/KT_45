using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class AppDvBc : DomainObject<Guid>
    {
        HtBaocao _HtBaocao;
        [DataMember]
        public HtBaocao HtBaocao
        {
            get { return _HtBaocao; }
            set { _HtBaocao = value; }
        }
	}
}