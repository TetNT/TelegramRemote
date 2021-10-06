using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TelegramRemote
{
    class Configuration
    {
        const string cfgFileName = "cfg.dat";

        public static void Save(string token, string fileFolderPath)
        {
            string[] settings = { token, fileFolderPath };
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(cfgFileName, FileMode.OpenOrCreate);
            formatter.Serialize(fs, settings);
            fs.Close();
        }
        
        public static string[] Get()
        {
            if (!File.Exists(cfgFileName)) return new string[] { "", "" };
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(cfgFileName, FileMode.OpenOrCreate);
            if (fs.Length == 0) return new string[] { "", "" };
            string[] settings = (string[])formatter.Deserialize(fs);
            if (!File.Exists(settings[1])) settings[1] = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fs.Close();
            return settings;
        }

    }
}
