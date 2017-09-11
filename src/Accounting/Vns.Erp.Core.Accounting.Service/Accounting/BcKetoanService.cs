using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Report.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BcKetoanService : GenericService<BcKetoan, System.Guid>, IBcKetoanService
    {
        public IBcKetoanDao BcKetoanDao
        {
            get { return (IBcKetoanDao)Dao; }
            set { Dao = value; }
        }



        public IList<BcKetoan> SearchBy(int PageIndex, int PageSize, Guid ID_Loai_CT,
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
                Guid id_dm_tudo_5_du, out int totalResult)
        {
            totalResult = 1000;
            return BcKetoanDao.SearchBy(PageIndex, PageSize, ID_Loai_CT, So_Tien_Tu, So_Tien_Den, ma_taikhoan, ma_taikhoan_du,
                ngay_dau_ky, ngay_cuoi_ky,
                donvi_id,
                ma_nte,
                ma_hopdong,
                ma_hopdong_du,
                ma_ptqt,
                ma_ptqt_du,
                ma_phongban,
                ma_phongban_du,
                id_vuviec,
                id_vuviec_du,
                id_khang,
                id_khang_du,
                id_dm_tudo_1,
                id_dm_tudo_1_du,
                id_dm_tudo_2,
                id_dm_tudo_2_du,
                id_dm_tudo_3,
                id_dm_tudo_3_du,
                id_dm_tudo_4,
                id_dm_tudo_4_du,
                id_dm_tudo_5,
                id_dm_tudo_5_du,out totalResult);
        }

        
    }
}
