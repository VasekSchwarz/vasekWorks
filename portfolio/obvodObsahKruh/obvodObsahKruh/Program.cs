internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zdejte poloměr kruhu (cm)");
        double polomer = double.Parse(Console.ReadLine());
        double pi = 3.1415;
        double obvod = 2 * pi * polomer;
        double obsah = pi * (polomer * polomer);
        Console.WriteLine("Obvod zadaného kruhu je: " +  obvod + " " + "cm");
        Console.WriteLine("Obsah zadaného kruhu je: " +  obsah +" " + "cm2");
    }
}