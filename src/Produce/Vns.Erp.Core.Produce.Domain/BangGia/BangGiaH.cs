using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class BangGiaH : DomainObject<System.Guid>
    {
        public IList<BangGiaD> lstBangGiaD;
	}
}