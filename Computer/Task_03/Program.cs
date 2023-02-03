using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();      // вкл компьютер
            Computer.Stop();       // выкл компьютер

            Console.ReadLine();
        }
    }
    public static class Computer
    {
        //fields



        //methods
        public static void Start()
        {
            Console.WriteLine("Start!");
        }
        public static void Stop()
        {
            Console.WriteLine("Stop!");
        }
    }

}