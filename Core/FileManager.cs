using System.IO;
using System.Runtime.Serialization;

namespace Core
{
    public class FileManager<TClass, TFile>
        where TClass : AbsCalculator
        where TFile : IFormatter, new()
    {
        public TFile Formatter { get; set; }

        public FileManager()
        {
            Formatter = new TFile();
        }

        public void Serialization(TClass sad, string name)
        {
            using (FileStream fs = new FileStream(name, FileMode.Create))
            {
                Formatter.Serialize(fs, sad);
            }
        }
    }
}
