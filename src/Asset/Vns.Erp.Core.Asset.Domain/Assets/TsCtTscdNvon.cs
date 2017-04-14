using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Asset.Domain
{
	public partial class TsCtTscdNvon : DomainObject<System.Guid>
    {
        private DmNguonTscd _ObjDmNguonTscd;

        public DmNguonTscd ObjDmNguonTscd
        {
            get { return _ObjDmNguonTscd; }
            set { _ObjDmNguonTscd = value; }
        }
	}
}