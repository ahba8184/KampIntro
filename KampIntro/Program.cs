using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - type güvenliği
            //Do not repeat yourself (DRY) - Kendini Tekrar etme
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;  //tamayılar
            double faizOrani = 1.45;  //ondalıklı sayılar
            bool sistemeGirisYapmismi = true;  //false değeride alabilir
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
