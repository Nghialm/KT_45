using System;
using System.Data;
using System.Configuration;
namespace Vns.Erp.Core.Domain
{
    public class VnsOrder
    {        
        private bool _Asc = true;

        public bool Asc
        {
            get { return _Asc; }
            set { _Asc = value; }
        }
        private string _PropertyName;

        public string PropertyName
        {
            get { return _PropertyName; }
            set { _PropertyName = value; }
        }

        public VnsOrder(bool asc, string propertyName)
        {
            _Asc = asc;
            _PropertyName = propertyName;
        }

        public VnsOrder()
        { }
    }
}
