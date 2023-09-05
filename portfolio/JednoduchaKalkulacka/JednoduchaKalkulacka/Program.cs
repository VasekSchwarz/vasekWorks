internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vítejte v kalkulačce");
        Console.WriteLine("Zadejte 1. číslo: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadejte 2.číslo"); 
        double b = double.Parse(Console.ReadLine());
        double soucet = a + b;
        double rozdil = a - b;
        double soucin = a * b;
        double podil = a / b;
        Console.WriteLine("Součet: " + soucet);
        Console.WriteLine("Rozdíl: " + rozdil);
        Console.WriteLine("Součin: " + soucin);
        Console.WriteLine("Podíl: " + podil);
        Console.WriteLine("Děkujem za použítí naší kalkulačky !!!");
        Console.ReadKey();
    }
}