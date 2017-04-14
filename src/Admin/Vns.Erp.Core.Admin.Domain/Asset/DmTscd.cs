using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class DmTscd : DomainObject<System.Guid>
    {
        public virtual IList<CtTscd> LstCtTscd { get; set; }
	}
}