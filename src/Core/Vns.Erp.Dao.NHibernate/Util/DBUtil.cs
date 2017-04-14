using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Vns.Erp.Core.Dao.Util
{
    public static class DBUtil
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            for (int i = 0; i < properties.Count; i++)
            {
                PropertyDescriptor property = properties[i];
                try
                {
                    dt.Columns.Add(property.Name, property.PropertyType);
                }
                catch
                {
                    dt.Columns.Add(property.Name, typeof(DateTime));
                }

                
            }
            object[] values = new object[properties.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (properties[i].PropertyType == typeof(DateTime))
                    {
                        DateTime tmp = (DateTime) properties[i].GetValue(item);
                        values[i] = tmp <= DateTime.MinValue ? null : properties[i].GetValue(item);
                    }
                    else
                        values[i] = properties[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        
    }
}

