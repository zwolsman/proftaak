using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class DatabaseManager
    {
        private static SqlConnection _connection;
        private static string connectionString = "Server={0};Database={1};User Id={2};Password={3};";
        public static bool IsConnected => _connection != null && _connection.State == ConnectionState.Open;

        //Map class names to table names. 
        private static readonly Dictionary<string, string> classMappings = new Dictionary<string, string>()
        {
            {"Evenement", "Event"} //Class evenement -> database table Event
        };


        public static void Initialize(string username, string password, string server, string database)
        {
            connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
        }

        public static void Open()
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public static int Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, _connection);

            if (cmd.ExecuteNonQuery() > 0)
            {
                if (sql.ToUpper().StartsWith("DELETE") || sql.ToUpper().StartsWith("UPDATE") ||
                    sql.ToUpper().StartsWith("INSERT"))
                    return 1;
                return int.Parse(QueryFirst("SELECT @@IDENTITY")["Column1"].ToString());
            }
            else
            {
                return -1;
            }
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

        public static Hashtable QueryFirst(string sql)
        {
            Hashtable[] result = Query(sql);
            if (result != null && result.Length >= 1)
                return result[0];
            return null;
        }

        public static T GetItem<T>()
        {
            string tableName = classMappings.ContainsKey(typeof (T).Name)
                ? classMappings[typeof (T).Name]
                : typeof (T).Name;
            string qur = "SELECT * FROM " + tableName;

            return HashtableToItem<T>(QueryFirst(qur));
        }

        public static IEnumerable<T> GetItems<T>()
        {
            string tableName = classMappings.ContainsKey(typeof (T).Name)
                ? classMappings[typeof (T).Name]
                : typeof (T).Name;
            string qur = "SELECT * FROM " + tableName;

            return Query(qur).Select(HashtableToItem<T>).ToList();
        }

        public static bool InsertItem<T>(T item)
        {
            string tableName = classMappings.ContainsKey(typeof (T).Name)
                ? classMappings[typeof (T).Name]
                : typeof (T).Name;
            Hashtable hashtable = ItemToHashtable<T>(item);
            string insert = "INSERT INTO " + tableName + "({0}) VALUES ({1});";

            string tableNames =
                hashtable.Keys.Cast<object>()
                    .Aggregate("", (current, key) => current + (key.ToString() + ", "))
                    .Trim(',', ' ');

            string values = Helper.GetValues(hashtable, tableName);

            insert = string.Format(insert, tableNames, values);

            return Execute(insert) != -1;
        }

        public static bool UpdateItem<T>(T item)
        {
            string tableName = classMappings.ContainsKey(typeof(T).Name)
               ? classMappings[typeof(T).Name]
               : typeof(T).Name;
            Hashtable hashtable = ItemToHashtable<T>(item);

            string qur = "UPDATE " + tableName + " SET {0} WHERE id={1}";

            string temp = "";
            foreach (DictionaryEntry row in hashtable)
            {
                if (row.Key.ToString() == "ID")
                {
                    continue;
                }
                temp += $"{row.Key} = {Helper.GetValue(row.Value)}, ";
            }

            temp = temp.Trim(',', ' ');
            qur = string.Format(qur, temp, hashtable["ID"]);

            return Execute(qur) != -1;
        }

        public static bool DeleteItem<T>(T item)
        {
            string tableName = classMappings.ContainsKey(typeof(T).Name)
              ? classMappings[typeof(T).Name]
              : typeof(T).Name;
            Hashtable hashtable = ItemToHashtable<T>(item);

            if (!hashtable.ContainsKey("ID"))
                return false;

            string qur = $"DELETE FROM {tableName} WHERE ID={hashtable["ID"]}";
            return Execute(qur) != -1;
        }
        private static T HashtableToItem<T>(Hashtable info)
        {
            T returnObject = (T) Activator.CreateInstance(typeof (T));
            foreach (DictionaryEntry row in info)
            {
                PropertyInfo propInfo = typeof (T).GetProperty(row.Key.ToString());

                if (propInfo == null)
                {
                    Debug.WriteLine($"Error, can't find property {row.Key.ToString()}");
                    continue;
                }
                if (propInfo.PropertyType == typeof (string))
                {
                    propInfo.SetValue(returnObject, row.Value.ToString());
                    continue;
                }
                if (propInfo.PropertyType == typeof (int))
                {
                    propInfo.SetValue(returnObject, int.Parse(row.Value.ToString()));
                    continue;
                }

                if (propInfo.PropertyType == typeof (DateTime))
                {
                    propInfo.SetValue(returnObject, DateTime.Parse(row.Value.ToString()));
                    continue;
                }
                Debug.WriteLine($"Error, did not convert type {propInfo.PropertyType}");
            }
            return returnObject;
        }

        private static Hashtable ItemToHashtable<T>(T item)
        {
            Hashtable table = new Hashtable();
            foreach (var p in typeof (T).GetProperties())
            {
                table[p.Name] = p.GetValue(item);
            }
            return table;
        }

       
    }
}