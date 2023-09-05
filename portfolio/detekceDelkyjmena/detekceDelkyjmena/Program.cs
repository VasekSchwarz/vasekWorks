internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte své jméno:");
        string jmeno = Console.ReadLine();
        if ((jmeno.Length >= 3) && (jmeno.Length <= 10))
        {
            Console.WriteLine("Vaše jméno je normální");
        }
        else 
        {
            Console.WriteLine("Máš moc krátké nebo moc dlouhé jméno!");
        }
    }
}