using System;
namespace LP2_P2
{
    public class EnemyCar : IGameObject
    {
        RandomGenerator rand = new RandomGenerator();

        public int posX;
        public int posY;
        public char visuals;
        public ConsoleColor color;

        public EnemyCar()
        {
            posX = rand.RandomObjectXPosition();
            posY = 0;
            visuals = 'O';
            color = ConsoleColor.Red;
        }

        public void Update()
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(visuals);
        }
    }        
}
