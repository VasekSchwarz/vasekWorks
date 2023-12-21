internal class Program
{
    private static void Main(string[] args)
    {
        //Methods
        SayHi("mike", 33);
        SayHi("jonh", 44);
        SayHi("luke", 58);

        Console.ReadLine();
    }

    static void SayHi(string name, int age)
    {
        Console.WriteLine("Hello " + name + " you are " + age);
    }
}