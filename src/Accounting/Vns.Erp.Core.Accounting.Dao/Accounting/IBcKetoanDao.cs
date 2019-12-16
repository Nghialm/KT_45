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
	public interface IBcKetoanDao:IDao<BcKetoan,System.Guid>
	{
        /// <summary>
        /// Delete BcKetoan from Chung tu
        /// </summary>
        /// <param name="CtHIdNx"></param>
        /// <param name="CtDIdNx"></param>
        /// <returns></returns>
        Boolean DeleteByChungTu(Guid CtHId, Guid CtDId);
        Boolean DeleteByLoaiCt(Guid IdLoaiCt, DateTime TuNgay, DateTime DenNgay);

        /// <summary>
        /// Delete BcKetoan from BcKetoanKho with Nghiep vu
        /// -1: Delete All
        /// </summary>
        /// <param name="CtHIdNx"></param>
        /// <param name="CtDIdNx"></param>
        /// <param name="LoaiNghiepVu"></param>
        /// <returns></returns>
        Boolean DeleteByBcKeToanKho(Guid CtHIdNx, Guid CtDIdNx, Decimal LoaiNghiepVu);

        BcKetoan GetBy(Guid CtHId, Guid CtDId, Decimal LoaiNghiepVu);

        IList<BcKetoan> SearchBy(int PageIndex, int PageSize, Guid ID_Loai_CT,
                Decimal So_Tien_Tu, Decimal So_Tien_Den,
                string ma_taikhoan,
                string ma_taikhoan_du,
                DateTime ngay_dau_ky,
                DateTime ngay_cuoi_ky,
                Guid donvi_id,
                string ma_nte,
                string ma_hopdong,
                string ma_hopdong_du,
                string ma_ptqt,
                string ma_ptqt_du,
                string ma_phongban,
                string ma_phongban_du,
                Guid id_vuviec,
                Guid id_vuviec_du,
                Guid id_khang,
                Guid id_khang_du,
                Guid id_dm_tudo_1,
                Guid id_dm_tudo_1_du,
                Guid id_dm_tudo_2,
                Guid id_dm_tudo_2_du,
                Guid id_dm_tudo_3,
                Guid id_dm_tudo_3_du,
                Guid id_dm_tudo_4,
                Guid id_dm_tudo_4_du,
                Guid id_dm_tudo_5,
                Guid id_dm_tudo_5_du, out int totalResult);
	}
}