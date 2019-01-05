using System;
using System.Collections.Generic;
using System.Threading;

namespace LP2_P2
{
    public class Game
    {
        public int totalLives = 3;
        public float speed = 100.0f;

        public void GameManager()
        {
            Render render = new Render(this);
            RandomGenerator rand = new RandomGenerator();
            UserCar userCar = new UserCar();

            List<IGameObject> objects = new List<IGameObject>();
            while (true)
            {
                userCar.Update();
                speed += 0.5f;
                if (speed > 400)
                {
                    speed = 400;
                }

                bool hitted = false;
                {
                    int chance = rand.RandomObjectSpawnChance();

                    if (chance < 10)
                    {
                        Life life = new Life();
                        objects.Add(life);
                    }
                    else
                    {
                        EnemyCar enemyCar = new EnemyCar();
                        objects.Add(enemyCar);
                    }

                }
                
                List<IGameObject> temp = new List<IGameObject>();
                for (int i = 0; i < objects.Count; i++)
                {
                    if (objects[i] is EnemyCar)
                    {
                        EnemyCar oldCar = (EnemyCar)objects[i];

                        EnemyCar tempC = new EnemyCar
                        {
                            posX = oldCar.posX,
                            posY = oldCar.posY + 1,
                            visuals = oldCar.visuals,
                            color = oldCar.color
                        };

                        if (tempC.posY == userCar.posY && tempC.posX == userCar.posX)
                        {
                            totalLives--;
                            hitted = true;
                            speed += 20;
                        }
                        if (tempC.posY < 20)
                        {
                            temp.Add(tempC);
                        }
                    }
                }
                for (int i = 0; i < objects.Count; i++)
                {
                    if (objects[i] is Life)
                    {
                        Life oldLife = (Life)objects[i];

                        Life tempL = new Life
                        {
                            posX = oldLife.posX,
                            posY = oldLife.posY + 1,
                            visuals = oldLife.visuals,
                            color = oldLife.color
                        };

                        if (tempL.posY == userCar.posY && tempL.posX == userCar.posX)
                        {
                            totalLives++;
                        }

                        if (tempL.posY < 20)
                        {
                            temp.Add(tempL);
                        }
                    }
                }
                objects = temp;
                Console.Clear();

                if (hitted)
                {
                    objects.Clear();
                    render.PrintOnPosition(userCar.posX, userCar.posY, 'X', ConsoleColor.Red);
                }
                else
                {
                    userCar.Update();
                }
                foreach (IGameObject car in objects)
                {
                    car.Update();
                }

                if (totalLives <= 0)
                {
                    render.GameOver();
                }
                render.PrintBoarders();
                render.PrintLives();
                
            Thread.Sleep((int)(500 - speed));
            }
        }
    }
}



