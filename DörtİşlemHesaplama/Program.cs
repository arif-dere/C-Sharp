
namespace DortIslem{
    public class Program{
        public static Double Toplama(double x, double y){
            double sonuc = x+y;
            return sonuc;
        }
        public static double Cıkarma(double x, double y){
            double sonuc = x-y;
            return sonuc;
        }
        public static int Carpma(double x, double y){
            double sonuc = x*y;
            int cevir= Convert.ToInt32(sonuc);
            return cevir;
        }
        public static double Bolme(double x, double y){
            double sonuc = x/y;
            return sonuc;
        }
        public static void Bosluk(){
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("\n");

        }
        public static void Bosluk2(){
            Console.WriteLine();
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine();
        }
        public static void Bosluk3(){
            Console.WriteLine("------------------------------------------");
        }
        public static void Main(string[] args){

           while(true){

                try{

                    Console.Write("Birinci sayıyı giriniz: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    Bosluk2();

                    Console.Write("İkinci sayıyı giriniz: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    Bosluk2();

                    Console.WriteLine("Yapmak istediğiniz işlemi seçin.(+,-,*,/)?");
                    var secim = Console.ReadLine();
                    Bosluk3();
                    switch(secim){
                      case "+":
                        Console.WriteLine($"Girdiğiniz İki Sayının Toplamı: {Toplama(x,y)}");
                        Bosluk3();
                        break;
                        

                        case "-":
                        Console.WriteLine($"Girdiğiniz İki Sayının Çıkarma Sonucu: {Cıkarma(x,y)}");
                        Bosluk3();
                        break;

                        case "*":
                        Console.WriteLine($"Girdiğiniz İki Sayının Çarpımı: {Carpma(x,y)}");
                        Bosluk3();
                        break;

                        case "/":
                        Console.WriteLine($"Girdiğiniz İki Sayının Bölme Sonucu: {Bolme(x,y)}");
                        Bosluk3();
                        break;

                        default:
                        Console.WriteLine("Hatalı Seçenek Girdiniz Lütfen Dört Seçenekten Birisini Seçiniz...");
                        Bosluk3();
                        break;
                    }
                    Console.ReadKey();
                    break;
                }
                catch{
                       Bosluk();
                       Console.WriteLine("Hatalı İfade Girdiniz Lütfen En Baştan Tekrar Deneyiniz!!!");
                       Bosluk();
                }
            
            }
        }
    }
}