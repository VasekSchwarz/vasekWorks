using classesObjects;

internal class Program
{
    private static void Main(string[] args)
    {
        //Object is a intance of class
        Book book1 = new Book("Harry Potter", "J.K.Rowling", 400);
        

        Book book2 = new Book("Lord OF the Rings", "Lord OF the Rings", 700);

        book2.autor = "The Hobbit"; //update

        Console.WriteLine(book2.autor);


        Console.ReadKey();
    }
}