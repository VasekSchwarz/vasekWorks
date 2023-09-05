internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vítejte v kalkulačce");
        Console.WriteLine("Zadejte 1.číslo: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadejte 2. číslo: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Zvolte si operaci");
        Console.WriteLine("1 - sčítání");
        Console.WriteLine("2 - odítání");
        Console.WriteLine("3 - násobení");
        Console.WriteLine("4 - dělení");
        int volba = int.Parse(Console.ReadLine());
        double vysledek = 0;
        switch (volba) 
        {
            case 1:
                vysledek = a + b;
                break;
            case 2:
                vysledek = a - b;
                break;
            case 3:
                vysledek = a * b;
                break;
            case 4:
                vysledek = a / b;
                break;

        }
        if((volba > 0) && (volba < 5)) 
        {
            Console.WriteLine("Výsledek: {0}", vysledek);
        }
        else 
        {
            Console.WriteLine("Neplatná volba");
        }
        Console.WriteLine("Děkuji za použití kalkulačky, aplikaci ukončíte libovolnou klávesou");
        Console.ReadKey();
    }
}