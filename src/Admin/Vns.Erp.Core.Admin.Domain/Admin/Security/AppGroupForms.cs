using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Runtime.Serialization;

namespace Vns.Erp.Core.Admin.Domain
{
    public partial class AppGroupForms : DomainObject<Guid>
    {
        #region Extent
        private AppForms _AppForms;
        [DataMember]
        public AppForms AppForms
        {
            get { return _AppForms; }
            set { _AppForms = value; }
        }
        
        public string FormText
        {
            get {
                if (AppForms != null)
                {
                    return AppForms.FormText;
                }
                else
                {
                    return null;
                }
            }            
        }

        #endregion
    }
}