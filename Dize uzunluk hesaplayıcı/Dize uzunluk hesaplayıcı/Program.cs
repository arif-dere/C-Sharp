namespace Dize_uzunluk_hesaplayıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Uzunluğu hesaplanacak kelime veya cümle giriniz:");
                    string dize = Console.ReadLine();
                    int uzunlukHesapla;
                    uzunlukHesapla = dize.Length;
                    Console.WriteLine("Girdiğiniz Kelime/Cümle uzunluğu: {0}", uzunlukHesapla);
                    Console.WriteLine("");
                    Console.WriteLine("(y/n) Başka işlem yapmak istiyor musunuz?");
                    string islem = Console.ReadLine();
                    if (islem == "y" || islem == "Y")
                    {

                    }
                    else if (islem == "n" || islem == "N")
                    {
                        Console.WriteLine("İşleminiz üzere Çıkış yapılıyor...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçenek girdiniz. Çıkış yapılıyor...");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı işlem yaptınız Tekrar Deneyiniz.");
                }
                finally
                {
                    Console.Write("\n");
                }
            }

        }
    }
}
