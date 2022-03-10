using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul3_1302201138
{
    internal class main
    {
        static void Main(string[] args)
        {
            //Inisialisasi
            KodePos kp = new KodePos();

            //Pemanggilan method
            Console.WriteLine("note: huruf pertama harus kapital!\n");
            Console.Write("Masukan nama kelurahan: ");
            string kel = Console.ReadLine();
            Console.WriteLine(kp.getKodePos(kel));
        }
    }
}
