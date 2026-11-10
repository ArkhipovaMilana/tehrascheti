using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FoodCalc.Infrastructure.Persistence
{
    public class DatabaseInitializer
    {
        private readonly string fileName;
        private readonly string directoryName;
        private readonly string filePath;
        public DatabaseInitializer(string _directoryName, string _fileName = "Food.db")
        {
            directoryName = _directoryName;
            fileName = _fileName;

            filePath = Path.Combine(directoryName, fileName);
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
        }

        public string GetDbPath()
        {
            return filePath;
        }

    }
}
