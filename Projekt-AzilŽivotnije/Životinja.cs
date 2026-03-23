using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Projekt_AzilŽivotnije
{
    public class Životinja
    {
        
        public Životinja() { }

        public int ID {get; set; }
        public string ime { get; set; }
        public string vrsta { get; set; }
        public string pasmina { get; set; }
        public bool spol { get; set; }
        public int dob { get; set; }
        public string status { get; set; }//"Udomljen","U azilu"
        public string putanjaSlike { get; set; }
        public DateTime datumDolaska { get; set; }
        public DateTime datumUdomljavanja { get; set; }
        public string  napomena { get; set; }
        public bool cijepljen { get; set; }
        public bool kastriran { get; set; }
        public string udomitelj { get; set; }
        public int kontakt { get; set; }



        public override string ToString()
        {
            return ID + "|" + ime + "|" + vrsta + "|" + pasmina + "|" + spol + "|" + dob + "|" + status + "|" + putanjaSlike + "|" + datumDolaska + "|" + datumUdomljavanja + "|" + napomena + "|" + cijepljen + "|" + kastriran + "|" + udomitelj + "|" + kontakt;
        }
    }
}
