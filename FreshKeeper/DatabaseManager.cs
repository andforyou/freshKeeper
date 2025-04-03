using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace FreshKeeper
{
    public class DatabaseManager : IDatabaseManager
    {
        private static DatabaseManager _instance;
        private static readonly object _lock = new object();
        private MySqlConnection _connection;

     
        private DatabaseManager()
        {
            
            // Read config.txt file
            string configPath = "config.txt";
            if (!File.Exists(configPath)) {
                Console.WriteLine("config.txt not found.");
                return;
            }

            string[] lines = File.ReadAllLines(configPath);
            if (lines.Length < 3) {
                Console.WriteLine("config.txt not right.");
                return;
            }

            string connectionString = lines[0];
            
            _connection = new MySqlConnection(connectionString);
            OpenConnection();
        }

        
        public static DatabaseManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseManager();
                    }
                    return _instance;
                }
            }
        }

        
        private void OpenConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
            }
        }

        
        public void CloseConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
        }

        
        public MySqlConnection Connection
        {
            get
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    OpenConnection();
                }
                return _connection;
            }
        }

     
        public object ExecuteScalar(string query, Action<MySqlCommand> parameterSetter)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                parameterSetter(cmd);
                try
                {
                    return cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    return null;
                }
            }
        }

        
        public List<Dictionary<string, object>> ExecuteReader(string query, Action<MySqlCommand> parameterSetter)
        {
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                parameterSetter(cmd);
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }

                            results.Add(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogException(ex);
                }
            }

            return results;
        }

        
        public int ExecuteNonQuery(string query, Action<MySqlCommand> parameterSetter)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, Connection))
            {
                parameterSetter(cmd);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    LogException(ex);
                    return -1;
                }
            }
        }

       
        private void LogException(Exception ex)
        {
            Console.WriteLine($"[Error] {DateTime.Now}: {ex.Message}\n{ex.StackTrace}");
        }
    }
}
