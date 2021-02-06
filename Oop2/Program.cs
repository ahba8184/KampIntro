using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ahmet Baş
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Baş";
            musteri1.TcNo = "12345678910";

            //Ahba.corp
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Ahba.corp";
            musteri2.VergiNo = "1234567890";

            //Gerçek - Tüzel
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);



        }
    }
}
