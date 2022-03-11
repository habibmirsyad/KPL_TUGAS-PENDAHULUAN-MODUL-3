using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul3_1302201138
{
    internal class DoorMachine
    {
        public string State(string pilihan)
        {
            switch (pilihan)
            {
                case "1":
                    return "Pintu Terkunci";
                    break;
                case "2":
                    return "Pintu Terbuka";
                    break;
                case "0":
                    return "Keluar dari program.";
                    break;
                case default:
                    return "Pilihan tidak tersedia.";
            }
        }
    }
}
