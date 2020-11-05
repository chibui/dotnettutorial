using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProperties
{
    class Player
    {
        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }

        public bool IsAlive
        {
            get { return health > 0; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine("Is player alive: " + player.IsAlive);
            }
        }
    }
}
