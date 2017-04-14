using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Dao;
using Vns.Erp.Core.Domain;
using System.Collections.Generic;

namespace Vns.Erp.Core.Accounting.Dao
{
	public interface IBcKetoanKhoDao:IDao<BcKetoanKho,System.Guid>
	{
        /// <summary>
        /// Delete BcKetoanKho from chung tu
        /// </summary>
        /// <param name="CtHIdNx"></param>
        /// <param name="CtDIdNx"></param>
        /// <returns></returns>
        Boolean DeleteByChungTu(Guid CthNxId, Guid CtdNxId);
        IList<BcKetoanKho> GetBy(DateTime TuNgay, DateTime DenNgay, Guid HanghoaId, Guid KhoId, Guid DonviId, Boolean XuatKho);
        IList<BcKetoanKho> GetNhap4FIFO(DateTime TuNgay, DateTime DenNgay, Guid HanghoaId, Guid KhoId, Guid DonviId);
        void UpdateGiaXuat(BcKetoanKho tmp);
    }
}