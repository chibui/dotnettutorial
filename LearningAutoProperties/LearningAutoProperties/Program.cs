using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProperties
{
    class Player
    {
        public void Hit()
        {
            Random r = new Random();
            Health -= r.Next(5, 50);
        }

        public int Health { get; private set; } = 100;

        public bool IsAlive
        {
            get { return Health > 0; }
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
