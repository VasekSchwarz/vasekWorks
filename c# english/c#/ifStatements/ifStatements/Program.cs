internal class Program
{
    private static void Main(string[] args)
    {
        bool isMale = false;
        bool isTall = true;

        if (isMale && isTall)
        {
            Console.WriteLine("You are a tall Male");
        }else if (isMale && !isTall)
        {
            Console.WriteLine("You are a short Male");
        }else if (!isMale && isTall)
        {
            Console.WriteLine("You are not a Male but you are tall");
        }
        else
        {
            Console.WriteLine("You are not Male and not tall");
        }

        
    }
}