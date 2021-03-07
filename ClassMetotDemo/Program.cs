using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { };
            musteri1.Id =1;
            musteri1.Adi = "Elif";
            musteri1.Soyadi = "Ayan";
            musteri1.Limit = 15000;


            Musteri musteri2 = new Musteri() { };
            musteri2.Id = 2;
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demiroğ";
            musteri2.Limit = 20000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ayşe";
            musteri3.Soyadi = "Yıldırm";
            musteri3.Limit = 5000;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Ahmet";
            musteri4.Soyadi = "Korkmaz";
            musteri4.Limit = 1000;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4 } ;

            //foreach (Musteri musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Id);
            //    Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            //    Console.WriteLine(musteri.Limit);
            //    Console.WriteLine("------------------------------------");
            //}

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("---------------Müşteri Ekle-------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            Console.WriteLine("---------------Müşteri sil--------------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri4);

            Console.WriteLine("---------------Müşteri Listele--------------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);




        }
    }
}
