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
            }
        }
        public static List<string> GetAllAsStrings()
        {
            List<string> lista = new List<string>();
            using (StreamReader sr = new StreamReader("Životinje.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lista.Add(line);
                }
            }
            return lista;
        }
    }
}
