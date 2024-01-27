//Enumeration

namespace NewSecond
{


    internal class Program
    {
        static public void Test(Employee employee)
        {

        }
        static void Main(string[] args)
        {
            //Struct and Enums are value type 

            #region Enums
            //Grade grade = Grade.Excelent;
            //if(grade == Grade.Good)
            //{
            //    Console.WriteLine("Grade = " + Grade.Good);
            //}
            //else
            //{
            //    Console.WriteLine(grade);
            //}

            //Color color = Color.Red | (Color)2;

            //Color color1 = (Color)4;
            //Console.WriteLine(color1);

            //Console.WriteLine(color);

            //if (color == Color.Red) Console.WriteLine("Equal.");
            //else Console.WriteLine("Not Equal.");

            //if (Color.Red == (color & Color.Red)) Console.WriteLine("Contains Red.");
            //else Console.WriteLine("Not Contain."); 
            #endregion


            #region struct
            //Complex c = new Complex(); // == Complex c = default 

            //Console.WriteLine(c.Real);

            //Complex c1;
            //c1.Real = 10;

            //Console.WriteLine(c1.Real);

            //Complex c2;
            //c2.Real = 20;

            //Console.WriteLine(c2.Real);

            //Complex complex = new Complex(3, 4); 

            //
            //c1 = c2;

            //if(c1 == c2) // Must be have operator overload

            // Warning C++ Here
            //---------------------------------------------------
            // C++ Program to overload == operator

            //# include<iostream>
            //# include<string>
            //            using namespace std;

            //    class Car
            //    {
            //        private:
            //    string name;
            //        int cost;
            //        public:
            //        Car(string n, int c)
            //        {
            //            name = n;
            //            cost = c;
            //        }
            //        bool operator ==(const Car &c){
            //            if (name == c.name && cost == c.cost)
            //                return true;
            //            return false;
            //        }
            //};
            //int main()
            //{
            //    Car car1("Santro",500000);
            //Car car2("Safari",1000000);
            //if (car1 == car2)
            //    cout << "Equivalent" << endl;
            //else
            //    cout << "Not Equivalent" << endl;
            //}
            //---------------------------------------------

            #endregion


            // Class is reference type
            #region Class
            //Objects in C# does not have names and access to it must be with reference

            Employee employee = new Employee(1, "Amr");

            //Refernce here have the sama storage of string
            //employee.Name = "Test";
            //Reference here have the same storage of integer
            //employee.Id = 1;

            Employee employee2 = new Employee(2, "Ali");
            //employee.Name = "Test2";
            //employee2.Id = 2;

            employee = employee2;

            // Now employee ex object is unreachable, then garbage collector will remove that object

            if (employee == employee2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //Send "Reference of Object"
            Test(employee2);

            Employee employee1 = null;
            // Null Reference Exception
            employee1.Id = 1;

            int x = default;

            Employee employee3 = new Employee() { Id = 2, Name = "Abdullah", Salary = 5000}; // Object Initializer
            Employee employee4 = new Employee(10, "Ali") { Id = 5, Salary = 5000 }; // Id will be 5


            #endregion

            //Reference will gone when function is over
        }
    }
}