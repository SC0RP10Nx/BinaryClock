
using BinaerUhr;

class Program
{
    static void Main()
    {
        Console.OutputEncoding= System.Text.Encoding.UTF8;
        Uhr digitalUhr = new Uhr();
        Anzeige anzeige = new Anzeige();

        digitalUhr.ZeitGeaendert += anzeige.ZeitAktualisieren;
        Console.CursorVisible = false;
        Console.Clear();
        digitalUhr.Start();

        while (Console.ReadKey().Key != ConsoleKey.Escape);
        digitalUhr.Stop();

    }
}