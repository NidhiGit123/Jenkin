using System;

namespace Demo_App_HCSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sayHello("world"));
        }
        static string sayHello(string name)
        {
            return ("hello " + name );
        }
    }
}
