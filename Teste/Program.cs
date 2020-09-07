using System;

namespace Dev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            NewClass c1 = new NewClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");


        }
    }
}
