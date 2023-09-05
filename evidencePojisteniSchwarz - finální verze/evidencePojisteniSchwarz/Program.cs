using evidencePojisteniSchwarz;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // instance evidence
        Pojistenci pojistenci = new Pojistenci();
        char volba = '0';
        // hlavní cyklus
        while (volba != '5')
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěnce");
            Console.WriteLine("3 - Vyhledat pojišteného");
            Console.WriteLine("4 - Vymazat pojištěného");
            Console.WriteLine("5 - Konec");
            volba = Console.ReadKey().KeyChar;
            Console.WriteLine();
            // reakce na volbu
            switch (volba)
            {
                case '1':
                    pojistenci.PridejZaznam();
                    break;
                case '2':
                    pojistenci.VypisSeznam();
                    break;
                case '3':
                    pojistenci.VyhledejZaznamy();
                    break;
                case '4':
                    pojistenci.VymazZaznamy();
                    break;
                case '5':
                    Console.WriteLine("Libovolnou klávesou ukončíte program...");
                    break;
                default:
                    Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}