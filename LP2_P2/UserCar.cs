using System;
using System.Collections;
namespace LP2_P2
{
    public class UserCar : IGameObject
    {
        public int x;
        public int y;
        public char c;
        public ConsoleColor color;

        public UserCar()
        {
            x = 2;
            y = 20 -1;
            c = 'C';
            color = ConsoleColor.Blue;
        }

        public void Update()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
            UserInput();
        }

        public void UserInput()
        {
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (x - 1 >= 0)
                    {
                        x = x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (x + 1 < 5)
                    {
                        x = x + 1;
                    }
                }
            }
        }
    }
}
