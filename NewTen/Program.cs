
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace NewTen
{
    internal class Program
    {
        // Main Thread
        static void Main(string[] args)
        {
            //ThreadStart threadStart = new ThreadStart(PrintY);
            //Thread thread = new Thread(threadStart);
            //Thread thread = new Thread(PrintY);
            //thread.Start();
            //PrintX();
            // These two functions are running in two threads, in cores on CPU
            // Every time program running the results will be differents becaus interrupt and input/output operations
            // (Main function) is Parent Process and function(PrintX) running in main thread,
            // (thread(PrintY)) is child process

            // In Operating System if parent process die then delete cascade will happen
            // to child and it will die (termination) and that does not happend

            // We have two type of threads 
            // 1- Foreground Thread: if parent end process and Foreground
            // still work => the parent will wait it and then will die
            // Like example above
            // 2- Background Thread: if parent end process and Background
            // still work => the parent will terminate it and will die 
            // Like example bottom 

            //thread.Start();
            //thread.IsBackground = true;
            //PrintX();



            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write("X");
            //    //if(i == 700) thread.Join();
            //}

            //bool finished = thread.Join(1000); // join member function calling it by object
            //bool finished = thread.Join(TimeSpan.FromSeconds(1000));
            //thread.ThreadState
            //if(!finished)
            //{
            //    thread.Abort();
            //}



            //ParameterizedThreadStart threadStart = new ParameterizedThreadStart(PrintY);
            //Thread thread = new Thread(threadStart);
            //thread.Start(1000); // Not the best solution, because if we need more parameters and it casting object every time
            //PrintX();


            //Thread thread = new Thread(Test);
            //Thread thread = new Thread(() => PrintY(1000));
            //thread.Start(); 
            // If we do try and catch exception and exception happen
            // in try, it will not excute catch because it work with try and catch
            // as two processes then if happen exception in child the prorgram will 
            // terminate
            // we handle that by do try and catch in function PrintY



            //PrintX();


            //Helper helper = new Helper();
            //Thread thread = new Thread(helper.PrintMsg);
            //thread.Start();
            //helper.PrintMsg();


            // This type of thread does not work with threads that return value

            // If you want to work with webserver and send request (URL FaceBook)
            // and webserver have many requests => the web server does not handle
            // requests one by one, the web server will create threads to every one
            // send request 

            // If you want to Do that website does not work => you will send many
            // requests and the website will create many threads and it will be 
            // unworked (DDOS Attack)

            // Create new thread => high performance because it will take many time
            // untill memory handle it

            // CLR will Creat thread Pool, when running program, and it will give
            // that thread to server when need it, and after done, server will return
            // it to CLR

            //Task // Task is back ground threads
            // Task s = new Task(); // error

            // ThreadPool and Task => they creat threads

            //Task.Run(() => PrintY(1000)); // If we run this alone it will Print nothing
            // because Task is back ground thread
            //Task task = Task.Run(() => PrintY(1000));
            //task.Wait(); // If we run this alone it will Print Ys because wait
            // If we do try and catch exception and exception happen
            // in try, it will excute catch (as we know Thread will not)
            // in Thread there is no return result but here exist

            //PrintX();
            //PrintY(1000);

            RunAsync();
            PrintX();



        }

        private static async void RunAsync()
        {
            //Task<int> task = Task.Run(() => MyFunc()); // <int> because myfunc will return int 
            //TaskAwaiter<int> awaiter = task.GetAwaiter();
            //awaiter.OnCompleted(() => Console.WriteLine($"Result = {awaiter.GetResult()}")); // Action means delegate indicates to function


            // Task come from CLR, CLR take it from Thread Pool


            //Thread.Sleep(3000); 

            //Console.WriteLine($"Result = {task.Result}"); // return from myfunc
            // Function result will block any thing after it untill it running

            // This is equal code above
            int result = await Task.Run(() => MyFunc()); 
            
            Console.WriteLine($"Result = {result}");// this will run after thread done
        }

        static int MyFunc()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Here............");
            return 0;
        }

        private static void Test()
        {
            //PrintY(1000);
            Console.WriteLine("Task Completed");
        }

        static void PrintX()
        {
            for(int i = 0; i < 1000; i++) 
            {
                Console.Write("X");
            }
        }
        static void PrintY(int num)
        {
            //throw new Exception();

            for (int i = 0; i < num; i++)
            {
                //if (i == 500) Thread.Sleep(1000); // Sleep is static function
                Console.Write("Y");
            }
        }
    }
}