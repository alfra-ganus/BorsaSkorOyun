using Odev1;

public class Player
{
    public  int X { get; set; } = 2;
    public  int Y { get; set; } = 22;
    
    // "*___*\n|0 0|\n|   |\n / /";

    public void Img()
    {
        Console.SetCursorPosition(X, Y-3);
        Console.Write("*___*");
        Console.SetCursorPosition(X,Y-2);
        Console.Write("|0 0|");
        Console.SetCursorPosition(X,Y-1);
        Console.Write("|   |");
        Console.SetCursorPosition(X,Y);
        Console.Write(" / /");
        Console.SetCursorPosition(X,Y-3);
    }

    
    public void Move()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
        
        

            if (key == ConsoleKey.RightArrow)
            {
                Logger.Yaz("INPUT - key= RightArrow");
                Console.SetCursorPosition(X, Y-3);
                if (Console.GetCursorPosition()!=(74,19))
                {
                    X += 6;
                    Logger.Yaz($"PlayerMove - X:{X} Y:{Y}");
                }
                else
                {
                    X = 2;
                    Logger.Yaz($"PlayerMove - X:{X} Y:{Y}");
                }
            }
        
            else if (key == ConsoleKey.LeftArrow)
            {
                Logger.Yaz("INPUT - key= LeftArrow");
                Console.SetCursorPosition(X, Y-3);
                if (Console.GetCursorPosition() != (2, 19))
                {
                    X -= 6;
                    Logger.Yaz($"PlayerMove - X:{X} Y:{Y}");
                }
                else
                {
                    X = 74;
                    Logger.Yaz($"PlayerMove - X:{X} Y:{Y}");
                }
            }
        }
        
    }
}

public class Doviz
{
    public int X { get; set;} //random
    public int Y { get; set; } = 1;

    public Doviz() //constructer metot
    {
        Random rnd = new Random();
        X= rnd.Next(2,75);
        Logger.Yaz($"ItemSpawn - X:{X} Y:{Y}");
        
    }
    
    public void Img()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("$$$");
        Console.SetCursorPosition(X,Y);
    }
    
}