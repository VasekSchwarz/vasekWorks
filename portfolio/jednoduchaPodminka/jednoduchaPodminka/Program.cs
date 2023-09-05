internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte nějaké číslo, ze kterého mohu spočítat odmocninu:");
        int a = int.Parse(Console.ReadLine());

        if (a > 0) 
        {
            Console.WriteLine("Zadali jste číslo, které je větší než 0!");
            double d = Math.Sqrt(a);
            Console.WriteLine("Odmocnina z čísla " + a + " je " + d );
        }
        else
            Console.WriteLine("Odmocnina ze záporného čísla neexistuje!");

        Console.WriteLine("Děkuji za zdání");
        Console.ReadKey();

    }
}