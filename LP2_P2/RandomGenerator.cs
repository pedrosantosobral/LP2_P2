using System;
namespace LP2_P2
{
    /// <summary>
    /// Random generator class.
    /// </summary>
    public class RandomGenerator
    {
        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="T:LP2_P2.RandomGenerator"/> class.
        /// </summary>
        public RandomGenerator()
        {
            RandomObjectXPosition();
            RandomObjectSpawnChance();
        }
        /// <summary>
        /// Random number variable;
        /// </summary>
        Random rand = new Random();

        /// <summary>
        /// Randoms the object X Position.
        /// </summary>
        /// <returns>The object X Position.</returns>
        public int RandomObjectXPosition()
        {
            int randomNumber;
            randomNumber = rand.Next(0, 7); 
            return randomNumber;
        }

        /// <summary>
        /// Randoms the object spawn chance.
        /// </summary>
        /// <returns>The object spawn chance.</returns>
        public int RandomObjectSpawnChance()
        {
            int randomNumber;
            randomNumber = rand.Next(0, 100);
            return randomNumber;
        }
    }
}
