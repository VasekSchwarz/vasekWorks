using gettersSetters;

internal class Program
{
    private static void Main(string[] args)
    {
        Movie avengers = new Movie("The Avangers", "Joss Whedon", "PG-13");
        Movie shrek = new Movie("Sherk", "Adam Adamson","PG-13");

        shrek.Rating = "R";

        Console.WriteLine(avengers.Rating);
        Console.ReadKey();
    }
}