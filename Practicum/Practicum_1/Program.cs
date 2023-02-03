using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero();
            hero1.name = "Lev";
            hero1.health = 10;

            Hero hero2 = new Hero();
            hero2.name = "Iliya";
            hero2.health = 20;

            hero1.Say();
            hero2.Say();

            hero1.Add(3, 4);
            hero2.Add(6, 3);

            Console.ReadLine();
        }
    }
    public class Hero
    {
        //fields
        public string name;
        public int health;
        //methods
        public void Say()
        {
            Console.WriteLine("Меня зовут: " + name);
        }
        public void Add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
