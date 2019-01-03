using System;
namespace LP2_P2
{
    public class RandomGenerator
    {
        public RandomGenerator()
        {
            RandomObjectXPosition();
            RandomObjectSpawnChance();
        }

        Random rand = new Random();
      
        public int RandomObjectXPosition()
        {
            int randomNumber;
            randomNumber = rand.Next(0, 5); 
            return randomNumber;
        }

        public int RandomObjectSpawnChance()
        {
            int randomNumber;
            randomNumber = rand.Next(0, 100);
            return randomNumber;
        }
    }
}
