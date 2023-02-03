using System;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Computer.Start();     // включаем компьютер

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
    }
}