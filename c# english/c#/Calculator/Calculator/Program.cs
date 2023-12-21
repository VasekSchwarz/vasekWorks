internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a operator: ");
        string op = Console.ReadLine();

        Console.Write("Enter a number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (op == "+")
        {
            Console.Write(num1 + num2);
        }else if (op == "-")
        {
            Console.Write(num1 - num2);
        }
        else if (op == "/")
        {
            Console.Write(num1 / num2);
        }
        else if (op == "*")
        {
            Console.Write(num1 * num2);
        }
        else
        {
            Console.Write("Invalide operator");
        } 
        


        Console.ReadLine();
    }
}