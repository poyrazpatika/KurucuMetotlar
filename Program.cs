using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] özellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi (Parametre Listesi)
            //      {
            //      // Metot Komutları
            //      }
            //  }

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23415634, "İnsan Kaynakları");
            calisan1.calisanBilgileri();

            Console.WriteLine("********");

            Calisan calisan2 = new Calisan();
            calisan1.Ad = "Deniz";
            calisan1.Soyad = "Arda";
            calisan1.No = 25646789;
            calisan1.Departman = "Satın Alma";
            calisan2.calisanBilgileri();

            Console.WriteLine("********");
            
            Calisan calisan3 = new Calisan("Zikriye", "Ürkmez");
            calisan3.calisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan()
        {

        }
        public void calisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Numarası:{0}", No);
            Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }
    }

}
