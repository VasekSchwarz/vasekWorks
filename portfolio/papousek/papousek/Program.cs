internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dobrý den, jsem papousek Ara a rád vše opakuji");
        Console.WriteLine("Zadejte nějaké slovo k zopakování:");
        string vstup = Console.ReadLine();
        string vystup = vstup + ", " + vstup + "!";
        Console.WriteLine(vystup);
        Console.ReadKey();
    }
}