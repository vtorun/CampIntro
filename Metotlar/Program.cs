using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fitayi = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("----------------metodlar----------------");
            SepetManager sepetManager = new SepetManager();
            foreach (Urun urun in urunler)
            {
                sepetManager.Ekle(urun);
            }
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);

        }
    }
}
