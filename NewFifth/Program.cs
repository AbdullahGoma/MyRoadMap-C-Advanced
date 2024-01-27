using System;
using System.Collections;

namespace NewFifth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We will assume that
            // Employee e1 = new Employee() { Salary = 1000 };
            //Employee e2 = e1++; 
            // What is happen here?
            // Employee e2 = e1;
            // e1++;
            // What happen is e1 will indicates to object have salary = 1001
            // e2 will indicates to another object have salary = 1000
            // Implementing operator ++ on reference type not fine

            //MyList myList = new MyList();
            //List<int> myList = new List<int>(); // Low Performance because fixed size
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);

            //myList.Remove(2); // 2
            //myList.RemoveAt(1); // 3
            //int x = myList[1];

            //IEnumerator iterator = myList.GetEnumerator(); 

            //while (iterator.MoveNext())
            //{
            //    int num = (int)iterator.Current;
            //    Console.WriteLine(num);
            //}

            //iterator.Reset();

            //while (iterator.MoveNext())
            //{
            //    int num = (int)iterator.Current;
            //    Console.WriteLine(num);
            //}

            //foreach (object obj in myList) // This code is equal to the last code
            //    // and it not work if we do not implement IEnumerable
            //{
            //    int num = (int)obj;
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(x);
            //ICollection<T>
            //IList<T>

            //List<Employee> list = new List<Employee>()
            //{
            //    new Employee() { Id = 1, Name = "Ali"}
            //};

            //Dictionary<int, Employee> dic = new Dictionary<int, Employee>();
            //Dictionary<string, Employee> dic1 = new Dictionary<string, Employee>();
            //dic.Add(1, new Employee() { Id = 1, Name = "Ali" });
            //dic.Add(2, new Employee() { Id = 2, Name = "Muhammed" });
            //dic.Add(3, new Employee() { Id = 3, Name = "Hossam" });
            //Employee employee = dic[1];

            //dic.Add(1, new Employee()); // Exception Here

            //if (dic.ContainsKey(1))
            //{

            //}
            //else dic.Add(1, new Employee() { });

            //foreach (int emp in dic.Keys)
            //{
            //    Console.WriteLine(emp);
            //}

            //foreach (Employee emp in dic.Values)
            //{
            //    Console.WriteLine(emp.Name);
            //}

            //foreach (int e in dic.Keys)
            //{
            //    Console.WriteLine($"Key: {e} \t Value: {dic[e]}");
            //}

            //foreach (KeyValuePair<int, Employee> e in dic)
            //{
            //    Console.WriteLine($"Key: {e.Key} \t Value: {e.Value}");
            //}



            // While List or Dynamic Array stores items at continuous memory
            // locations, Items in Linked Lists are scattered all over the heap memory.
            // While List size is fixed, Linked Lists grows dynamically.

            // List => fixed size, easy search
            // Linked List => easy insertion


            //List<Employee> list = new List<Employee>();
            //list.Add(new Employee() { Id = 1, Name = "Ali", Salary = 3000 });
            //list.Add(new Employee() { Id = 2, Name = "Bassem", Salary = 9000 });
            //list.Add(new Employee() { Id = 3, Name = "Mahmoud", Salary = 8000 });

            EmployeeList list = new EmployeeList();
            list.Add(new Employee() { Id = 1, Name = "Ali", Salary = 2000 });
            list.Add(new Employee() { Id = 2, Name = "Bassem", Salary = 9000 });
            list.Add(new Employee() { Id = 3, Name = "Mahmoud", Salary = 8000 });

            foreach (Employee e in list)
            {
                Console.WriteLine(e);
            }

            // Any Thing in foreach must implement IEnumerable

            // Value type no null, reference type have null
            // Nullable Datatypes => Datatype Allow to have null
            int? total = null; // Transaction = a - b total will equal to 0 if a = n 
            // and b = n where n > 0, a = b = 0
            // Here we want to compare between this two cases by using nullable datatypes
            //Nullable<int> nullable = null; // ==  int? total = null; 
            int num = 10;
            total = num;
            //num = total; // Error here
            //num = total.Value; // Exception here
            if(total.HasValue)
            {
                num = total.Value;
            } else { num = 0; } 


        }
    }
}