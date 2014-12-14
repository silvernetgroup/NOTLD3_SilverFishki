using System;
using System.Collections.Generic;
using System.Text;

namespace SilverFiszki
{
    public static class Counter
    {
        public static int Suma { get { return Znam + Nieznam; } }
        public static int Znam { get; set; }
        public static int Nieznam { get; set; }

        public static string Jezyk { get; set; }
        public static string Poziom { get; set; }
        public static int PoziomNumer { get; set; }
    }
}
