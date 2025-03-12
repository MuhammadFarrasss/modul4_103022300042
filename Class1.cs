using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300042
{
    internal class KodeProduk
    {
        public enum Produk
        {
            Laptop, Smartphone, Tablet, Headset, Keyboard, Printer, Monitor, Smartwatch, Kamera
        }

        public static string[] kodeProduk =
        {
            "E100", "E200", "E300", "E400", "E500", "E600", "E700", "E800", "E900"
};

        public static string GetKodeProduk(Produk produk)
        {
            return kodeProduk[(int)produk];
        }
    }
}
