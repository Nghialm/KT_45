using System;
using System.ComponentModel;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Data;

namespace Vns.Erp.Core.Produce.Domain
{
	public partial class SxDmQuytrinh : DomainObject<System.Guid>
    {
        IList<SxQuytrinhDinhmuc> _LstDinhMuc;
        [DataMember]
        public IList<SxQuytrinhDinhmuc> LstDinhMuc
        {
            get { return _LstDinhMuc; }
            set { _LstDinhMuc = value; }
        }

       #region Mapping Excel Import
        public SxDmQuytrinh(DataRow dr)
        {
            _MaQuytrinh = dr["MA_QUYTRINH"].ToString();
            _KyHieu = dr["KY_HIEU"].ToString();
            _TenQuytrinh = dr["TEN_QUYTRINH"].ToString();

            _MoTa = String.Empty;
            _ChoPhepSua =1;
            _CoSuDung = 1;
        }
        #endregion
	}
}