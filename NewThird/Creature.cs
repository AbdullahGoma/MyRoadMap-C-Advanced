using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewThird
{
    internal abstract class Creature
    {
        public int Age;
        protected int Weight;
        private int Height;

        public Creature()
        {
            Weight = 10;
            Height = 20;
        }

        public Creature(int weight, int height)
        {
            Weight = weight;
            Height = height;
        }

        public abstract void Move();

        //public virtual void Move()
        //{
        //    Console.WriteLine("Creature is moving...");
        //}

        public void Eat()
        {
            Console.WriteLine("Creature is eating...");
        }

        public virtual void Test()
        {
            Console.WriteLine();
        }


    }
}
