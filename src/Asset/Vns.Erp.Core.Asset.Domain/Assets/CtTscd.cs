using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Asset.Domain
{
	public partial class CtTscd : DomainObject<System.Guid>
    {
        public virtual DmTscd ObjDmTscd { get; set; }
	}
}