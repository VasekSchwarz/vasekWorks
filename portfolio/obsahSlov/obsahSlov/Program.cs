internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte retězec:");
        string s = Console.ReadLine();
        s = s.ToLower();
        Console.WriteLine(s.Contains("itnetwork"));
    }
}