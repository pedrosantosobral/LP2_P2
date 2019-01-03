using System;
namespace LP2_P2
{
    public class Render
    {
        public Game g;

        public Render(Game g)
        {
            this.g = g;
        }

        public void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Black)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        public void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Black)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        public void PrintHUD()
        {
            PrintLives();
            PrintSpeed();
        }

        public void PrintLives()
        {
            PrintStringOnPosition(8, 4, "Lives: " + g.livesCount, ConsoleColor.White);
        }

        public void PrintSpeed()
        {
            PrintStringOnPosition(8, 5, "Speed: " + g.speed, ConsoleColor.White);
        }

        public void GameOver()
        {
            PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
            PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
            Console.ReadLine();
            Environment.Exit(0);
        }

    }
}

