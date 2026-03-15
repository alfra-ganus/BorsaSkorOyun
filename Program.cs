using Odev1;

class Program
{
   public static int Score=0;
   public static int Sayac = 0;
   public static bool Oyundurum=true;
   
   static void Main()
   {
      File.WriteAllText("log.txt", "--- YENİ OTURUM ---\n");
      
      Interface a = new Interface();
      Player p = new Player();
      List<Doviz> dovizler = new List<Doviz>();
      Timer zaman = new Timer(obj => Dovizh(a,p, dovizler) ,null,0,800);
      Console.CursorVisible = false;
      
      //hazirlik
      a.Kenarlik();
      a.Baslangic();
      p.Img();
      
      Logger.Yaz("OYUN BAŞLADI");
      //oyun dongusu
      while (Oyundurum)
      { 
         p.Move();
         Ciz(a,p,dovizler);
         Collision(p,dovizler);
         Thread.Sleep(250);
      }
      zaman.Dispose();
      a.Bitis(Score); //bitis ekrani
      Console.ReadKey();
   }
   
   static void Ciz(Interface a, Player p, List<Doviz> dovizler)
   {
      //her elemanin x,y si alınıp burda cizilecek
      Console.Clear();
      a.Kenarlik();
      p.Img();
      for (int i = 0; i < dovizler.Count; i++)
      {
         dovizler[i].Img();
      }
   }

   static void Collision(Player p, List<Doviz> dovizler)
   {
      //carpisma kontrol, carpisani sil, score++

      for (int i = 0; i < dovizler.Count; i++)
      {
         if (dovizler[i].Y >= 18)
         {
            if (dovizler[i].X+3 >= p.X && dovizler[i].X<= p.X+5) 
            //karakterin başı ile sonu arasına itemin herhangi bir noktasının teması için kontrol
            {
               //collision log
               Logger.Yaz("COLLISION - doviz/player, SCORE +5");
               Score += 5; //score log
               Logger.Yaz($"SCORE:{Score}");
               dovizler.RemoveAt(i);
               i--;
            }
            
            else if (dovizler[i].Y == 22)
            {
               Oyundurum = false;
               //oyun biter log
               Logger.Yaz($"GAME OVER - SCORE: {Score}");
            }
         }
         
      }
   }

   static void Dovizh(Interface a,Player p, List<Doviz> dovizler)
   {
      if (Oyundurum)
      {
         Sayac++;
         for (int i = 0; i < dovizler.Count; i++)
         {
         
            dovizler[i].Y+=1; //nesne düsüs mekanigi
         }

         if (Sayac == 2)
         {
            dovizler.Add(new Doviz());
            Sayac = 0;
         }
      
         Collision(p,dovizler);
         Ciz(a,p, dovizler);
      }
      
   }
   
}
   
   






  