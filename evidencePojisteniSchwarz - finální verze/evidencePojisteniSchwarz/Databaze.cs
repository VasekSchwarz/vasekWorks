using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidencePojisteniSchwarz
{
    internal class Databaze
    {
        private List<Zaznam> zaznamy;

        public Databaze()
        {
            zaznamy = new List<Zaznam>();
        }
        public void PridejZaznam( string jmeno, string prijmeni, int vek, int cislo)
        {
            zaznamy.Add(new Zaznam( jmeno, prijmeni, vek, cislo));
        }

        public void Vypis() 
        {
            foreach(Zaznam z in zaznamy) 
            {
                Console.WriteLine(z);
            }
        }

        public void VymazZaznamy(string jmeno,string prijmeni)
        {
            List<Zaznam> nalezeno = NajdiZaznamy(jmeno,prijmeni);
            foreach(Zaznam z in nalezeno)
                zaznamy.Remove(z);
        }
        
        public List<Zaznam> NajdiZaznamy(string jmeno, string prijmeni)
        {
            List<Zaznam> nalezene = new List<Zaznam>();
            foreach (Zaznam z in zaznamy)
            {
                if ((z.Jmeno == jmeno) && (z.Prijmeni == prijmeni)) 
                    
                    nalezene.Add(z);
            }
            return nalezene;
        }

      public void SeznamPojistencu(string jmeno, string prijmeni) 
        {
            List<Zaznam> nalezene = NajdiZaznamy(jmeno, prijmeni);
            foreach (Zaznam z in zaznamy) 
            {
                if ((z.Jmeno != null) && (z.Prijmeni != null))

                    nalezene.Add(z);
            }
            
                
        }
        

       



















    }
   
}
