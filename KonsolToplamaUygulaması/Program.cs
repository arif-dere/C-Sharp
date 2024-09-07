using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolToplamaUygulaması
{

    class Program
    {
        public static void Main(string[] args)
        {
            String sayi1;
            String sayi2;
            int donusum1;
            int donusum2;
            int toplam;
            int sonuc;
            Console.WriteLine("Birinci Sayıyı Giriniz:");
            sayi1 = Console.ReadLine();
            Console.WriteLine("İkinci Sayıyı Giriniz:");
            sayi2 = Console.ReadLine();
            donusum1 = Convert.ToInt32(sayi1);
            donusum2 = Convert.ToInt32(sayi2);
            toplam = donusum1 + donusum2;
            sonuc = toplam;
            Console.WriteLine("Girdiğiniz İki Sayının Toplamı: " + sonuc);
            Console.ReadKey();


        }
    }
}
