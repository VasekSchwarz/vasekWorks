internal class Program
{
    private static void Main(string[] args)
    {
        string s = "Krkonosohroch";
        Console.WriteLine(s.StartsWith("Krk"));
        Console.WriteLine(s.EndsWith("okr"));
        Console.WriteLine(s.Contains("nos"));
        

        Console.WriteLine();

        string konfig = "Fullscreen shaDows autosave";
        konfig = konfig.ToLower();
        Console.WriteLine("Poběží hra ve fullscreen?");
        Console.WriteLine(konfig.Contains("fullscreen"));
        Console.WriteLine("Budou zapnuté stíny?");
        Console.WriteLine(konfig.Contains("shadows"));
        Console.WriteLine("Přeje si hráč automaticky ukládat?");
        Console.WriteLine(konfig.Contains("autosave"));
        

        Console.WriteLine();

        Console.WriteLine("Zadejte číslo:");
        string d = Console.ReadLine();
        Console.WriteLine("Zadal jste text: " + d);
        Console.WriteLine("Text po funkci trim: " + d.Trim());
        int a = int.Parse(d);
        Console.WriteLine("Převedl jsem zadaný text Parsováním, zadal jste:" + a);

        Console.WriteLine();

        string g = "Java je nejlepší";
        g = g.Replace("Java", "C#");
        Console.WriteLine(g);

        Console.WriteLine();

        Console.WriteLine("Zadejte vaše jméno:");
        string jmeno = Console.ReadLine();
        Console.WriteLine("Délka vašeho jména je: {0}", jmeno.Length);
        Console.ReadKey();
    }
}