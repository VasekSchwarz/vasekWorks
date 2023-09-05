using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidencePojisteniSchwarz
{
    internal class Zaznam
    {
       
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Cislo { get; set; }
        public int Vek { get; set;}

        public Zaznam( string jmeno, string prijmeni, int cislo, int vek) 
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Cislo = cislo;
            this.Vek = vek;
            
        }

        public override string ToString()
        {
            return Jmeno.PadRight(10) + "   " + Prijmeni.PadRight(10) + "   " + Vek + "   " + Cislo;
            
        }
    }
}
