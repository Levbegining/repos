using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();

            string name = Console.ReadLine();
            Computer.Welcome(name);

            Computer.Stop();

            Console.ReadLine();
        }
    }

    // Тут будет ваш код
    public static class Computer
    {


        public static void Start()
        {
            Console.WriteLine("Start!");
        }
        public static void Stop()
        {   
            Console.WriteLine("Stop!");
        }
        public static void Welcome(string name)
        {
            Console.WriteLine("Hello, "+name);
        }
    }
}