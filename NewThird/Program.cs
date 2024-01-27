namespace NewThird
{
    internal class Program
    {
        static void Test(string msg)
        {
            // This will never change in str because it will create new object 
            msg = "Test";
        } 
        static void Main(string[] args)
        {
            #region Inheritance, Polymorphism & Object
            //Creature creature = new Creature(); // Error here becuase Creature is abstract class\
            //Creature creature = new Human(); // Here we using only Reference not Object
            //Human human = new Human() { Id = 1, Name = "Ali"};
            //Human human1 = new Human() { Id = 1, Name = "Ali" };
            //human.Move();
            //human.Think();
            //Creature creature1 = new Human(); // Reference creature1 see only the functions
            //                                  // that Human inherit from Creature like Move, Eat
            //                                  // and Think will never see it
            //creature1.Move();
            //Creature creature2 = new Employee();
            //creature2.Move();

            // All Classes are inherit from Class "object"
            // Inhritance not exist in structs 

            //creature.Think(); // Error here


            //Console.WriteLine(human);
            //object obj = human;
            //Console.WriteLine(obj);   
            //if (human1.Equals(human)) { Console.WriteLine("yes"); } 


            // human, human1 does not have the same hash code
            //Console.WriteLine($"human: {human.GetHashCode()} \t human1: {human1.GetHashCode()} ");

            //Reflaction 
            //Console.WriteLine(human.GetType());

            // This will copy object human to object human2
            //Human human2 = human.Clone(); 
            #endregion


            #region Property

            // Class is a discreption to side of problem
            //Employee employee = new Employee();
            //employee.SetSalary(5000);
            //int Salary = employee.GetSalary();
            //employee.Salary = 5000; // This is calling set
            //int Salary = employee.Salary; // This is calling get

            //Human h = new Human();
            //h.Name = "Ali"; 
            #endregion


            #region Arrays
            //All Arrays in C# are Reference type
            // "arr reference in stack" and 5 locations in heap
            //int[] arr = new int[5];
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //// Collection Initializer
            //Creature[] creature = new Creature[5]
            //{
            //    new Human(),
            //    new Employee(),
            //    new Human(),
            //    new Employee(),
            //    new Human()
            //};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    creature[i].Move();
            //}

            //Creature[] creatures = new Creature[5]; // 5 References of Creature

            //for(int i = 0;i < creatures.Length;i++)
            //{
            //    creatures[i] = new Human();
            //}

            // if function test take parameter object like Test(Human human) and we
            // call it Test(10) it will be okay because when it arrive to function 
            // in runtime the compiler will do ""Boxing"" to it and it will be object 
            // from Parent class Object 
            // That is will effetiant on Performance  
            #endregion


            // String is Reference type
            string str = "Hello";
            // In this case value Hello will recorded in memory one time 
            // If user input it, it will be in different places
            string str2 = "Hello";
            //string str = new string("Hello");
            str += " Abdullah";
            // String is imutable datatype
            // In this case string => value type not reference type
            Test(str);

            // String override check references to check value to each other
            if(str == str2) { Console.WriteLine("True"); }




        }
    }
}