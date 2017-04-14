using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using Vns.Erp.Core.Admin.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxLenhsanxuatD : DomainObject<System.Guid>
    {
        public virtual DmHanghoa ObjVatlieuDauvao
        {
            get;
            set;
        }

        public virtual DmHanghoa ObjVatlieuDaura
        {
            get;
            set;
        }
	}
}