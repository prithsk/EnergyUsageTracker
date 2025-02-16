using System;
using System.Data.SQLite;
using System.IO;
using Dapper;
using System.Collections.Generic;

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
    }
}