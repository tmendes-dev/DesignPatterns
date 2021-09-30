using System.IO;

namespace SingleResponsabilityPrinciple
{
    public class Persistance
    {
        public void SaveToFile(Journal journal, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());
        }
    }
}