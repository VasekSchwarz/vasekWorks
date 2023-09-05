internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zadejte své jméno: ");
        string jmeno = Console.ReadLine();
        Console.WriteLine("Zadejte své přijmení: ");
        string prijmeni = Console.ReadLine();
        Console.WriteLine("Zadejte svůj věk: ");
        string vek = Console.ReadLine();
        int a = int.Parse(vek);
        Console.WriteLine(jmeno.ToUpper() + " " + prijmeni.ToUpper());
        Console.WriteLine("Za rok ti bude " + (a + 1) + " let.");
    }
}