using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoNew
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Yas + " eklendi. ");
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " listelendi. ");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Cinsiyet + " silindi. ");
        }
    }
}
