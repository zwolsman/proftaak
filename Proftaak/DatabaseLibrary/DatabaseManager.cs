using System;
using System.CodeDom.Compiler;
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
        private const string SQL_SELECT_ALL = "SELECT * FROM {0}";
        private const string SQL_SELECT_SPECIFIC = "SELECT {0} FROM {1}";
        private const string SQL_INSERT = "INSERT INTO {0}({1}) VALUES ({2})";
        private const string SQL_UPDATE_WHERE = "UPDATE {0} SET {1} WHERE {2}={3}";
        private const string SQL_UPDATE_WHERE2 = "UPDATE {0} SET {1} WHERE {2}={3} AND {4}={5}";
        private const string SQL_EXISTS = "SELECT * FROM {0} WHERE {1}";
        private const string SQL_EXISTS_MAX = "SELECT RFID, Item, MAX(LeaseDate) FROM {0} WHERE {1} GROUP BY RFID, Item";
        private const string SQL_AVAILABLE_ITEMS = "SELECT * FROM AvailableItems WHERE {0}={1}";
        private const string SQL_RESERVED_ITEMS = "SELECT ID, Material, Productcode FROM ReservedItems WHERE {0}={1}";
        private const string SQL_RESERVED_ITEMS2 = "SELECT ID, Material, Productcode FROM ReservedItems WHERE {0}={1} AND (Departure<{2} OR ReservationDate>{3})";
        private const string SQL_SELECT_LEASEPLACEID = "SELECT t.ID FROM (SELECT lp.ID, p.ID AS Person FROM lease_place lp LEFT JOIN Person p ON p.Account = lp.Account OR p.Lease = lp.Lease) t WHERE t.Person IN (SELECT person FROM rfid_person WHERE RFID = {0})";
        private const string SQL_SELECT_PERSON_FORM_RFID = "SELECT p.* FROM Person p, RFID_Person rp WHERE p.ID=rp.Person AND rp.RFID={0}";
        private const string SQL_SELECT_Persons = "SELECT p.* FROM Person p, Lease_Place lp WHERE p.Present={0} AND (p.Account= lp.Account OR p.Lease= lp.Lease) AND lp.Event={1} ";

        private const string CONNECTION_STRING_FORMAT = "Server={0};Database={1};User Id={2};Password={3};";
        private static SqlConnection _connection;
        private static string connectionString = "";
        public static bool IsConnected => _connection != null && _connection.State == ConnectionState.Open;

        //Map class names to table names. 
        private static readonly Dictionary<string, string> classMappings = new Dictionary<string, string>()
        {
            {"Evenement", "Event"},             //Class evenement -> database table Event
            {"LeasePlace", "Lease_Place" },     //Class LeasePlace -> database table Lease_Place
            {"RFIDPerson", "RFID_Person" },     //Class RFIDPerson -> database table RFID_Person
        };

        private static readonly List<String> idList = new List<string>()
        {
            "ID",
            "Cardnumber",
        };


        public static void Initialize(string username, string password, string server, string database)
        {
            connectionString = string.Format(CONNECTION_STRING_FORMAT, server, database, username, password);
        }

        public static void Open()
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public static int Execute(string sql)
        {
            Debug.WriteLine("SQL: " + sql);
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
            Debug.WriteLine("SQL: " + sql);

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
            string qur = string.Format(SQL_SELECT_ALL, tableName);

            return HashtableToItem<T>(QueryFirst(qur));
        }

        public static IEnumerable<T> GetItems<T>()
        {
            string tableName = classMappings.ContainsKey(typeof (T).Name)
                ? classMappings[typeof (T).Name]
                : typeof (T).Name;
            string qur = string.Format(SQL_SELECT_ALL, tableName);


            return Query(qur).Select(HashtableToItem<T>).ToList();
        }

        public static IEnumerable<T> GetItems<T>(dynamic searchCriteria)
        {
            string tableName = classMappings.ContainsKey(typeof(T).Name)
                ? classMappings[typeof(T).Name]
                : typeof(T).Name;

            
            string joinTable = classMappings.ContainsKey(searchCriteria.GetType().Name)
                ? classMappings[searchCriteria.GetType().Name]
                : searchCriteria.GetType().Name;
            string qur = string.Format("SELECT * FROM {0} WHERE {1}={2}", tableName, joinTable, searchCriteria.ID);
            return Query(qur).Select(HashtableToItem<T>).ToList();

        }

        public static bool InsertItem<T>(T item)
        {
            string tableName = classMappings.ContainsKey(typeof (T).Name)
                ? classMappings[typeof (T).Name]
                : typeof (T).Name;
            Hashtable hashtable = ItemToHashtable<T>(item);
            string columnNames =
                hashtable.Keys.Cast<object>()
                    .Aggregate("", (current, key) => current + (key.ToString() + ", "))
                    .Trim(',', ' ');

            string columnValues = Helper.GetValues(hashtable, tableName);


            string qur = string.Format(SQL_INSERT, tableName, columnNames, columnValues);
            return Execute(qur) != -1;
        }

        public static bool UpdateItem<T>(T item)
        {
            string tableName = classMappings.ContainsKey(typeof(T).Name)
               ? classMappings[typeof(T).Name]
               : typeof(T).Name;
            if (tableName.Contains("Material") && !tableName.Equals("Material"))
                return UpdateDate(item);
            Hashtable hashtable = ItemToHashtable<T>(item);

            string newValues = "";
            string id = "";
            foreach (DictionaryEntry row in hashtable)
            {
                if (idList.Contains(row.Key.ToString()))
                {
                    id = row.Key.ToString();
                    continue;
                }
                newValues += $"{row.Key} = {Helper.GetValue(row.Value)}, ";
            }

            newValues = newValues.Trim(',', ' ');
            string qur = string.Format(SQL_UPDATE_WHERE, tableName, newValues, id, hashtable[id]);
            return Execute(qur) != -1;
        }

        private static bool UpdateDate<T>(T item)
        {
            string tableName = classMappings.ContainsKey(typeof(T).Name)
               ? classMappings[typeof(T).Name]
               : typeof(T).Name;
            Hashtable hashtable = ItemToHashtable<T>(item);

            string newValues = "";
            foreach (DictionaryEntry row in hashtable)
            {
                if (row.Key.ToString() == "RFID" || row.Key.ToString() == "Item")
                {
                    continue;
                }
                newValues += $"{row.Key} = {Helper.GetValue(row.Value)}, ";
            }

            newValues = newValues.Trim(',', ' ');
            string qur = string.Format(SQL_UPDATE_WHERE2, tableName, newValues, "RFID", hashtable["RFID"], "Item", hashtable["Item"]);
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

        public static bool DeleteDate<T>(T item)
        {
            string tableName = typeof(T).Name;
            if (!tableName.Contains("Material") || tableName.Equals("Material"))
                return false;
            Hashtable hashtable = ItemToHashtable<T>(item);

            string qur = $"DELETE FROM {tableName} WHERE RFID={hashtable["RFID"]} AND Item={hashtable["Item"]}";
            return Execute(qur) != -1;
        }

        public static T ContainsItem<T>(T item, params string[] props)
        {
            string tableName = classMappings.ContainsKey(typeof(T).Name)
             ? classMappings[typeof(T).Name]
             : typeof(T).Name;

            if (props == null)
                return default(T);

            string where = "";
            for (int i = 0; i < props.Length; i++)
            {
                PropertyInfo propInfo = typeof (T).GetProperty(props[i]);

                if(propInfo == null)
                    continue;
                where += $"{props[i]}={Helper.GetValue(propInfo.GetValue(item))}";
                if (i + 1 < props.Length)
                    where += " AND ";
            }

            if (where.EndsWith(" AND "))
                where = where.Substring(0, where.Length - " AND ".Length);

            string sql = string.Format(SQL_EXISTS, tableName, where);

            return HashtableToItem<T>(QueryFirst(sql));
        }

        public static T ContainsLease<T>(T item, params string[] props)
        {
            string tableName = classMappings.ContainsKey(typeof(T).Name)
             ? classMappings[typeof(T).Name]
             : typeof(T).Name;

            if (props == null)
                return default(T);

            string where = "";
            for (int i = 0; i < props.Length; i++)
            {
                PropertyInfo propInfo = typeof(T).GetProperty(props[i]);

                if (propInfo == null)
                    continue;
                where += $"{props[i]}={Helper.GetValue(propInfo.GetValue(item))}";
                if (i + 1 < props.Length)
                    where += " AND ";
            }

            if (where.EndsWith(" AND "))
                where = where.Substring(0, where.Length - " AND ".Length);

            string sql = string.Format(SQL_EXISTS_MAX, tableName, where);

            return HashtableToItem<T>(QueryFirst(sql));
        }

        public static IEnumerable<T> AvailableItems<T>(dynamic searchCriteria, DateTime from, DateTime till)
        {
            //TODO: kijken of dit kan/testen
            string joinTable = classMappings.ContainsKey(searchCriteria.GetType().Name)
                ? classMappings[searchCriteria.GetType().Name]
                : searchCriteria.GetType().Name;
            string qur = string.Format(SQL_RESERVED_ITEMS2, joinTable, searchCriteria.ID, from.ToString(), till.ToString());
            string que = string.Format(SQL_AVAILABLE_ITEMS, joinTable, searchCriteria.ID);
            return Query(qur).Select(HashtableToItem<T>).ToList().Union(Query(que).Select(HashtableToItem<T>).ToList());
        }

        public static IEnumerable<T> AvailableItems<T>(dynamic searchCriteria)
        {
            //TODO: kijken of dit kan/testen
            string joinTable = classMappings.ContainsKey(searchCriteria.GetType().Name)
                ? classMappings[searchCriteria.GetType().Name]
                : searchCriteria.GetType().Name;
            string qur = string.Format(SQL_AVAILABLE_ITEMS, joinTable, searchCriteria.ID);
            return Query(qur).Select(HashtableToItem<T>).ToList();
        }

        public static IEnumerable<T> AvailableItems<T>(dynamic searchCriteria, bool available)
        {
            //TODO: kijken of dit kan/testen
            if (available)
                return AvailableItems<T>(searchCriteria);
            string joinTable = classMappings.ContainsKey(searchCriteria.GetType().Name)
                ? classMappings[searchCriteria.GetType().Name]
                : searchCriteria.GetType().Name;
            string qur = string.Format(SQL_RESERVED_ITEMS, joinTable, searchCriteria.ID);
            return Query(qur).Select(HashtableToItem<T>).ToList();
        }

        public static int GetLeasePlaceID(string RFID)
        {
            string qry = string.Format(SQL_SELECT_LEASEPLACEID, RFID);
            Hashtable t = QueryFirst(qry);
            return int.Parse(t["ID"].ToString());
        }

        public static T GetPerson<T>(string RFID)
        {
            string qry = string.Format(SQL_SELECT_PERSON_FORM_RFID, RFID);
            return HashtableToItem<T>(QueryFirst(qry));
        }

        public static IEnumerable<T> GetPersons<T>(bool present, dynamic searchCriteria)
        {
            string s = "N";
            if (present)
                s = "Y";
            string qry = string.Format(SQL_SELECT_Persons, s, searchCriteria.ID);
            Hashtable[] h = Query(qry);
            if (h == null)
                return null;
            return h.Select(HashtableToItem<T>).ToList();
        }

        private static T HashtableToItem<T>(Hashtable info)
        {
            if (info == null)
                return default(T);
            T returnObject = (T) Activator.CreateInstance(typeof (T));
            foreach (DictionaryEntry row in info)
            {
                PropertyInfo propInfo = typeof (T).GetProperty(row.Key.ToString());

                if (propInfo == null)
                {
                    Debug.WriteLine($"Error, can't find property {row.Key}");
                    continue;
                }
                if (!propInfo.CanWrite)
                    continue;

                if (propInfo.PropertyType == typeof (string))
                {
                    propInfo.SetValue(returnObject, row.Value.ToString());
                    continue;
                }
                if (propInfo.PropertyType == typeof (int))
                {
                    if(row.Value.ToString().Equals(""))
                        propInfo.SetValue(returnObject, null);
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
                if (p.PropertyType.Name.Equals(typeof(List<>).Name))
                    continue;
                if (p.GetValue(item) == null)
                    continue;
                table[p.Name] = p.GetValue(item);
            }
            return table;
        }
    }
}