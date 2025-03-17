using System;
using System.Data.SQLite;
using System.IO;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnergyUsageTracker
{
    public static class DatabaseHelper
    {
        private static readonly string dbPath = "EnergyUsageTracker.db";
        private static readonly string connectionString = $"Data Source={dbPath};Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var createTablesQuery = @"
                    CREATE TABLE IF NOT EXISTS Appliances (
                        ApplianceID INTEGER PRIMARY KEY AUTOINCREMENT,
                        ApplianceName TEXT NOT NULL,
                        Wattage INTEGER NOT NULL,
                        UsageDuration TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS CompletedGoals (
                        GoalID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Goal TEXT NOT NULL,
                        Details TEXT NOT NULL,
                        CompletionDate DATE NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Goals (
                        GoalID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Goal TEXT NOT NULL,
                        Progress TEXT NOT NULL,
                        Difficulty TEXT NOT NULL
                    );
                ";
                connection.Execute(createTablesQuery);
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
        //make sure to check the error here
        public void AddAppliance(string name, decimal power, decimal hours)
        {
            string query = "INSERT INTO Appliance (Name, PowerConsumption, UsageHoursPerDay, DateAdded) VALUES (@name, @power, @hours, @date)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@power", power);
                cmd.Parameters.AddWithValue("@hours", hours);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}