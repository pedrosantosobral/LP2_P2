using System;
namespace LP2_P2
{
    public class EnemyCar : IGameObject
    {
        RandomGenerator rand = new RandomGenerator();

        public int x;
        public int y;
        public char c;
        public ConsoleColor color;

        public EnemyCar()
        {
            x = rand.RandomObjectXPosition();
            y = 0;
            c = '#';
            color = ConsoleColor.Green;
        }

        public void Update()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
    }        
}
