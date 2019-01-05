using System;
using System.Collections;
namespace LP2_P2
{
    /// <summary>
    /// Life class.
    /// </summary>
    public class Life : IGameObject
    {
        /// <summary>
        /// Random generator class instance
        /// </summary>
        RandomGenerator rand = new RandomGenerator();

        /// <summary>
        /// The life position x.
        /// </summary>
        public int posX;

        /// <summary>
        /// The life position y.
        /// </summary>
        public int posY;

        /// <summary>
        /// The life visuals.
        /// </summary>
        public char visuals;

        /// <summary>
        /// The life color.
        /// </summary>
        public ConsoleColor color;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:LP2_P2.Life"/> class.
        /// </summary>
        public Life()
        {
            posX = rand.RandomObjectXPosition();
            posY = 0;
            visuals = '-';
            color = ConsoleColor.Green;
        }

        /// <summary>
        /// Object position update method.
        /// </summary>
        public void Update()
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(visuals);
        }
    }
}
