using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takimsinavlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            liste l = new liste();
            #region sorufb

            l.eklefb(new sorufb("Fenerbahçe'nin geçen sezonki 10 numarası Kimdir?", "Arda Güler", "Dusan Tadic", "Alex De Souza", "Diego Rossi", "A"));
            l.eklefb(new sorufb("Fenerbahçe'nin Aktif Kalecisi Kimdir?", "Altay Bayındır", "Carlos Kameni", "Dominik Livakovic", "Volkan Demirel", "C"));
            l.eklefb(new sorufb("Fenerbahçe'nin En Son Kazandığı Kupa Hangi Sezona Aittir?", "2019 - 2020", "2021 - 2022", "2018 - 2019", "2022 - 2023", "D"));
            l.eklefb(new sorufb("Fenerbahçe' En Son Lig Şampiyonluğu Gören Hocası Kimdir?", "Jorge Jesus", "Ersun Yanal", "Aykut Kocaman", "İsmail Kartal", "B"));
            l.eklefb(new sorufb("Fenerbahçe'nin Geçen Sezon Rekor Bedelle Sattığı Oyuncu Kimdir?", "Arda Güler", "Kim min Jae", "Miguel Crespo", "Altay Bayındır", "A"));
            l.eklefb(new sorufb("Hangi Oyuncu Fenerbahçe'ye Bu Sezon Katılmamıştır?", "Dusan Tadic", "Sebastian Szymanski", "Joshua King", "Edin Dzeko", "C"));
            l.eklefb(new sorufb("Hangisi Bu Sezon Fenerbahçenin Rakiplerinden Birisi Değildir?", "Nordsjaelland", "Spartak Trnava", "Lugano", "Ludogorets", "C"));
            l.eklefb(new sorufb("Hangisi Fenerbahçe Spor Kulübü Başkanlığı Yapmamıştır?", "Ali Şen", "Ali Koç", "Aziz Yıldırım", "Vefa Küçük", "D"));
            l.eklefb(new sorufb("Hangisi Fenerbahçe Futbol Kulübünde Forma Giymemiştir?", "Rüştü Reçber", "Bülent Korkmaz", "Sezer Öztürk", "Tanju Çolak", "B"));
            l.eklefb(new sorufb("2012 - 2013 Avrupa Ligi Yarı Final Eşleşmesinde İstanbulda Oynanan Maçta Benfica'ya Golü Kim Atmıştır", "Egemen Korkmaz", "Moussa Sow", "Cristian Baroni", "Dirk Kuyt", "A"));

            #endregion

            #region sorulargs

            l.eklegs(new sorugs("Galatasaray' Avrupa Kupasını Hangi Sezonda Kazanmıştır?", "2000 - 2001", "1999 - 2000", "2001 - 2002", "1998 - 1999", "B"));
            l.eklegs(new sorugs("Galatasaray'da Geçen Sezonun En Golcü Futbolcusu Hangisidir?", "Mauro Icardi", "Dries Mertens", "Sergio Oliviera", "Nicolo Zaniolo", "A"));
            l.eklegs(new sorugs("Galatasaray Geçen Sezonu Kaç Puanla Tamamlamıştır?", "87", "85", "86", "88", "D"));
            l.eklegs(new sorugs("Galatasaray 4. Yıldızını Hangi Sezon Takmıştır?", "2013 - 2014", "2015 - 2016", "2014 - 2015", "2015 - 2016", "C"));
            l.eklegs(new sorugs("Galatasaray En Son Tek Sezonda Türkiye İçindeki Tüm Kupaları Kazandığında Takımın Başında Kim Vardı?", "Fatih Terim", "Roberto Mancini", "Hamza Hamzaoğlu", "Igor Tudor", "C"));
            l.eklegs(new sorugs("Hangisi Bu Sezon Galatasarayın Rakiplerinden Birisi Değildir?", "Bayern Munchen", "Manchester City", "Manchester United", "FC Kopenhag", "B"));
            l.eklegs(new sorugs("Hangisi Galatasaray Spor Kulübü Başkanlığı Yapmamıştır?", "Abdurrahim Albayrak", "Ünal Aysal", "Mustafa Cengiz", "Dursun Özbek", "A"));
            l.eklegs(new sorugs("Hangi Oyuncu Galatasaraya Bu Sene Katılmamıştır?", "Wilfred Zaha", "Cedric Bakambu", "Kerem Demirbay", "Kaan Ayhan", "D"));
            l.eklegs(new sorugs("Galatasaray Kaç Kere Ziraat Türkiye Kupasını Kazanmıştır??", "17", "16", "18", "19", "C"));
            l.eklegs(new sorugs("Galatasaraylı Efsane Futbolcu Muslera İlk Sezonunda Hangi Forma Numarasını Giymiştir?", "25", "24", "1", "98", "A"));

            #endregion

            #region sorularbjk

            l.eklejk(new sorujk("Beşiktaş En Son Hangi Sezonda Şampiyon Olmuştur?", "2020 - 2021", "2019 - 2020", "2018 - 2019", "2021 - 2022", "A"));
            l.eklejk(new sorujk("Beşiktaş'ın En Son Gol Kralı Olmuş Oyuncusu Kimdir?", "Anderson Talisca", "Vincent Aboubakar", "Mario Gomez", "Wagner Love", "C"));
            l.eklejk(new sorujk("Beşiktaş'ın Futbolcusu Gedson Fernandes Geçmiş Sezonlarda Hangi Takıma Kiralanmıştı?", "Malatyaspor", "Gaziantepspor", "Rizespor", "Trabzonspor", "C"));
            l.eklejk(new sorujk("Beşiktaşın Rekor Bedelle Sattığı Cenk Tosun Hangi Takıma Gitmiştir?", "Leicester City", "Hull City", "Brighton", "Everton", "D"));
            l.eklejk(new sorujk("Beşiktaşın Arka Arkaya Şampiyon Olduğu Dönemde Takımı Kim Yönetmiştir?", "Sergen Yalçın", "Şenol Güneş", "Slaven Bilic", "Abdullah Avcı", "B"));
            l.eklejk(new sorujk("Beşiktaşın Kalecisi Kaç Numarayı Giymektedir?", "34", "1", "35", "33", "A"));
            l.eklejk(new sorujk("Beşiktaş Kaç Kere Süper Lig Şampiyonu Olmuştur?", "10", "22", "18", "14", "D"));
            l.eklejk(new sorujk("Beşiktaşın Efsane Başkanı ve Onursal Başkanı Kimdir?", "Fikret Orman", "Ahmet Nur Çebi", "Süleyman Seba", "Yıldırım Demirören", "C"));
            l.eklejk(new sorujk("Beşiktaşın Kalecisi Kimdir?", "Mert Günok", "Fabri", "Ersin Destanoğlu", "Rüştü Reçber", "A"));
            l.eklejk(new sorujk("Beşiktaşın 7 Numarayı Giyen Efsane Oyuncusu?", "Manuel Fernandes", "Quaresma", "Pepe", "Talisca", "B"));

            #endregion



            Console.WriteLine("*-*-*-*-*-TAKIMLAR SINAVINA HOŞGELDİNİZ-*-*-*-*-*");
            Console.WriteLine("Sınav Geçme Notu 70'dir");
            Console.WriteLine($"*-*-*-TAKIM KODLARI-*-*-*\nFB = Fenerbahçe sorularını açar\nGS = Galatasaray Sorularını Açar\nBJK = Beşiktaş Sorularını Açar");
            string secenek = "e";
            while (secenek == "e")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Lütfen Takımınızın Kodunu Giriniz");
                Console.ForegroundColor = ConsoleColor.White;

                l.listele();
                Console.WriteLine("Diğer Takımların Sınavını Denemek İster misin? e/h");
                secenek = Console.ReadLine();
                if (secenek != "e")
                {
                    Console.WriteLine("Çözümlerin İçin Teşekkürler.");
                   
                }

            }

        }
    }
}
