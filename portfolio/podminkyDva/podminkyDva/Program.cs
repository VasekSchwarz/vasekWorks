internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte číslo v rozmezí 10 - 20 nebo 30 - 40:");
        int a = int.Parse(Console.ReadLine());

        if ((a >= 10) && (a <= 20) || (a>=30) && (a<=40))
        {
            Console.WriteLine("Zadali jste správné číslo.");
        }
        else 
        {
            Console.WriteLine("Zadali jste číslo mimo rozmezí!");
        }
        Console.ReadKey();
    }
}