using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace lab5
{
    public static class XmlSerializerWrapper
    {
        public static void Serialize<T>(T obj, string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            string NewPath = $"{path}{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}_{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.xml";

            using (FileStream fs = new FileStream(NewPath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        public static T Deserialize<T>(string path)
        {
            T obj;
            using(FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                obj = (T)formatter.Deserialize(fs);
            }

            return obj;
        }
    }
}
