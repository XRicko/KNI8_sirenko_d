using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Core
{
    public class FileManager
    {
        public void Serialization<TClass> (TClass @class, string name)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(TClass));
            using (FileStream fs = new FileStream(name, FileMode.Create))
            {
                formatter.Serialize(fs, @class);
            }
        }

        public TClass Desialization<TClass> (string name)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(TClass));
            TClass newCalc;

            using (FileStream fs = File.OpenRead(name))
            {
                newCalc = (TClass)formatter.Deserialize(fs);
            }

            return newCalc;
        }
    }
}
