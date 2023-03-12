using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GrafApp
{
    public static class DataController
    {

        public static bool IsFile(string path) => File.Exists(path);

        public static Data Load(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
            Data data = null;

            if(!IsFile(path)) throw new Exception();

            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                data = xmlSerializer.Deserialize(file) as Data;
            }
            return data;
        }

        public static void Save(Data data, string path)
        {
            if (data == null) throw new Exception();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                xmlSerializer.Serialize(file, data);
            }
        }
    }
}
