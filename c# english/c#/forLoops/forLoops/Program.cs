internal class Program
{
    private static void Main(string[] args)
    {
        int[] luckyNumbers = { 4, 18, 15, 16, 23, 28, 42};
        
        for (int i = 0; i < luckyNumbers.Length; i++)
        {
            Console.WriteLine(luckyNumbers[i]);
            
        }
        Console.ReadKey();
    }
}