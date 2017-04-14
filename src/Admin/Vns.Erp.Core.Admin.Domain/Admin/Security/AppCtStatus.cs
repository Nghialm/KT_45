using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class AppCtStatus : DomainObject<System.Guid>
    {
        HtLoaichungtu _HtLoaichungtu;

        public HtLoaichungtu HtLoaichungtu
        {
            get { return _HtLoaichungtu; }
            set { _HtLoaichungtu = value; }
        }
	}
}