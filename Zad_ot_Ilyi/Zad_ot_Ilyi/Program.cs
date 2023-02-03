using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_ot_Ilyi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mest = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            Catamaran catamaran_1 = new Catamaran();
            catamaran_1.Set_kol_vo_mest(mest);
            catamaran_1.Set_name(name);
            int kolvobalon = catamaran_1.Get_kol_vo_baloon();
            Console.WriteLine(kolvobalon);

            
            Console.ReadLine();
        }
    }
    public class Catamaran
    {
        //fields
        private int kol_vo_ballon = 2;
        private int kol_vo_mest;
        private string name;
        private bool est_baloon = false;
        private bool sost_kat  = false;

        //methods
        public void Set_kol_vo_mest(int mest)
        {
            kol_vo_mest = mest;
        }
        public void Set_name(string setname)
        {
            name = setname;
        }
        public int Get_kol_vo_baloon()
        {
            return kol_vo_ballon;
        }
        public void start()
        {
            sost_kat = true;
        }
        public void stop()
        {
            sost_kat = false;
        }
    } 
}
