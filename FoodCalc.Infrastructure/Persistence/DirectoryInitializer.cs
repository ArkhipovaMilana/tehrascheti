///Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalc.Infrastructure.Persistence
{
    public class DirectoryInitializer
    {
        private readonly string dataFolder;
        private readonly string folderName;
        private readonly string directory;

        public DirectoryInitializer(string _dataFolder, string _folderName = "FoodCalc")
        {
            dataFolder = _dataFolder;

            folderName = _folderName;

            directory = Path.Combine(dataFolder, folderName);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
        public string GetDirectoryPath()
        {
            return directory;
        }
    }
}
