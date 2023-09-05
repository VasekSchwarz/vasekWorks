internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte smajlíka: ");
        string smajlik = Console.ReadLine();

        smajlik = smajlik.ToUpper();

        smajlik = smajlik.Trim();

        smajlik = smajlik.Replace("-", "");

        Console.Write("Tvůj smajlík je ");

        switch (smajlik) 
        {
            case ":)":
                Console.WriteLine("veselý");
                break;
            case ":(":
                Console.WriteLine("smutný");
                break;
            case ":*":
                Console.WriteLine("zamilováný");
                break;
            case ":P":
                Console.WriteLine("s vyplazeným jazykem");
                break;
            default:
                Console.WriteLine(" neznámý");
                break;
        }
        Console.ReadKey();
                
              
    }
}