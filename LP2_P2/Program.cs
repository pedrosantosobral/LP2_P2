using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading;

namespace LP2_P2
{
    class Program
    {

        static void Main()
        {
            Game g = new Game();
            Render r = new Render(g);
            r.MainMenu();
            Console.ReadKey();
            g.GameManager();
        }
    }

}
