using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class KtHDong : DomainObject<System.Guid>
    {
        public Decimal FormatKieuChu
        {
            get
            {
                if (_KieuChu == 1)
                    return _KieuChu;
                else
                    if (_InDong == 0)
                        return 2;
                    else
                        return 0;
            }
        }
	}
}