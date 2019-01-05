using System;
using System.Threading;

namespace LP2_P2
{
    /// <summary>
    /// User car.
    /// </summary>
    public class UserCar : IGameObject
    {
        /// <summary>
        /// The user car position x.
        /// </summary>
        public int posX;
        /// <summary>
        /// The user car position y.
        /// </summary>
        public int posY;
        /// <summary>
        /// The user car visuals.
        /// </summary>
        public char visuals;
        /// <summary>
        /// The user car color.
        /// </summary>
        public ConsoleColor color;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:LP2_P2.UserCar"/> class.
        /// </summary>
        public UserCar()
        {
            posX = 2;
            posY = 20 -1;
            visuals = '#';
            color = ConsoleColor.Blue;
        }

        /// <summary>
        /// User car position update method,
        /// </summary>
        public void Update()
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(visuals);
            UserInput();
        }

        /// <summary>
        ///  Handles the user input to move the car
        /// </summary>
        public void UserInput()
        {
            while (Console.KeyAvailable)
            {
                /// Pressed key variable.
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                /// Move car to the left
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    /// Keep the car inside the game map
                    if (posX - 1 >= 0)
                    {
                        posX = posX - 1;
                    }
                }
                /// Move car to the right
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    /// Keep the car inside the game map
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
