namespace Odev1;



public class Interface
{

    public void Kenarlik()
    {
        int width = 76;
        int height = 22;

        //kenarlik cizim bas
        Console.SetCursorPosition(2, 1);
        for (int i = 1; i < width + 1; i++)
        {
            Console.Write("-");
        }

        for (int i = 1; i < height + 1; i++)
        {
            Console.SetCursorPosition(78, i + 1);
            Console.WriteLine("|");
        }

        Console.SetCursorPosition(2, height + 1);
        for (int i = 1; i < width + 1; i++)
        {
            Console.Write("-");
        }

        for (int i = 1; i < height + 1; i++)
        {
            Console.SetCursorPosition(1, i);
            Console.WriteLine("|");
        }
        //kenarlik cizim bitis

    }

    public void Baslangic()
    {
        Console.SetCursorPosition(25, 10);
        Console.WriteLine("BORSA OYUNUNA HOŞGELDİNİZ!");
        Console.SetCursorPosition(12, 11);
        Console.WriteLine("Batmamak icin düsen dolarlari yakalamaniz gerekmektedir.");
        Console.SetCursorPosition(20, 14);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Baslamak icin lutfen bir tusa basiniz...");
        Console.ResetColor();
        Console.SetCursorPosition(2, 22);
        Console.ReadKey();
    }

    public void Bitis(int score)
    {
        Console.Clear();
        Console.SetCursorPosition(31, 10);
        Console.WriteLine("GAME OVER!");
        Console.SetCursorPosition(31, 14);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("SCORE: " + score);
        Console.ResetColor();
        Console.SetCursorPosition(2, 22);
    }

}    
namespace Odev1;



public class Interface
{

    public void Kenarlik()
    {
        int width = 76;
        int height = 22;

        //kenarlik cizim bas
        Console.SetCursorPosition(2, 1);
        for (int i = 1; i < width + 1; i++)
        {
            Console.Write("-");
        }

        for (int i = 1; i < height + 1; i++)
        {
            Console.SetCursorPosition(78, i + 1);
            Console.WriteLine("|");
        }

        Console.SetCursorPosition(2, height + 1);
        for (int i = 1; i < width + 1; i++)
        {
            Console.Write("-");
        }

        for (int i = 1; i < height + 1; i++)
        {
            Console.SetCursorPosition(1, i);
            Console.WriteLine("|");
        }
        //kenarlik cizim bitis

    }

    public void Baslangic()
    {
        Console.SetCursorPosition(25, 10);
        Console.WriteLine("BORSA OYUNUNA HOŞGELDİNİZ!");
        Console.SetCursorPosition(12, 11);
        Console.WriteLine("Batmamak icin düsen dövizleri yakalamaniz gerekmektedir.");
        Console.SetCursorPosition(20, 14);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Baslamak icin lutfen bir tusa basiniz...");
        Console.ResetColor();
        Console.SetCursorPosition(2, 22);
    }

    public void Bitis(int score)
    {
        Console.Clear();
        Console.SetCursorPosition(31, 10);
        Console.WriteLine("GAME OVER!");
        Console.SetCursorPosition(31, 14);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("SCORE: " + score);
        Console.ResetColor();
        Console.SetCursorPosition(2, 22);
    }

}    
