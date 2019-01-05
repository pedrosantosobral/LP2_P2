using System;
namespace LP2_P2
{
    /// <summary>
    /// Enemy car class
    /// </summary>
    public class EnemyCar : IGameObject
    {
        /// <summary>
        /// Random generator class instance
        /// </summary>
        RandomGenerator rand = new RandomGenerator();

        /// <summary>
        /// The enemy car position x.
        /// </summary>
        public int posX;
        /// <summary>
        /// The enemy car position y.
        /// </summary>
        public int posY;
        /// <summary>
        /// The enemy car visuals.
        /// </summary>
        public char visuals;
        /// <summary>
        /// The enemy car color.
        /// </summary>
        public ConsoleColor color;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:LP2_P2.EnemyCar"/> class.
        /// </summary>
        public EnemyCar()
        {
            /// Give x a random position
            posX = rand.RandomObjectXPosition();
            /// Set y position
            posY = 0;
            /// Set object visual
            visuals = 'O';
            /// Set object color
            color = ConsoleColor.Red;
        }
        /// <summary>
        /// Object position update method 
        /// </summary>
        public void Update()
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(visuals);
        }
    }        
}
