using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deneme.Yazdir();

            //Program p = new Program();
            //p.SelamVer();
            SelamVer();
        }
        public static void SelamVer()
        {
            Console.WriteLine("Abi Selamlar");
        }
    }
}
