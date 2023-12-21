internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(GetPower(4,3));


        Console.ReadKey();
    }

    static int GetPower( int baseNum, int powNum) 
    {
        int result = 1;

        for (int i = 0; i < powNum; i++) 
        {
            result = result * baseNum;
        }

        return result;
    }
}