using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Vns.Erp.Core.Accounting.Report.Domain;

namespace Vns.Erp.Core.Accounting.Report.Service
{
    public class ReportCommon
    {
        public decimal FUNC_GET_VALUE_BC_CT(string p_cach_tinh, string _cot, List<RpKtHDong> dt, Guid ss_id)
        {
            decimal GiaTri = 0;
            foreach (RpKtHDong tmp in dt)
            {
                if (tmp.MaSo == p_cach_tinh)
                {
                    GiaTri = tmp.C1;
                    break;
                }
            }

            return GiaTri;
        }

        public decimal FUNC_GET_DIV_VALUE_BC(string p_cach_tinh, string _cot, List<RpKtHDong> dt, Guid ss_id)
        {
            string[] l_idx = p_cach_tinh.Split('/');
            decimal GiaTri = 0;


            for (int i = 0; i <= l_idx.Length - 1; i++)
            {
                if (i == 0)
                {
                    GiaTri = FUNC_GET_VALUE_BC_CT(l_idx[0], _cot, dt, ss_id);
                }
                else
                {
                    decimal GiaTriTemp = FUNC_GET_VALUE_BC_CT(l_idx[0], _cot, dt, ss_id);
                    if ((GiaTriTemp == 0))
                    {
                        GiaTri = 0;
                    }
                    else
                    {
                        GiaTri = GiaTri / GiaTriTemp;
                    }
                }
            }

            return GiaTri;
        }

        public decimal FUNC_GET_MUL_VALUE_BC(string p_cach_tinh, string _cot, List<RpKtHDong> dt, Guid ss_id)
        {
            string[] l_idx = p_cach_tinh.Split('*');
            decimal GiaTri = 1;

            for (int i = 0; i <= l_idx.Length - 1; i++)
            {
                GiaTri = GiaTri * FUNC_GET_DIV_VALUE_BC(l_idx[i], _cot, dt, ss_id);
            }

            return GiaTri;
        }

        public decimal FUNC_GET_SUB_VALUE_BC(string p_cach_tinh, string _cot, List<RpKtHDong> dt, Guid ss_id)
        {
            string[] l_idx = p_cach_tinh.Split('-');
            decimal GiaTri = 0;

            for (int i = 0; i <= l_idx.Length - 1; i++)
            {
                if (i == 0)
                {
                    GiaTri = FUNC_GET_MUL_VALUE_BC(l_idx[0], _cot, dt, ss_id);
                }
                else
                {
                    GiaTri = GiaTri - FUNC_GET_MUL_VALUE_BC(l_idx[i], _cot, dt, ss_id);
                }
            }

            return GiaTri;
        }

        public decimal FUNC_GET_ADD_VALUE_BC(string p_cach_tinh, string _cot, List<RpKtHDong> dt, Guid ss_id)
        {
            string[] l_idx = p_cach_tinh.Split('+');
            decimal GiaTri = 0;

            for (int i = 0; i <= l_idx.Length - 1; i++)
            {
                GiaTri = GiaTri + FUNC_GET_SUB_VALUE_BC(l_idx[i], _cot, dt, ss_id);
            }

            return GiaTri;
        }

        public DataTable FUN_PIVOT_ReportObject(List<RpKtHDong> lst)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", Type.GetType("System.Decimal"));
            dt.Columns.Add("IdDong", Type.GetType("System.Guid"));
            dt.Columns.Add("ChiTieu", Type.GetType("System.String"));
            dt.Columns.Add("MaSo", Type.GetType("System.String"));
            dt.Columns.Add("ThuyetMinh", Type.GetType("System.String"));
            dt.Columns.Add("InDong", Type.GetType("System.Decimal"));
            dt.Columns.Add("KieuChu", Type.GetType("System.Decimal"));

            String FlgNhom = String.Empty;
            Int16 CurrentCol = 5;
            Int32 Dem = -1;
            FlgNhom = lst[0].NhomCot;
            foreach (RpKtHDong tmpvalue in lst)
            {
                if (FlgNhom != tmpvalue.NhomCot) break;

                dt.Rows.Add( dt.NewRow());
                Dem++;
                dt.Rows[Dem]["STT"] = tmpvalue.ThuTu;
                dt.Rows[Dem]["ChiTieu"] = tmpvalue.ChiTieu;
                dt.Rows[Dem]["MaSo"] = tmpvalue.MaSo;
                dt.Rows[Dem]["ThuyetMinh"] = String.Empty;// tmpvalue.ChiTieu;
                dt.Rows[Dem]["InDong"] = tmpvalue.InDong;
                dt.Rows[Dem]["KieuChu"] = tmpvalue.KieuChu;
                dt.Rows[Dem]["IdDong"] = tmpvalue.IdDong;
            }

            Dem = -1;
            FlgNhom = String.Empty;
            String ColName = String.Empty;
            foreach (RpKtHDong tmpvalue in lst)
            {
                if (FlgNhom != tmpvalue.NhomCot)
                {
                    CurrentCol++;
                    FlgNhom = tmpvalue.NhomCot;
                    if (tmpvalue.NhomCot.Length > 1)
                        ColName = String.Format("C{0}", tmpvalue.NhomCot);
                    else
                        ColName = String.Format("C0{0}", tmpvalue.NhomCot);

                    dt.Columns.Add(ColName, Type.GetType("System.Decimal"));
                    Dem = -1;
                }

                Dem++;
                dt.Rows[Dem][ColName] = tmpvalue.C1;

            }


            return dt;
        }
    }
}
