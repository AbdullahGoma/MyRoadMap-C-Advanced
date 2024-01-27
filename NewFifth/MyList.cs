using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFifth
{
    internal class MyList : IEnumerable
    { 
        int[] arr;
        int lastIndex;

        public MyList()
        {
            arr = new int[10];
            lastIndex = - 1;
        }

        public void Add(int item)
        {
            if (lastIndex == arr.Length - 1)
            {
                Extend();
            }
            arr[++lastIndex] = item;
        }

        public int GetByIndex(int index)
        {
            if (0 <= index && index <= lastIndex) return arr[index];
            throw new IndexOutOfRangeException();
        }


        //This is a Famous problem and we find the solution using Design Pattern
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        
        private void Extend()
        {

        }

        class Iterator : IEnumerator
        {
            int currentIndex;
            MyList myList; // Can Access Private Members 
            public Iterator(MyList myList)
            {
                this.myList = myList;
                currentIndex = -1;
            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex <= myList.lastIndex;
            }

            public object Current
            {
                get { return myList.arr[currentIndex]; }
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
