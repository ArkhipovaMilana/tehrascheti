//DatabaseInitializer — создаёт директорию, БД, таблицы и при необходимости заполняет начальными данными.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FoodCalc.Infrastructure.Persistence
{
    internal class DatabaseInitializer
    {
        private readonly string appData;
        private readonly string directory;
        private readonly string databasePath;

        public DatabaseInitializer()
        {
            appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            directory = Path.Combine(appData, "FoodCalc");

            Directory.CreateDirectory(directory);

            databasePath = Path.Combine(directory, "products.db");
        }
    }
}
