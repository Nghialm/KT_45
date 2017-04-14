using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Admin.Domain
{
	public partial class AppDvForm : DomainObject<Guid>
    {
        #region Extent pro
        private AppGroupForms _AppGroupForms;
        [DataMember]
        public AppGroupForms AppGroupForms
        {
            get { return _AppGroupForms; }
            set { _AppGroupForms = value; }
        }
        #endregion
	}
}