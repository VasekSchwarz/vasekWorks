internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadej číslo k umocnění:");
        double a =double.Parse(Console.ReadLine());
        double umocni = a * a;
        Console.WriteLine("Výsledek: " + umocni);
        Console.ReadKey();

    }
}