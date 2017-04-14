using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class AppDvGroupBc : DomainObject<Guid>
    {
        HtBaocao _HtBaocao;

        public HtBaocao HtBaocao
        {
            get { return _HtBaocao; }
            set { _HtBaocao = value; }
        }
	}
}