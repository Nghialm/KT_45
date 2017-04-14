using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.Erp.Core.Accounting.Domain;
using Vns.Erp.Core.Accounting.Domain.Extend;

namespace Vns.Erp.Core.Controls.Commons
{
    public class DataAccHelper
    {
        public static List<CT_H_GInfo> ConvertLstObjCtHtoCtHG(IList<CtH> lstObjCtH)
        {
            try
            {
                List<CT_H_GInfo> lstobjCTHG = new List<CT_H_GInfo>();
                for (int i = 0; i <= lstObjCtH.Count - 1; i++)
                {
                    CT_H_GInfo objCTHG = new CT_H_GInfo(lstObjCtH[i]);
                    lstobjCTHG.Add(objCTHG);
                }
                if (lstobjCTHG.Count > 0)
                {
                    return lstobjCTHG;
                }
                else
                {
                    return new List<CT_H_GInfo>();
                }
            }
            catch (Exception ex)
            {
                return new List<CT_H_GInfo>();
            }
        }

        public static List<CT_H_GInfo> ConvertLstObjCtHtoCtHG(IList<KtCtHKhac> lstObjCtH)
        {
            try
            {
                List<CT_H_GInfo> lstobjCTHG = new List<CT_H_GInfo>();
                for (int i = 0; i <= lstObjCtH.Count - 1; i++)
                {
                    CT_H_GInfo objCTHG = new CT_H_GInfo(lstObjCtH[i]);
                    lstobjCTHG.Add(objCTHG);
                }
                if (lstobjCTHG.Count > 0)
                {
                    return lstobjCTHG;
                }
                else
                {
                    return new List<CT_H_GInfo>();
                }
            }
            catch (Exception ex)
            {
                return new List<CT_H_GInfo>();
            }
        }

        public static List<CT_H_GInfo> ConvertToCTHG(IList<CtHNx> lstObjCTHNX)
        {
            try
            {
                List<CT_H_GInfo> lstobjCTHG = new List<CT_H_GInfo>();
                for (int i = 0; i <= lstObjCTHNX.Count - 1; i++)
                {
                    CT_H_GInfo objCTHG = new CT_H_GInfo(lstObjCTHNX[i]);
                    lstobjCTHG.Add(objCTHG);
                }
                if (lstobjCTHG.Count > 0)
                {
                    return lstobjCTHG;
                }
                else
                {
                    return new List<CT_H_GInfo>();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<CT_H_GInfo> ConvertToCTHG(IList<KtCtHHddv> lstObjCTHNX)
        {
            try
            {
                List<CT_H_GInfo> lstobjCTHG = new List<CT_H_GInfo>();
                for (int i = 0; i <= lstObjCTHNX.Count - 1; i++)
                {
                    CT_H_GInfo objCTHG = new CT_H_GInfo(lstObjCTHNX[i]);
                    lstobjCTHG.Add(objCTHG);
                }
                if (lstobjCTHG.Count > 0)
                {
                    return lstobjCTHG;
                }
                else
                {
                    return new List<CT_H_GInfo>();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
