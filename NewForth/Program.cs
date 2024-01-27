using System.Collections;

namespace NewForth
{
    internal class Program
    {
        // Generic Method
        static T GetLast<T>(T[] arr)
        {
            return arr[arr.Length - 1];
        }

        //static void MoveEmployee(Employee emp)
        //{
        //    emp.Move();
        //}

        //static void MoveCar(Car car)
        //{
        //    car.Move();
        //}

        // Car and Employee does not have any related to each other => then they connot be inherit from the same class
        // When we solve this problem and creat a class "Mover" this logical is error
        // Like human, Computer make voice => logical is error when do class voice to them
        // Solve is we will do them in interface
        static void MoveObject(IMovable obj)
        {
            obj.Move();
        }

        public class SortById : IComparer
        {
            public int Compare(object? x, object? y)
            {
                return (x as Employee).Id.CompareTo((y as Employee).Id);
            }
        }

        public class SortByIdDes : IComparer
        {
            public int Compare(object? x, object? y)
            {
                return -1 * (x as Employee).Id.CompareTo((y as Employee).Id);
            }
        }

        public class SortByName : IComparer
        {
            public int Compare(object? x, object? y)
            {
                return (x as Employee).Name.CompareTo((y as Employee).Name);
            }
        }

        static void Main(string[] args)
        {
            #region Operator Overload
            //Complex complex = new Complex() { Real = 3, Img = 5 };
            //Complex complex2 = new Complex() { Real = 3, Img = 5 };
            //Complex complex3 = complex + complex2; // Complex.operator+(complex, complex2);
            //// + operator between (complex + complex2) is the calling of function
            //Complex complex1 = 5 + complex3;
            ////Complex complex4 = complex1 + 5; // Eror Here Because there is no function achieve that
            //Complex c = complex1 + 5; // Here there is no error after doing explicit casting
            //Complex complex4 = 5;
            //int num = (int)complex;

            //if (complex == complex2) Console.WriteLine("Equal");
            //else Console.WriteLine("Not Equal");

            //if (complex == 3) Console.WriteLine("Equal");
            //else Console.WriteLine("Not Equal");


            //// Explicit casting vs Implicit casting
            //float x = num; // implecit casting => happen without do casting
            //float y = (float)num; // explicit casting => happen with do casting

            //complex = complex3; // There is no overload to = operator (Assignment operator)
            ////Going back to why = cannot be overloaded,
            ////the system implementation is the only sensible thing
            ////you can do with references.
            ////You can overload operations that are applied to the objects,
            ////but not to references.

            //Console.WriteLine(complex++);

            //Console.WriteLine(--complex); 
            #endregion



            #region Generics
            //// Templets in C++ is Generic in C#
            //MyList<int> myList = new MyList<int>();
            ////MyList<string> myList2 = new MyList<string>();
            //MyList<Employee> myList3 = new MyList<Employee>();
            //MyList<Manager> myList1 = new MyList<Manager>();


            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);

            //for (int i = 0; i < 10; i++) Console.WriteLine(myList.GetByIndex(i));

            //int[] arr = { 1, 2, 3, 4 };
            //int num = GetLast(arr); // GetLast<int>(arr)


            #endregion



            #region Interface,Icomparable,Comparer, ...
            //Employee e = new Employee();
            //Car c = new Car();
            //IMovable m = new Manager();

            // IMovable movable = new IMovable(); //Error
            // Interface and Abstract are different in logic "Very Important"
            // if two classes from the same business => Abstract class
            // if two classes not from the same business => Interface class

            //MoveObject(e);
            //MoveObject(c);
            //MoveObject(m);

            //int[] arr = { 1, 2, 3, 2, 1, 3, 4, 5, 49, 34, 30 };

            //Array.Sort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Employee[] emp = new Employee[3]
            //{
            //    new Employee { Id = 3, Name = "Ali" },
            //    new Employee { Id = 2, Name = "Mohamed" },
            //    new Employee { Id = 1, Name = "Basem" }
            //};

            ////Array.Sort(emp); // Sort has interface



            //Array.Sort(emp, new SortByName());
            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine(emp[i]);
            //}

            //Array.Sort(emp, new SortByIdDes());
            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine(emp[i]);
            //}

            //Array.Sort(emp, new SortById());
            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine(emp[i]);
            //} 
            #endregion
        }
    }
}