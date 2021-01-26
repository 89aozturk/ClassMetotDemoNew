using System;

namespace ClassMetotDemoNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNo = "20201212301";
            musteri1.Ad = "Ali";
            musteri1.SoyAdi = "Oytun";
            musteri1.Cinsiyet = "Erkek";
            musteri1.Yas = 26;
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNo = "21444586963";
            musteri2.Ad = "Ayşe";
            musteri2.SoyAdi = "Can";
            musteri2.Cinsiyet = "Bayan";
            musteri2.Yas = 24;
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TcNo = "78954361256";
            musteri3.Ad = "Akın";
            musteri3.SoyAdi = "Türk";
            musteri3.Cinsiyet = "Erkek";
            musteri3.Yas = 34;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);

            musteriManager.Listeleme(musteri2);

            musteriManager.Silme(musteri3);
        }
    }
}
