internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte číslo ke zdovnásobení");

        string a = Console.ReadLine();
        double b = double.Parse(a);
        b = b * 2;
        Console.WriteLine(b);
    }
}