using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFirst
{
    internal class Program
    {
        // Ref vs in vs out
        //ref is used to state that the parameter passed may be modified by the method.
        //in is used to state that the parameter passed cannot be modified by the method.
        //out is used to state that the parameter passed must be modified by the method
        static int Devide(int a, int b, out int rem)
        {
            rem = a % b;
            return a / b;
        }
        static void Main(string[] args)
        {
            //Static Function Does not see non-static members

            //int x = 5, y = 6;
            //Console.WriteLine("First = {0}, Second = {1}", x,y);
            //Console.WriteLine($"First = {x}, Second = {y}");

            //string str = Console.ReadLine();    
            //Console.WriteLine(str);
            ////x = Convert.ToInt32(str);
            //x = int.Parse(str);

            //str = Console.ReadLine();   
            //y = int.Parse(str);

            ////int rem = 0;
            ////int result = Devide(x, y, ref rem);
            //int rem;
            //int result = Devide(x, y, out rem);

            //Console.WriteLine("X = " + x);
            //Console.WriteLine("Y = " + y);
            //Console.WriteLine("Devide = " + result);
            //Console.WriteLine("Reminder = " + rem);

            //---------------------------

            var p = new Person("John", "Quincy", "Adams", "Boston", "MA");

            // Deconstruct the person object.
            var (fName, _, city, _) = p;
            Console.WriteLine($"Hello {fName} of {city}!");
            // The example displays the following output:
            //      Hello John of Boston!


        }
    }
}
