using staticClassattributes;

internal class Program
{
    private static void Main(string[] args)
    {
        Song holiday = new Song("Holiday", "Green Day", 200);
        Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

        Console.WriteLine(holiday.title);
        Console.WriteLine(kashmir.getSongCount());
        Console.WriteLine(Song.songCount);

        Console.ReadKey();
    }
}