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

    }
}

