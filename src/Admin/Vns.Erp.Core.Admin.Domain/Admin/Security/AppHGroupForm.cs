using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class AppHGroupForm : DomainObject<Guid>
    {
        #region Extent
        private AppForms _AppForms;
        [DataMember]
        public AppForms AppForms
        {
            get { return _AppForms; }
            set { _AppForms = value; }
        }

        #endregion
	}
}