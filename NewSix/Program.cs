namespace NewSix
{
    // Compiler will implement class and will inherit from delegit
    //class delFilter : Delegate
    //{

    //}

    delegate bool delFilter(int item);
    delegate bool delCheck(int item);
    delegate string MyDelegate(int item, string s);
    internal class Program
    {

        static bool IsPositive(int num)
        {
            Console.WriteLine("Positive.....");
            return num > 0;
        }

        static bool IsNegative(int num)
        {
            Console.WriteLine("Negative.....");
            return num < 0;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        // Behaviour change => Polimerphism
        //static List<int> Filter(List<int> list, IFilter filter)
        //{
        //    List<int> result = new List<int>();
        //    foreach (int i in list)
        //    {
        //        if(filter.Check(i)) result.Add(i);
        //    }
        //    return result;
        //}


        // Delegate == Pointer to function in C
        static List<int> Filter(List<int> list, Predicate<int> del) //delFilter del)
        {
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                if (del(i)) result.Add(i);
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region Delegates
            //List<int> myList = new List<int>() { 1, 2, 3, -4, 5, 6, -7, 8, 9, 10 };

            //List<int> newList = Filter(myList, new PositiveFilter());
            //List<int> newList1 = Filter(myList, new NegativeFilter());
            //List<int> newList2 = Filter(myList, new OddFilter());
            //List<int> newList3 = Filter(myList, new EvenFilter());

            //foreach (int i in newList1)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int i in newList2)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int i in newList3)
            //{
            //    Console.WriteLine(i);
            //}


            //delFilter del = new delFilter(IsNegative); // delFilter del = IsNegative;
            //delFilter del2 = IsPositive;
            //bool flag = del(3); // == bool flag = del.Invoke(3);

            //List<int> newList = Filter(myList, IsPositive);

            //foreach (int i in newList)
            //{
            //    Console.WriteLine(i);
            //}

            //List<int> newList1 = Filter(myList, IsOdd);

            //foreach (int i in newList1)
            //{
            //    Console.WriteLine(i);
            //}


            //Calling Static Function
            //delFilter dell = Helper.IsEven;
            //List<int> newList2 = Filter(myList, dell);
            //foreach (int i in newList2)
            //{
            //    Console.WriteLine(i);
            //}

            // Calling non Static Function

            //Helper helper = new Helper();
            //delFilter dell1 = helper.IsOdd;
            //List<int> newList3 = Filter(myList, dell1);
            //foreach (int i in newList3)
            //{
            //    Console.WriteLine(i);
            //}

            //List<int> newList3 = Filter(myList, delegate (int item)
            //{
            //    return item < 0;
            //}); // Write Function in the fly, name of this function is "Anonymous"

            //delFilter del = i => i < 0;
            //List<int> newList3 = Filter(myList, del);

            //MyDelegate del = delegate (int i, string s)
            //{
            //    return s + i;
            //}; // MyDelegate del =  (i, s) => s + i;

            //List<int> newList3 = Filter(myList, item => item < 0); // Lambda Expression
            // It Read: Given item "input parameter" then return item < 0

            //delFilter del2 = IsPositive;
            //delCheck del3 = IsPositive; // != delFilter
            // Filter(del3); // Error
            //foreach (int i in newList3)
            //{
            //    Console.WriteLine(i);
            //}

            // Delegates available are famuos like Action, Funcy and Predicate 

            //Predicate<int> del = IsPositive;
            //Filter(myList, del); // Error 

            //Func<string> del = () => "Hello"; // function did not take anything
            // and return string

            //Func<int, string> del = x => x.ToString(); // Last datatype written in list is
            // the return datatype
            // ,This function take parameter int
            // return string

            //Func<int, string, double> // return double

            //Func<int, void> // Error because void is not datatype

            //Action<int> del // take int and return nothing
            //Action<int, string> del // take int, string and return nothing
            //......
            //Action<int, string> del = (i, s) => Console.WriteLine("Hello");

            //Action action // Take nothing and return nothing

            //MulticastDelegate // All delegates inherit from it

            //Predicate<int> del1 = IsPositive;
            //del1 += IsNegative; // that means del1 indicates to IsPositive, IsNegative
            //del1 += Helper.IsEven;
            //bool flag = del1.Invoke(1); // return last function will be in flag
            // , all of functions that del1 indicates to them
            // in Function InvokationList() 
            #endregion


            // Publisher : the person that have event happens (webpage)
            // subscriber : user
            Person person = new Person() { Name = "Ali" };
            Person person2 = new Person() { Name = "Mohammed"};
            Magazine magazine = new Magazine();


            Website website = new Website();
            website.MsgArrived += person.MsgHere; // Notification to Ali (subscribtion)
            website.MsgArrived += person2.MsgHere; // Notification to Mohammed
            website.MsgArrived += magazine.WebsiteSentAMessage;


            //(website.MsgArrived = magazine.WebsiteSentAMessage;
            //website.MsgArrived = null;
            // This is a problem because any one can modify it
            // Solution is add event to delegate in class website
            // Now any one can not assign delegate or set it equal null ==> error)

            website.AddNews("Al Ahly will lose all matches ISA");

            website.MsgArrived -= person.MsgHere; // Desubscribtion

            AnotherPublisher publisher = new AnotherPublisher();
            publisher.MsgSent += person.MsgHere;
            publisher.MsgSent += person2.MsgHere;

            website.AddNews("Al Zamalek will win all matches ISA");
            publisher.AddInformation("Wake up to reality.......");


        }
    }
}