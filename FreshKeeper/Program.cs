using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreshKeeper.FreshKeeper;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FreshKeeper
{
    internal static class Program
    {
        [STAThread]
        static void Main() {
            // ¶ÁÈ¡config.txtÎÄ¼þ
            string configPath = "config.txt";
            if (!File.Exists(configPath)) {
                Console.WriteLine("Configuration file config.txt not found.");
                return;
            }

            string[] lines = File.ReadAllLines(configPath);
            if (lines.Length < 3) {
                Console.WriteLine("The configuration file format is incorrect.");
                return;
            }

            string connectionString = lines[0];
            string zipPath = lines[1];
            string extractPath = lines[2];

            // Initialize the database
            var initializer = new DatabaseInitializer(connectionString, zipPath, extractPath);
            initializer.InitializeDatabase();

            // Initialize the database manager instance
            DatabaseManager dbManager = DatabaseManager.Instance;

            // Start the application
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
        public class Item
        {
            public string Name { get; set; }
            public DateTime ExpirationDate { get; set; }
            public float UnitPrice { get; set; }
            public int Quantity { get; set; }
            public string HealthStarRating { get; set; }
            public string Category { get; set; }
            public string Preference { get; set; }

            public Item(string name, DateTime expirationDate, float unitPrice, int quantity, string healthStarRating, string category, string preference)
            {
                Name = name;
                ExpirationDate = expirationDate;
                UnitPrice = unitPrice;
                Quantity = quantity;
                HealthStarRating = healthStarRating;
                Category = category;
                Preference = preference;
            }
        }
    }
    
    
    public static class SessionManager
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }

        private static readonly object _lock = new object();
        public static void InitializeSession(int userId, string userName)
        {
            lock (_lock)
            {
                UserId = userId;
                UserName = userName;
            }
        }

    }

    
}