using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DAL.Helper
{
    public static class ConvertHelper
    {
        // Chuyển từ DataTable sang IList<T>
        public static IList<T> ConvertTo<T>(this DataTable table)
        {
            if (table == null)
            {
                return null;
            }

            var rows = new List<DataRow>();

            foreach (DataRow row in table.Rows)
            {
                rows.Add(row);
            }

            return ConvertTo<T>(rows);
        }

        // Chuyển từ List<DataRow> sang IList<T>
        private static IList<T> ConvertTo<T>(List<DataRow> rows)
        {
            if (rows == null || rows.Count == 0)
            {
                return new List<T>();
            }

            IList<T> result = new List<T>();
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (DataRow row in rows)
            {
                T instance = Activator.CreateInstance<T>(); // Tạo instance của T

                foreach (PropertyInfo prop in properties)
                {
                    // Kiểm tra xem cột trong DataRow có khớp với tên thuộc tính không
                    if (row.Table.Columns.Contains(prop.Name))
                    {
                        object value = row[prop.Name];
                        if (value != DBNull.Value) // Kiểm tra giá trị null từ DB
                        {
                            // Chuyển đổi kiểu dữ liệu phù hợp
                            prop.SetValue(instance, Convert.ChangeType(value, prop.PropertyType));
                        }
                    }
                }

                result.Add(instance);
            }

            return result;
        }
    }
}