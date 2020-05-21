using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU.TusasKazanMyo.KitapeviSistemiApp
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("A) Kitap Ekle         B) Kitapevindeki kitapları listele");
            Console.WriteLine("Bir komut ekleyiniz! Kitap eklemek için a'yı, kitap listelemek için b'yi");
            string ekle = "a";
            string listele = "b";

            string menu = Console.ReadLine();


            if (menu == ekle)
            {

                try
                {
                    Console.WriteLine("Kaç tane kitap girmek istiyorsunuz?");
                    int adet = int.Parse(Console.ReadLine());

                    int[] adet_ = new int[adet];

                    for (int i = 0; i < adet; i++)
                    {
                         Kitap.DosyaKayitIslemi();
                    }

                   
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("Lütfen rakam giriniz!");
                    Console.WriteLine("Kaç tane kitap girmek istiyorsunuz?");
                    int adet = int.Parse(Console.ReadLine());
                    int[] adet_ = new int[adet];

                    for (int i = 0; i < adet; i++)
                    {
                        Kitap.DosyaKayitIslemi();
                    }
                }

            }

            else if (menu == listele)
            {

                StreamReader sr = new StreamReader(@"C:\Kitapevi Sistemi\liste.txt");
                Console.WriteLine(sr.ReadToEnd());
            }



            Console.ReadKey();
        }
    }
}
