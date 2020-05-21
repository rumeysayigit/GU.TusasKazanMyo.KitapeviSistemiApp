using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU.TusasKazanMyo.KitapeviSistemiApp
{
    class Kitap
    {
        public Kitap()
        {

        }

        public Kitap(string kitapad, string yazarad, DateTime tarih, string tur)
        {
            this.Kitapad = kitapad;
            this.Yazarad = yazarad;
            this.Tarih = tarih;
            this.Tur = tur;

        }

        public static void DosyaKayitIslemi()
        {


            DateTime Tarih = DateTime.Now.Date;

            Console.WriteLine("Kitap adı:");
            string Kitapad = Console.ReadLine();
            Console.WriteLine("Yazarın Adı:");
            string Yazarad = Console.ReadLine();

            Tarih = Kitap.getTarih();

            int sonuc = DateTime.Compare(DateTime.Now.Date, Tarih);
            if (sonuc < 0)
            {
                Console.WriteLine("Basım tarihi 2020'den büyük olamaz.");
                Tarih = Kitap.getTarih();
            }

            Console.WriteLine("Kitabın Türü:");
            string Tur = Console.ReadLine();
            Console.WriteLine("***");

            try
            {
                FileStream fs = new FileStream(@"C:\Kitapevi Sistemi\liste.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"Kitabın Adı:{Kitapad},Kitabın Yazarı:{Yazarad},Basım Tarihi:{Tarih},Kitabın Türü:{Tur}\r\n");
                fs.Flush();
                sw.Close();
                fs.Close();
                Console.WriteLine("Eklediğiniz kitaplar kaydedildi.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Eklediğiniz kitaplar kaydedilmedi.");

            }


        }

        public static DateTime getTarih()
        {
            CultureInfo tarih_ = CultureInfo.InvariantCulture;

            try
            {
                Console.WriteLine("Basım Tarihi:");
                DateTime Tarih = DateTime.Parse(Console.ReadLine());

                return Tarih;
            }
            catch
            {
                Console.WriteLine("Tarih formatını kontrol ediniz...");
                Console.WriteLine("Basım Tarihi (Format: dd-mm-yyyy veya dd/mm/yyyy ):");
                DateTime Tarih = DateTime.Parse(Console.ReadLine());
                return Tarih;

            }
        }


        string kitapad;
        string yazarad;
        DateTime tarih;
        string tur;



        public string Kitapad
        {
            get
            {
                return kitapad;
            }

            set

            {
                kitapad = value;
            }
        }
        public string Yazarad
        {

            get
            {
                return yazarad;
            }
            set
            {
                yazarad = value;
            }
        }
        public DateTime Tarih
        {
            get
            {
                return tarih;
            }
            set
            {
                tarih = value;
            }
        }
        public string Tur
        {
            get
            {
                return tur;
            }
            set
            {
                tur = value;
            }
        }
    }
}
