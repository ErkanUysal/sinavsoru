using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takimsinavlari
{
    internal class sorujk
    {
        public string Soruu { get; set; }
        public string Cevap1 { get; set; }
        public string Cevap2 { get; set; }
        public string Cevap3 { get; set; }
        public string Cevap4 { get; set; }
        public string Dogru { get; set; }

        public sorujk(string soruu, string cevap1, string cevap2, string cevap3, string cevap4, string dogru)
        {
            Soruu = soruu;
            Cevap1 = cevap1;
            Cevap2 = cevap2;
            Cevap3 = cevap3;
            Cevap4 = cevap4;
            Dogru = dogru;

        }

        public void yazdırjk()
        {
           
            Console.WriteLine($"{Soruu}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"A) {Cevap1}\nB) {Cevap2}\nC) {Cevap3}\nD) {Cevap4}");

        }
    }
}
