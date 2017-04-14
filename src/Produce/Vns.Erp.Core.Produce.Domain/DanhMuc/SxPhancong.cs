using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxPhancong : DomainObject<System.Guid>
    {
        SxLenhsanxuat _LenhSanXuat;
        public SxLenhsanxuat LenhSanXuat
        {
            get { return _LenhSanXuat; }
            set { _LenhSanXuat = value; }
        }

        public virtual SxKehoachM ObjSxKehoachM
        { get; set; }
	}
}