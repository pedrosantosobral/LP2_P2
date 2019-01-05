using System;
using System.Collections;
namespace LP2_P2
{
    public class Life : IGameObject
    {
        RandomGenerator rand = new RandomGenerator();

        public int posX;
        public int posY;
        public char visuals;
        public ConsoleColor color;

        public Life()
        {
            posX = rand.RandomObjectXPosition();
            posY = 0;
            visuals = '-';
            color = ConsoleColor.Green;
        }

        public void Update()
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = color;
            Console.Write(visuals);
        }
    }
}