internal class Program
{
    private static void Main(string[] args)
    {
        //Exception

        try
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 / num2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally 
        {
            
        }

        
        Console.Read();
    }
}