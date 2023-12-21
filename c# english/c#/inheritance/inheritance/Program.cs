using inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Chef chef = new Chef();
        chef.MakeSpecialDish();
        ItalianChef italienchef = new ItalianChef();
        italienchef.MakeSpecialDish();


        Console.ReadKey();
    }
}