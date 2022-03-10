using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul3_1302201138
{
    public class KodePos
    {
        public string getKodePos(string kelurahan)
        {
            Console.Write("Kode Pos: ");
            switch (kelurahan)
            {
                case "Batununggal":
                    return "40266";
                    break;
                case "Kujangsari":
                    return "40287";
                    break;
                case "Mengger":
                    return "40267";
                    break;
                case "Wates":
                    return "40256";
                    break;
                case "Cijaura":
                    return "40287";
                    break;
                case "Jatisari":
                    return "40286";
                    break;
                case "Margasari":
                    return "40286";
                    break;
                case "Sekejati":
                    return "40286";
                    break;
                case "Kebonwaru":
                    return "40272";
                    break;
                case "Maleer":
                    return "40274";
                    break;
                case "Samoja":
                    return "40273";
                    break;
                default:
                    return "Kelurahan tidak terdaftar.";
            }
        }
    }
}
