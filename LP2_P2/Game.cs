using System;
using System.Collections.Generic;
using System.Threading;

namespace LP2_P2
{
    public class Game
    {
        public int livesCount = 5;
        public double speed = 100.0;
        public double acceleration = 0.5;

        public void GameManager()
        {
            Render render = new Render(this);
            bool startgame = true;
            Random rand = new Random();
            UserCar userCar = new UserCar();

            List<IGameObject> objects = new List<IGameObject>();
            while (startgame == true)
            {
                userCar.Update();
                speed += acceleration;
                if (speed > 400)
                {
                    speed = 400;
                }

                bool hitted = false;
                {
                    int chance = rand.Next(0, 100);

                    if (chance < 10)
                    {
                        Life life = new Life
                        {
                            x = rand.Next(0, 5)
                        };
                        objects.Add(life);
                    }
                    else
                    {
                        EnemyCar enemyCar = new EnemyCar
                        {
                            x = rand.Next(0, 5)
                        };
                        objects.Add(enemyCar);
                    }

                }
                
                List<IGameObject> newList = new List<IGameObject>();
                for (int i = 0; i < objects.Count; i++)
                {
                    if (objects[i] is EnemyCar)
                    {
                        EnemyCar oldCar = (EnemyCar)objects[i];

                        EnemyCar tempC = new EnemyCar
                        {
                            x = oldCar.x,
                            y = oldCar.y + 1,
                            c = oldCar.c,
                            color = oldCar.color
                        };

                        if (tempC.y == userCar.y && tempC.x == userCar.x)
                        {
                            livesCount--;
                            hitted = true;
                            speed += 50;
                        }
                        if (tempC.y < 20)
                        {
                            newList.Add(tempC);
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
                            x = oldLife.x,
                            y = oldLife.y + 1,
                            c = oldLife.c,
                            color = oldLife.color
                        };

                        if (tempL.y == userCar.y && tempL.x == userCar.x)
                        {
                            livesCount++;
                        }

                        if (tempL.y < 20)
                        {
                            newList.Add(tempL);
                        }
                    }
                }
                objects = newList;
                Console.Clear();
                if (hitted)
                 {
                     objects.Clear();
                     render.PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
                 }
                 else
                 {
                    render.PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
                 }
                 foreach (Object car in objects)
                 {
                     render.PrintOnPosition(car.x, car.y, car.c, car.color);
                 }
                 render.PrintHUD();
                
            Thread.Sleep((int)(600 - speed));
            }
        }
    }
}



