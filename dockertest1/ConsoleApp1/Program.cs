using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World! -> " + DateTime.Now.ToString("HHmmss"));
                Thread.Sleep(1000);
            }
            
        }
    }
}
