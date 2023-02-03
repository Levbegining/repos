using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.price = int.Parse(Console.ReadLine());
            Test.kol_vo = int.Parse(Console.ReadLine());

            double answer = Test.Cost();
            Console.WriteLine(answer);
        }
    }
    public static class Test
    {
        //fields
        public static double price;
        public static int kol_vo;
        //methods
        public static double Cost()
        {
            return price * kol_vo;
        }
    }
}
