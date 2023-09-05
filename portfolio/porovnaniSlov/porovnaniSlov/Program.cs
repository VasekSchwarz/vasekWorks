internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte delší slovo: ");
        string delsi = Console.ReadLine();
        
        Console.WriteLine("Zdejte kratší slovo:");
        string kratsi = Console.ReadLine();
       
        Console.WriteLine("Slova se liší délkou o " + (delsi.Length - kratsi.Length) +" znaků.");
        Console.ReadKey();
    }
}