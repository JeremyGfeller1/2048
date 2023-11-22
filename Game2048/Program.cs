using System;

namespace Game2048
{
    static class Programm
    {
        static void Main()
        {
            bool continueGame = true;

            while (continueGame)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                ConsoleKey key = keyInfo.Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Vous avez appuyé sur la flèche de gauche");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Vous avez appuyé sur la flèche de droite");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Vous avez appuyé sur la flèche du haut");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Vous avez appuyé sur la flèche du bas");
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("Fin du programme vous avez appuyé sur la touche C");
                        continueGame = false;
                        break;
                    default:
                        Console.WriteLine("Appuyez sur les touches directionnelles ou la touche C pour quitter le jeu.");
                        break;
                }
            }
        }
    }
}