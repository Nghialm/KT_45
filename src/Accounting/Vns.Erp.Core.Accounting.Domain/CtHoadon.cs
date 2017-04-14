using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Domain
{
	public partial class CtHoadon : DomainObject<System.Guid>
    {
        public virtual IList<CtThue> LstCtThue { get; set; }
	}
}