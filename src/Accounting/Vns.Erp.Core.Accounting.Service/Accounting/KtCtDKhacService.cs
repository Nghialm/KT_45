using System.Collections;
using System.ComponentModel;
using System.Data;
using System;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Dao;
using Vns.Erp.Core.Accounting.Service.Interface;
using Vns.Erp.Core.Service;
using Vns.Erp.Core.Service.Interface;
using System.Collections.Generic;
using Vns.Erp.Core.Domain;
using Spring.Transaction.Interceptor;
using Vns.Erp.Core.Accounting.Domain.Extend;
using Vns.Erp.Core.Admin.Domain;
using System.ServiceModel.Activation;

namespace Vns.Erp.Core.Accounting.Service
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	public class KtCtDKhacService:GenericService<KtCtDKhac,System.Guid>, IKtCtDKhacService
	{
	    public IKtCtDKhacDao KtCtDKhacDao
        {
            get { return (IKtCtDKhacDao)Dao; }
            set { Dao = value; }
        }

        public IList<KtCtDKhac> GetByCtHandNghiepVu(Guid CthId, Decimal LoaiNghiepVu)
        {
            ArrayList props = new ArrayList();
            ArrayList values = new ArrayList();
            props.Add("CthId");
            values.Add(CthId);
            if (LoaiNghiepVu != -1)
            {
                props.Add("LoaiNghiepVu");
                values.Add(LoaiNghiepVu);
            }
            return List(-1, -1, props, values, null);
        }

        public bool CheckValidateCTDK(List<KtCtDKhac> lstCTDK, bool save)
        {
            int i = 0;
            bool check = false;
            int countC = 0;
            int countN = 0;
            decimal PSNO = 0;
            decimal PSCO = 0;
            decimal PSNO_NT = 0;
            decimal PSCO_NT = 0;
            string ID_TK_NO = "";
            string ID_TK_CO = "";

            //Lay list chua tung list nhom
            List<List<KtCtDKhac>> lstNhom = GetLstNhom(lstCTDK);
            foreach (List<KtCtDKhac> lstCTDKBYNHOM in lstNhom)
            {
                countC = 0;
                countN = 0;
                PSNO = 0;
                PSCO = 0;
                PSNO_NT = 0;
                PSCO_NT = 0;
                ID_TK_NO = "";
                ID_TK_CO = "";
                i = 0;
                for (int j = 0; j <= lstCTDKBYNHOM.Count - 1; j++)
                {
                    //check nhap tai khoan no/co
                    if (VnsCheck.IsNullGuid(lstCTDKBYNHOM[j].TkId))
                    {
                        //Message_Warning("Bạn chưa nhập đủ định khoản!");
                        return false;
                    }

                    //Kiem tra list thue neu co tai khoan la tai khoan thue
                    if (lstCTDKBYNHOM[j].MaTk.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri) | lstCTDKBYNHOM[j].MaTk.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri))
                    {
                        i = i + 1;

                        if (lstCTDKBYNHOM[j].LstCtThue == null)
                        {
                            check = false;
                        }
                        else
                        {
                            if (lstCTDKBYNHOM[j].LstCtThue.Count == 0)
                            {
                                check = false;
                            }
                            else
                            {
                                check = true;
                            }
                        }
                    }

                    //If (i = 1) And Not check Then
                    //    Message_Warning("Bạn chưa nhập thuế GTGT đầu vào!")
                    //    Return False
                    //End If

                    //Check tai khoan co khac tai khoan no
                    //Check truong hop trong cung mot nhom co cac dong du lieu giong nhau
                    if (!Check_id_tai_khoan(lstCTDKBYNHOM[j], lstCTDKBYNHOM[j].PsNo, lstCTDKBYNHOM, j))
                    {
                        return false;
                    }

                    //check truong hop nhieu no nhieu co
                    if (lstCTDKBYNHOM[j].PsCo != 0 | lstCTDKBYNHOM[j].PsCoNt != 0)
                    {
                        countC = countC + 1;
                        PSCO = PSCO + lstCTDKBYNHOM[j].PsCo;
                        PSCO_NT = PSCO_NT + lstCTDKBYNHOM[j].PsCoNt;
                    }
                    if (lstCTDKBYNHOM[j].PsNo != 0 | lstCTDKBYNHOM[j].PsNoNt != 0)
                    {
                        countN = countN + 1;
                        PSNO = PSNO + lstCTDKBYNHOM[j].PsNo;
                        PSNO_NT = PSNO_NT + lstCTDKBYNHOM[j].PsNoNt;
                    }
                }

                if ((i == 1) & !check)
                {
                    //Message_Warning("Bạn chưa nhập thuế GTGT đầu vào!");
                    return false;
                }

                if (save == true)
                {
                    if (PSNO != PSCO | PSNO_NT != PSCO_NT)
                    {
                        //Message_Warning("Tổng PS nợ và tổng PS có trong cùng một nhóm phải bằng nhau");
                        return false;
                    }
                    if (countC > 1 & countN > 1)
                    {
                        //Message_Warning("Trong cùng một nhóm chỉ có một PS nợ nhiều PS có hoặc một PS có nhiều PS nợ");
                        return false;
                    }
                }
            }
            return true;
        }

        public List<List<KtCtDKhac>> GetLstNhom(List<KtCtDKhac> lstCTDK)
        {

            List<List<KtCtDKhac>> lstNhom = new List<List<KtCtDKhac>>();
            foreach (KtCtDKhac ctDKInfo in lstCTDK)
            {
                if (lstNhom.Count == 0)
                {
                    List<KtCtDKhac> nhom = new List<KtCtDKhac>();
                    nhom.Add(ctDKInfo);
                    lstNhom.Add(nhom);
                }
                else
                {
                    bool isTrue = false;
                    foreach (List<KtCtDKhac> inhom in lstNhom)
                    {
                        if (ctDKInfo.NHOM == inhom[0].NHOM)
                        {
                            inhom.Add(ctDKInfo);
                            isTrue = true;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                    if (isTrue == false)
                    {
                        List<KtCtDKhac> nhom = new List<KtCtDKhac>();
                        nhom.Add(ctDKInfo);
                        lstNhom.Add(nhom);
                    }
                }
            }
            return lstNhom;
        }

        private bool Check_id_tai_khoan(KtCtDKhac obj_ctdk, decimal PS_NO, List<KtCtDKhac> lst, int j)
        {
            for (int i = 0; i <= lst.Count - 1; i++)
            {
                if (PS_NO == 0)
                {
                    if (lst[i].PsCo == 0)
                    {
                        if (lst[i].TkId == obj_ctdk.TkId)
                        {
                            //Message_Warning("Trong 1 nhóm tài khoản nợ phải khác tài khoản có và ngược lại!");
                            return false;
                        }
                    }
                }
                else
                {
                    if (lst[i].PsNo == 0)
                    {
                        if (lst[i].TkId == obj_ctdk.TkId)
                        {
                            //Message_Warning("Trong 1 nhóm tài khoản nợ phải khác tài khoản có và ngược lại!");
                            return false;
                        }
                    }
                }

                if (j != i)
                {
                    if (Compare2CT_D_KInfo(obj_ctdk, lst[i]))
                    {
                        //Message_Warning("Dữ liệu nhóm " + lst[i].NHOM + " trùng nhau, vui lòng kiểm tra lại!");
                        return false;
                    }
                }

            }
            return true;
        }

        private bool Compare2CT_D_KInfo(KtCtDKhac ctDKDich, KtCtDKhac ctDKNguon)
        {
            //Return true neu cac danh muc & ben phas sinh giong nhau
            //Return false neu cac danh muc & ben phas sinh khac nhau

            return false;

            //if (ctDKDich.ID_DM_HOPDONG == ctDKNguon.ID_DM_HOPDONG & ctDKDich.ID_DM_KHOANPHI == ctDKNguon.ID_DM_KHOANPHI
            //    & ctDKDich.ID_DM_PHONGBAN == ctDKNguon.ID_DM_PHONGBAN & ctDKDich.ID_DM_PTQT == ctDKNguon.ID_DM_PTQT
            //    & ctDKDich.ID_DM_TUDO_1 == ctDKNguon.ID_DM_TUDO_1 & ctDKDich.ID_DM_TUDO_2 == ctDKNguon.ID_DM_TUDO_2
            //    & ctDKDich.ID_DM_TUDO_3 == ctDKNguon.ID_DM_TUDO_3 & ctDKDich.ID_DM_TUDO_4 == ctDKNguon.ID_DM_TUDO_4
            //    & ctDKDich.ID_DM_TUDO_5 == ctDKNguon.ID_DM_TUDO_5 & ctDKDich.ID_DM_VUVIEC == ctDKNguon.ID_DM_VUVIEC
            //    & ctDKDich.ID_DOITUONG_1 == ctDKNguon.ID_DOITUONG_1 & ctDKDich.ID_DOITUONG_2 == ctDKNguon.ID_DOITUONG_2
            //    & ctDKDich.ID_DOITUONG_3 == ctDKNguon.ID_DOITUONG_3 & ctDKDich.ID_KHANG == ctDKNguon.ID_KHANG
            //    & ctDKDich.NHOM == ctDKNguon.NHOM & ctDKDich.TK_ID == ctDKNguon.TK_ID)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public int Count_tk_thue(List<KtCtDKhac> lstCTDK)
        {
            int count = 0;

            foreach (KtCtDKhac obj_ctk in lstCTDK)
            {
                if (obj_ctk.MaTk == null)
                {
                    obj_ctk.MaTk = "";
                }

                if ((obj_ctk.MaTk.StartsWith(Generals.TS_ThueGTGTDauVao.GiaTri)) | (obj_ctk.MaTk.StartsWith(Generals.TS_ThueGTGTDauRa.GiaTri)))
                {
                    count = count + 1;
                }
            }

            return count;
        }
	}
}