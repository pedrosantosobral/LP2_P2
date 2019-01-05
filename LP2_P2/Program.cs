using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading;

namespace LP2_P2
{
    /// <summary>
    /// Program class (initializes the game).
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts 
        /// and ends.
        /// </summary>
        static void Main()
        {
            /// Game instance.
            Game g = new Game();

            /// Render instance.
            Render r = new Render(g);

            /// Calls the MainMenu from Render class.
            r.MainMenu();

            /// Waits for the user to click on a key to pass to continue.
            Console.ReadKey();

            /// calls the GameManager from the Game class
            g.GameManager();
        }
    }

}
