internal class Program
{
    private static void Main(string[] args)
    {
       Console.WriteLine(cube(5));

       Console.ReadLine();
    }

    static int cube(int num)
    {
        int result = num * num * num;
        return result;
    }
}