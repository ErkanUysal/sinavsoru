using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takimsinavlari
{
    internal class liste
    {
        sorufb[] sorularfb;
        sorugs[] sorulargs;
        sorujk[] sorularjk;
        
        public liste()
        {
            sorularfb = new sorufb[0];
            sorularjk = new sorujk[0];
            sorulargs = new sorugs[0];
        }
        public void eklefb(sorufb sorufb)
        {
            sorufb[] gecici = new sorufb[sorularfb.Length + 1];
            Array.Copy(sorularfb, gecici, sorularfb.Length);
            gecici[gecici.Length - 1] = sorufb;
            sorularfb = gecici;
        }
        public void eklegs(sorugs sorugs)
        {
            sorugs[] gecici = new sorugs[sorulargs.Length + 1];
            Array.Copy(sorulargs, gecici, sorulargs.Length);
            gecici[gecici.Length - 1] = sorugs;
            sorulargs = gecici;
        }
        public void eklejk(sorujk sorujk)
        {
            sorujk[] gecici = new sorujk[sorularjk.Length + 1];
            Array.Copy(sorularjk, gecici, sorularjk.Length);
            gecici[gecici.Length - 1] = sorujk;
            sorularjk = gecici;
        }
        public void listele()
        {
            int toplam = 0;
            string secenek = Console.ReadLine();
            Console.Clear();
            if (secenek == "FB")
            {
                for (int i = 0; i < sorularfb.Length; i++)
                {
                    sorufb f = sorularfb[i];
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($"{i+1})");                 
                    f.yazdırfb();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Lütfen Cevabınızı Giriniz");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    secenek = Console.ReadLine();
                    Console.Clear();
                    if (secenek == sorularfb[i].Dogru)
                    {
                        toplam += 10;
                                           
                    }
                   
                   
                    
                }
                if (toplam > 70)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Tebrikler İyi Bir Fenerbahçe Taraftarısın");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Notun = " + toplam);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Maalesef Doğru Takımı Tutup Tutmadığını Gözden Geçirmen Gerek");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Notun = " + toplam);
                }
               
            }
            if (secenek == "GS")
            {
                for (int i = 0;i < sorulargs.Length; i++)
                {
                    sorugs g = sorulargs[i];
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write($"{i+1})");                  
                    g.yazdırgs();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("LÜtfen Cevabınızı Giriniz");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    secenek = Console.ReadLine();                  
                    Console.Clear();
                    if (secenek == sorulargs[i].Dogru)
                    {
                        toplam += 10;
                    }

                }
                if (toplam > 70)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tebrikler İyi Bir Galatasaray Taraftarısın");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Notun = " + toplam);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Maalesef Doğru Takımı Tutup Tutmadığını Gözden Geçirmen Gerek");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Notun = " + toplam);
                }
            }
            if (secenek == "BJK")
            {
                for (int i = 0;i < sorularjk.Length; i++)
                {
                    sorujk b = sorularjk[i];
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{i+1})");
                    b.yazdırjk();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Lütfen Cevabınızı Giriniz");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    secenek = Console.ReadLine();
                    Console.Clear();
                    if (secenek == sorularjk[i].Dogru)
                    {
                        toplam += 10;
                    }


                }
                if (toplam > 70)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Tebrikler İyi Bir Beşiktaş Taraftarısın");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Notun = " + toplam);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Maalesef Doğru Takımı Tutup Tutmadığını Gözden Geçirmen Gerek");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Notun = " + toplam);
                }
            }

        }
      
    }
}
