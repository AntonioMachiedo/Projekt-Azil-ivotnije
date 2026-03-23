using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AzilŽivotnije
{
    public static class Admin
    {
        public static void SaveAnimals(string zapis)
        {
            using (StreamWriter sw = new StreamWriter("Životinje.txt", true))
            {
                sw.WriteLine(zapis);
                sw.Close();
            }
        }
        public static List<string> GetAllAsStrings()
        {
            List<string> životinje = new List<string>();
            if (File.Exists("Životinje.txt"))
            {
                using (StreamReader sr = new StreamReader("Životinje.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        životinje.Add(line);
                    }
                }
            }
            return životinje;
        }

    }
}
