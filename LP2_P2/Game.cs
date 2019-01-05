using System;
using System.Collections.Generic;
using System.Threading;

namespace LP2_P2
{   
    /// <summary>
    /// Game class where the main loop is.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The total lives variable.
        /// </summary>
        public int totalLives = 3;
        /// <summary>
        /// The speed variable.
        /// </summary>
        public float speed = 100.0f;

        /// <summary>
        /// Main game manager.
        /// </summary>
        public void GameManager()
        {
            /// Render instance.
            Render render = new Render(this);
            /// Random numbers generator instance.
            RandomGenerator rand = new RandomGenerator();
            /// User car instance;
            UserCar userCar = new UserCar();

            /// Main game objects list.
            List<IGameObject> objects = new List<IGameObject>();

            /// Gameloop
            while (true)
            {
                /// Updates the user car position.
                userCar.Update();
                /// Speed incrementer.
                speed += 0.5f;
                /// Speed limiter.
                if (speed > 400)
                {
                    speed = 400;
                }

                /// If the car was not hitted by another enemy object.
                bool hitted = false;
                {
                    /// Random spawn chance variable. 
                    int chance = rand.RandomObjectSpawnChance();

                    /// Object random spawn chance finder. 
                    if (chance < 10)
                    {
                        /// Creates a new life and adds it to the game objects list.
                        Life life = new Life();
                        objects.Add(life);
                    }
                    else
                    {   
                        /// Creates a new enemy car and adds it to the game objects list.
                        EnemyCar enemyCar = new EnemyCar();
                        objects.Add(enemyCar);
                    }

                }
                /// List to move the objects 
                List<IGameObject> temp = new List<IGameObject>();

                /// Go through all the game objects in the game objects list
                for (int i = 0; i < objects.Count; i++)
                {
                    /// If the object is a enemy car.
                    if (objects[i] is EnemyCar)
                    {
                        /// Create another enemy car with the first enemy car 
                        /// atributes
                        EnemyCar oldCar = (EnemyCar)objects[i];

                        /// Creates a temporary car and move it down
                        EnemyCar tempC = new EnemyCar
                        {
                            posX = oldCar.posX,
                            posY = oldCar.posY + 1,
                            visuals = oldCar.visuals,
                            color = oldCar.color
                        };
                        /// Detects enemy and user car colision
                        if (tempC.posY == userCar.posY && tempC.posX == userCar.posX)
                        {
                            /// Decrement the total lives by 1
                            totalLives--;
                            hitted = true;
                            speed += 20;
                        }
                        /// Add the objects to the temporary list if they are 
                        /// out of the "game map"
                        if (tempC.posY < 20)
                        {
                            temp.Add(tempC);
                        }
                    }
                    /// If the object is a life.
                    if (objects[i] is Life)
                    {
                        /// Create another life with the first life atributes
                        Life oldLife = (Life)objects[i];

                        /// Creates a temporary life and move it down
                        Life tempL = new Life
                        {
                            posX = oldLife.posX,
                            posY = oldLife.posY + 1,
                            visuals = oldLife.visuals,
                            color = oldLife.color
                        };
                        /// Detects life and user car colision
                        if (tempL.posY == userCar.posY && tempL.posX == userCar.posX)
                        {
                            /// Increments lives by 1
                            totalLives++;
                        }
                        /// Add the objects to the temporary list if they are 
                        /// out of the "game map"
                        if (tempL.posY < 20)
                        {
                            temp.Add(tempL);
                        }
                    }
                }
                /// Copy the temporary list to the original list
                objects = temp;
                Console.Clear();

                // If the user car hits a enemy car
                if (hitted)
                {
                    objects.Clear();
                    /// Print a car crash
                    render.PrintOnPosition(userCar.posX, userCar.posY, 'X', 
                                           ConsoleColor.Red);
                }
                else
                {
                    /// Update user car position after user inputs
                    userCar.Update();
                }
                /// Update all game objects positions after moviment.
                foreach (IGameObject o in objects)
                {
                    o.Update();
                }
                /// If the player have no lifes left, print the game over message
                if (totalLives <= 0)
                {
                    render.GameOver();
                }
                /// Print borders and user lives
                render.PrintBoarders();
                render.PrintLives();
           
            /// Controle the game speed
            Thread.Sleep((int)(500 - speed));
            }
        }
    }
}



