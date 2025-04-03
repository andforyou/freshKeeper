using System;
using System.IO;
using System.IO.Compression;
using MySql.Data.MySqlClient;

namespace FreshKeeper {
    namespace FreshKeeper {
        public class DatabaseInitializer {
            private string _connectionString;
            private string _zipPath;
            private string _extractPath;

            public DatabaseInitializer(string connectionString, string zipPath, string extractPath) {
                _connectionString = connectionString;
                _zipPath = zipPath;
                _extractPath = extractPath;
            }

            // Check if the database is empty
            private bool IsDatabaseEmpty() {
                using (var connection = new MySqlConnection(_connectionString)) {
                    connection.Open();
                    using (var cmd = new MySqlCommand("SHOW TABLES;", connection)) {
                        using (var reader = cmd.ExecuteReader()) {
                            return !reader.HasRows; 
                        }
                    }
                }
            }

            // Unzip the Sql file
            private void UnzipFile() {
                if (!Directory.Exists(_extractPath)) {
                    Directory.CreateDirectory(_extractPath);
                }
                ZipFile.ExtractToDirectory(_zipPath, _extractPath);
            }

            // Execute SQL script
            private void ExecuteSqlScript(string filePath) {
                if (!File.Exists(filePath)) {
                    Console.WriteLine("SQL file not found, please check if the path is correct.");
                    return;
                }

                string script = File.ReadAllText(filePath);

                using (var connection = new MySqlConnection(_connectionString)) {
                    connection.Open();

                   
                    var sqlCommands = script.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var command in sqlCommands) {
                        if (!string.IsNullOrWhiteSpace(command)) {
                            using (var cmd = new MySqlCommand(command, connection)) {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            
            public void InitializeDatabase() {
                if (IsDatabaseEmpty()) {
                    Console.WriteLine("The database is empty, start decompression and initialization...");
                    UnzipFile();
                    string sqlFilePath = Path.Combine(_extractPath, "FreshKeeper_Database.sql");

                    if (File.Exists(sqlFilePath)) {
                        ExecuteSqlScript(sqlFilePath);
                        Console.WriteLine("Database initialization completed!");
                    } else {
                        Console.WriteLine("No SQL file found after decompression.");
                    }
                } else {
                    Console.WriteLine("Database is not empty, skipping initialization.");
                }
            }
        }
    }
}
