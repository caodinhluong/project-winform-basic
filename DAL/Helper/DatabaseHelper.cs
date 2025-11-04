using System;
using Microsoft.Extensions.Configuration;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;

namespace DAL.Helper
{

    public class DatabaseHelper
    {
        private static readonly IConfigurationRoot _configuration;
        public string StringConnect { get; private set; }

        // Khởi tạo _configuration một lần duy nhất
        static DatabaseHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Đảm bảo lấy đúng thư mục chứa appsettings.json
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();
        }

        // Constructor để lấy chuỗi kết nối
        public DatabaseHelper()
        {
            StringConnect = _configuration.GetConnectionString("MyDBConnection");
        }


        public DataTable ExecuteSProcedureReturnDataTable(out string msgError, string sprocedureName, params object[] paramObjects)
        {
            DataTable tb = new DataTable();
            SqlConnection connection;
            try
            {
                SqlCommand cmd = new SqlCommand { CommandType = CommandType.StoredProcedure, CommandText = sprocedureName };
                connection = new SqlConnection(StringConnect);
                cmd.Connection = connection;

                int parameterInput = (paramObjects.Length) / 2;

                int j = 0;
                for (int i = 0; i < parameterInput; i++)
                {
                    string paramName = Convert.ToString(paramObjects[j++]).Trim();
                    object value = paramObjects[j++];
                    if (paramName.ToLower().Contains("json"))
                    {
                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = paramName,
                            Value = value ?? DBNull.Value,
                            SqlDbType = SqlDbType.NVarChar
                        });
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter(paramName, value ?? DBNull.Value));
                    }
                }
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(tb);
                cmd.Dispose();
                ad.Dispose();
                connection.Dispose();
                msgError = "";
            }
            catch (Exception exception)
            {
                tb = null;
                msgError = exception.ToString();
            }
            return tb;
        }
        public object ExcSPWithTransaction(out string erorr, string sprocedureName, params object[] paramObjects)
        {
            erorr = "";
            object kq = null;
            using (SqlConnection connection = new SqlConnection(StringConnect))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = sprocedureName;
                        cmd.Transaction = transaction;
                        cmd.Connection = connection;

                        int parameterInput = (paramObjects.Length) / 2;
                        int j = 0;
                        for (int i = 0; i < parameterInput; i++)
                        {
                            string paramName = Convert.ToString(paramObjects[j++]);
                            object value = paramObjects[j++];

                            // --- BẮT ĐẦU PHẦN CẬP NHẬT ---
                            if (paramName.ToLower().Contains("json"))
                            {
                                cmd.Parameters.Add(new SqlParameter()
                                {
                                    ParameterName = paramName,
                                    Value = value ?? DBNull.Value,
                                    SqlDbType = SqlDbType.NVarChar
                                });
                            }
                            // THÊM ĐOẠN ELSE IF NÀY VÀO
                            else if (value is DataTable)
                            {
                                // Xử lý Table-Valued Parameter (TVP)
                                SqlParameter tvpParam = new SqlParameter(paramName, SqlDbType.Structured)
                                {
                                    Value = value ?? DBNull.Value
                                };
                                cmd.Parameters.Add(tvpParam);
                            }
                            else
                            {
                                // Giữ lại logic cũ của bạn
                                cmd.Parameters.Add(new SqlParameter(paramName, value ?? DBNull.Value));
                            }
                            // --- KẾT THÚC PHẦN CẬP NHẬT ---
                        }

                        kq = cmd.ExecuteScalar();
                        cmd.Dispose();
                        transaction.Commit();
                    }
                    catch (Exception exception)
                    {

                        kq = null;
                        erorr = exception.ToString();
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex) { }
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return kq;
        }
    }
}
