using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace evidencePojisteniSchwarz
{
    internal class Pojistenci
    {
        private Databaze databaze;

        public Pojistenci() 
        {
            databaze = new Databaze();
        }

       public void VypisSeznam() 
        {
           databaze.Vypis();
            Console.WriteLine("Pokračujte libovolnou klávesou...");

        }
        
        
        public void PridejZaznam() 
        {
            
            Console.WriteLine("Zadejte jméno: ");
            string jmeno = Console.ReadLine();
                       

            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();

            
            Console.WriteLine("Zadejte telefonní číslo: ");
            string t = Console.ReadLine();
            int cislo = int.Parse(t);

            
            Console.WriteLine("Zadejte věk:");
            string v = Console.ReadLine();
            int vek = int.Parse(v);

            databaze.PridejZaznam( jmeno, prijmeni, cislo, vek);
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");


        }

       public void VyhledejZaznamy() 
        {
            Console.WriteLine("Zadejte jméno: ");
            string jmeno = Console.ReadLine();

           

            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();

            

            List<Zaznam> zaznamy = databaze.NajdiZaznamy(jmeno,prijmeni);
            
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto záznamy: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
                Console.WriteLine();
                Console.WriteLine("Pokračujte libovolnou klávesou...");
            }
            else 
            {
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
                Console.WriteLine();
                Console.WriteLine("Pokračujte libovolnou klávesou...");
            }
               
        }

        public void VymazZaznamy() 
        {
            Console.WriteLine("Záznam, který zadáte bude vymazán");

            Console.WriteLine("Zadejte jméno: ");
            string jmeno = Console.ReadLine();

           
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();

            databaze.VymazZaznamy(jmeno, prijmeni);
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
        }

       

    }
}
