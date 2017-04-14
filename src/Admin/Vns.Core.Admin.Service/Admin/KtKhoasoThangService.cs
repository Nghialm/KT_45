using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Admin.Domain;
using Vns.Erp.Core.Admin.Dao;
using Vns.Erp.Core.Admin.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Admin.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class KtKhoasoThangService : GenericService<KtKhoasoThang, System.Guid>, IKtKhoasoThangService
    {
        public IKtKhoasoThangDao KtKhoasoThangDao
        {
            get { return (IKtKhoasoThangDao)Dao; }
            set { Dao = value; }
        }

        private IKtKhoaSoNgayDao _KtKhoaSoNgayDao;
        public IKtKhoaSoNgayDao KtKhoaSoNgayDao
        {
            get { return _KtKhoaSoNgayDao; }
            set { _KtKhoaSoNgayDao = value; }
        }
        

        public KtKhoasoThang GetByNam(Decimal Nam, Guid DonviId)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("Nam");
            values.Add(Nam);
            props.Add("DonviId");
            values.Add(DonviId);
            IList<KtKhoasoThang> ls = List(-1, -1, props, values, null);
            if (ls == null || ls.Count == 0)
                return null;
            else
                return ls[0];
        }
        
        public bool KiemTraKhoaSo(System.DateTime NgayCT, Guid donvi_id)
        {
            KtKhoasoThang objKtKhoaSo = GetByNam(Convert.ToDecimal(NgayCT.Year), donvi_id);

            if (objKtKhoaSo == null)
            {
                //do nothing
                return false;
            }
            else
            {
                switch ((NgayCT.Month.ToString()))
                {
                    case "1":
                        if (objKtKhoaSo.Thang1 == 1)
                        {
                            return true;
                        }
                        break;
                    case "2":
                        if (objKtKhoaSo.Thang2 == 1)
                        {
                            return true;
                        }
                        break;
                    case "3":
                        if (objKtKhoaSo.Thang3 == 1)
                        {
                            return true;
                        }
                        break;
                    case "4":
                        if (objKtKhoaSo.Thang4 == 1)
                        {
                            return true;
                        }
                        break;
                    case "5":
                        if (objKtKhoaSo.Thang5 == 1)
                        {
                            return true;
                        }
                        break;
                    case "6":
                        if (objKtKhoaSo.Thang6 == 1)
                        {
                            return true;
                        }
                        break;
                    case "7":
                        if (objKtKhoaSo.Thang7 == 1)
                        {
                            return true;
                        }
                        break;
                    case "8":
                        if (objKtKhoaSo.Thang8 == 1)
                        {
                            return true;
                        }
                        break;
                    case "9":
                        if (objKtKhoaSo.Thang9 == 1)
                        {
                            return true;
                        }
                        break;
                    case "10":
                        if (objKtKhoaSo.Thang10 == 1)
                        {
                            return true;
                        }
                        break;
                    case "11":
                        if (objKtKhoaSo.Thang11 == 1)
                        {
                            return true;
                        }
                        break;
                    case "12":
                        if (objKtKhoaSo.Thang12 == 1)
                        {
                            return true;
                        }
                        break;
                }
                return false;
            }
        }

        public bool KiemTraKhoaSoTheoNgay(System.DateTime NgayCT, Guid donvi_id)
        {
            KtKhoaSoNgay objKsNgay = _KtKhoaSoNgayDao.GetByDonvi(donvi_id);
            if (objKsNgay == null) return true;
            else
            {
                if (NgayCT <= objKsNgay.NgayKhoaSo) return false;
                else return true;
            }
        }
    }
}
