namespace kelimeCeviriBuyukKucuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Çevirmek istediğiniz türü seçin (büyük/küçük)");
                string turSecim = Console.ReadLine();
                if (turSecim == "büyük" || turSecim == "buyuk")
                {
                    Console.Write("Çevrilecek kelimeyi veya cümleyi giriniz: ");
                    string cevirBuyuk = (Console.ReadLine());
                    Console.WriteLine("Sonuç: {0}", cevirBuyuk.ToUpper());
                }
                else if (turSecim == "küçük" || turSecim == "kucuk")
                {
                    Console.Write("Çevrilecek kelimeyi veya cümleyi giriniz: ");
                    string cevirKucuk = Console.ReadLine();
                    Console.WriteLine("Sonuç: {0}", cevirKucuk.ToLower());
                }
                else
                {
                    Console.WriteLine("Hata! İki Seçenekten herhangi birisini Seçmediniz...");
                }
            }
        }
    }
}
