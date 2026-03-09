using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Projekt_AzilŽivotnije
{
    public class Životinja
    {
        public Životinja() { }
        public string ime { get; set; }
        public string vrsta { get; set; }
        public string pasmina { get; set; }
        public bool spol { get; set; }
        public int dob { get; set; }
        public string datumDolaska { get; set; }
        public string napomena { get; set; }
        public bool cijepljen { get; set; }
        public bool kastriran { get; set; }

    

    public override string ToString()
        {
            return ime + ";" + vrsta + ";" + pasmina + ";" + spol + ";" + dob + ";" + datumDolaska + ";" + napomena + ";" + cijepljen + ";" + kastriran;
        }
    }
}
