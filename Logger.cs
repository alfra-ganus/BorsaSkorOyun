namespace Odev1;

public class Logger
{
    private static string dosya = "log.txt";

    public static void Yaz(string msj)
    {
        File.AppendAllText(dosya,$"{msj}\n");
    }
}