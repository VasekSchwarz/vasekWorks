internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ahoj, jak se jmenuješ???");
        string jmeno = Console.ReadLine();
        Console.WriteLine("Jaký jsi?");
        string vlastnost = Console.ReadLine();
        Console.WriteLine(jmeno + " je " + vlastnost);
        Console.ReadKey();
    }
}