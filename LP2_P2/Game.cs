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
            
            Thread.Sleep((int)(600 - speed));
            }
        }
    }
}



