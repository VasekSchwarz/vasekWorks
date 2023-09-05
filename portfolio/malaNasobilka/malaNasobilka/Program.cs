internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Malá násobilka");

        for (int i = 1; i <= 10; i++) 
        {
            for (int j = 1;j <= 10; j++)
                Console.Write("{0} ", i * j);
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}