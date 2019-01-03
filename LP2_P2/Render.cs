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
        
        public void MainMenu()
        {
            PrintStringOnPosition(1, 1, "Welcome to Lisbon trafic", ConsoleColor.White);
            PrintStringOnPosition(1, 2, "Your goal is to go the much further possible while avoiding the traffic.", ConsoleColor.White);
            PrintStringOnPosition(1, 3, "", ConsoleColor.White);
            PrintStringOnPosition(1, 4, "-> Use the right and left arrow to move your car <-", ConsoleColor.White);
            PrintStringOnPosition(1, 5, "C -> Your car", ConsoleColor.Blue);
            PrintStringOnPosition(1, 6, "# -> Enemy car", ConsoleColor.Green);
            PrintStringOnPosition(1, 7, "- -> Add life", ConsoleColor.Green);
            PrintStringOnPosition(1, 8, "", ConsoleColor.White);
            PrintStringOnPosition(1, 9, "[Press any key to continue...]", ConsoleColor.White);
        }

    }
}

