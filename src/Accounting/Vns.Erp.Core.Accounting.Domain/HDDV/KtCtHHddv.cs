using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Domain
{
	public partial class KtCtHHddv : DomainObject<System.Guid>
    {
        public virtual IList<KtCtDHddv> LstCtDHddv { get; set; }
	}
}