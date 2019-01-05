using System;
using System.Collections;
using System.Threading;
namespace LP2_P2
{
    public class UserCar : IGameObject
    {
        public int posX;
        public int posY;
        public char visuals;
        public ConsoleColor color;

        public UserCar()
        {
            posX = 2;
            posY = 20 -1;
            visuals = '#';
            color = ConsoleColor.Blue;
        }

        public void Update()
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(visuals);
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
                    if (posX - 1 >= 0)
                    {
                        posX = posX - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (posX + 1 < 7)
                    {
                        posX = posX + 1;
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}
