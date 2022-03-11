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
            DoorMachine dm = new DoorMachine();

            //Pemanggilan method kelurahan dan kode pos
            Console.WriteLine("note: huruf pertama harus kapital!\n");
            Console.Write("Masukan nama kelurahan: ");
            string kel = Console.ReadLine();
            Console.WriteLine(kp.getKodePos(kel));
            
            //Pemanggilan method Door Machine
            string pilihan = "1";

            while (pilihan != "0")
            {
                Console.WriteLine("1. Tutup Pintu");
                Console.WriteLine("2. Buka Pintu");
                Console.WriteLine("0. Keluar");
                Console.Write("Masukkan pilihan anda: ");
                pilihan = Console.ReadLine();
                Console.WriteLine(dm.State(pilihan));
            }
        }
    }
}
