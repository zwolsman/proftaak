using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class DatabaseManager
    {
        private static SqlConnection _connection;
        private static string connectionString = "Server={0};Database={1};User Id={2};Password={3};";

        public static bool IsConnected => _connection != null && _connection.State == ConnectionState.Open;

        public static void Open()
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public static void Initialize(string username, string password, string server, string database)
        {
            connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        }

        public static int Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _connection);

            if (cmd.ExecuteNonQuery() > 0)
            {
                if (sql.ToUpper().StartsWith("DELETE") || sql.ToUpper().StartsWith("UPDATE") || sql.ToUpper().StartsWith("INSERT"))
                    return 1;
                return int.Parse(QueryFirst("SELECT @@IDENTITY")["Column1"].ToString());

            }
            else
            {
                return -1;
            }
        }

        public static Hashtable QueryFirst(string sql)
        {
            Hashtable[] result = Query(sql);
            if (result != null && result.Length >= 1)
                return result[0];
            return null;
        }

        public static Hashtable[] Query(string sql)
        {
            Hashtable[] output;
            lock (_connection)
            {
                SqlCommand cmd = new SqlCommand(sql, _connection);
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        output = new Hashtable[dt.Rows.Count];
                        int index = 0;
                        foreach (DataRow r in dt.Rows)
                        {
                            Hashtable row = new Hashtable();
                            foreach (DataColumn d in dt.Columns)
                            {
                                row.Add(d.ColumnName, r[d].ToString().Trim());
                            }
                            output[index++] = row;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }
            }
            return output;
        }
    }
}
