using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewForth
{
    // if i have two restriction
    //MyList<T, T1> where T : new() where T1 : class 
    internal class MyList<T> where T : new()     //where T : Employee // MyList will be List of Employee and any class inherite from Employee     //where T : class // striction => T must be class
    {
        // new() : it must be constructor and parameter list
        // parameter list : because we work with unknown datatype
        // constructor : in most cases i need to create objects from your class 
        T[] arr;
        int currentIndex;

        public MyList()
        {
            arr = new T[10];
            currentIndex = -1;
        }

        public void Add(T item)
        {
            //if(item == null) // class can assign Null, Struct cannot assign Null
                             // This came because (where T : class) 

            if (currentIndex == arr.Length - 1)
            {
                Extend();
            }
            arr[++currentIndex] = item;
        }

        public T GetByIndex(int index)
        {
            if(0 <= index && index <= currentIndex) return arr[index];
            return new T(); // Came from striction new() and it will be return
                            // empty object without exception
                            // parameter must have constructor
        }

        private void Extend()
        {
            
        }
    }
}
