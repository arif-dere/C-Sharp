using System;

namespace KullanıcıGirisEkranı
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string kAd, kAd1;
            int parola, parola1;
            kAd = "admin";
            parola = 1234;
            int denemeHakkı = 3;

            while (true)
            {
                try
                {
                    Console.WriteLine("                                        |----------------------------------|");
                    Console.WriteLine("                                        | {0:U} |", DateTime.Now);
                    Console.WriteLine("                                        |----------------------------------|");
                    Console.WriteLine();
                    Console.Write("Kullanıcı adı giriniz: ");
                    kAd1 = Console.ReadLine();
                    if(!kAd.Equals(kAd1))
                    { 
                        Console.WriteLine("Hatalı kullanıcı adı girdiniz. Kalan deneme hakkınız {0}",denemeHakkı--);
                        if (denemeHakkı == -1)
                        {
                            Console.WriteLine("Deneme Hakkınız Bitti!!!");
                            break;
                        }
                        
                    }
                    else
                    {
                        Console.Write("Şifrenizi Girin: ");
                        parola1 = Convert.ToInt32(Console.ReadLine());
                        if (!(parola1 == parola))
                        {
                            Console.WriteLine("Hatalı Şifre girdiniz. Lütfen En Baştan Tekrar Deneyiniz!!!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sisteme Hoş Geldiniz {0} Bey", kAd);
                            break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Hatalı işlem yaptınız. Lütfen tekrar deneyiniz...");
                }
                finally
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}