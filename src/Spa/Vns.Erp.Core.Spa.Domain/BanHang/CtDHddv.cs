using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Spa.Domain
{
	public partial class CtDHddv : DomainObject<System.Guid>
    {
        public virtual CtHHddv ObjCtHHddv { get; set; }
	}
}