using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalc.Infrastructure.Persistence
{
    public static class DbInitializer
    {
        static string directoryname = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FoodCalc");
        static string fullfilename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FoodCalc","ProductData.db");
        public static void DbInitialize()
        {
            if (!Directory.Exists(directoryname))
            { 
                Directory.CreateDirectory(directoryname);
            }
            if (!File.Exists(fullfilename))
            {
                File.Create(fullfilename);
            }
        }
        public static string ShowPath()
        {
            return fullfilename;
        }
    }
}
