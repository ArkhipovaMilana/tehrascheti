using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalc.Infrastructure.Persistence
{
    public class DataInitializer
    {
        private readonly string connectionString;
        private bool TableExists(string connectionString, string tableName)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT count(*) FROM sqlite_master WHERE type='table' AND name=@TableName;";

                using (var cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@TableName", tableName);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public DataInitializer(string dbPath)
        {
            var builder = new SQLiteConnectionStringBuilder
            {
                DataSource = dbPath
            };
            connectionString = builder.ConnectionString;
            if (TableExists(connectionString, "Products"))
            {
                Console.WriteLine("data already initialized!");
                return;
            }
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = $"{assembly.GetName().Name}.DatabaseData.init.sql";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    throw new Exception($"script file {resourceName} does not exist.");
                using (StreamReader reader = new StreamReader(stream))
                {
                    string sqlScript = reader.ReadToEnd();
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        using (var command = new SQLiteCommand(sqlScript, connection))
                        {
                            command.ExecuteNonQuery();
                            Console.WriteLine("db initialized!");
                        }
                    }
                }
            }

        }
    }
}
