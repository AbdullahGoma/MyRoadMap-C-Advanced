using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewThird
{
    internal class Human : Creature
    {
        // Best Practice is do all members are private and do get and set to it in all cases
        //private int id;

        //Auto implemented property
        //public int Id { get { return id; } set { id = value; } }
        public int Id { get; set; }
        private string name;
        //Auto implemented property
        public string Name { get { return name; } set { name = value; } }

        public Human() : base()
        {
            Id = 0;
            name = "";
            base.Weight = 20;
        }

        // If you want to make object from child you must do object to parent
        public Human(int id, string name, int weight) : base(weight, 30)
        {
            Id = id;
            this.name = name;
            Weight = weight;
        } 

        public override void Move()
        {
            Console.WriteLine("Human is Moving...");
            //base.Move();
        }

        public void Think()
        {
            Move();
            //base.Move();
            Console.WriteLine("Human is thinking...");
        }

        // new means this function does not releated with function Test in Creature
        public new void Test()
        {
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"ID = {Id} \t Name = {Name}";
        }

        public override bool Equals(object? obj)
        {
            //Human human = (Human) obj; // Explicit Casting (Throw Exception)
            //Human human = obj as Human; // Will give human Null
            //if(human == null) return false; 
            //return this.Id == human.Id;
            //Human human;
            if(obj is Human human)
            {
                human = (Human)obj; 
                return this.Id == human.Id;
            }
            return false;
        }

        // Overriding memberwiseclone
        public Human Clone()
        {
            // This is called shallow copy
            object obj = base.MemberwiseClone();
            return obj as Human;
        }


    }
}
