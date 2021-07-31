using System;

namespace Konsol_Dersleri_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi1, sayi2, sonuc;
            string islem;
            Console.WriteLine("==========Hesap Makinesi==========");
            Console.WriteLine("1. Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlemi Giriniz");
            islem = Console.ReadLine();
            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
                Console.Clear();
                Console.WriteLine(sonuc);
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
                Console.Clear();
                Console.WriteLine(sonuc);
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
                Console.Clear();
                Console.WriteLine(sonuc);
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
                Console.Clear();
                Console.WriteLine(sonuc);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("HATA");
            }
            
        }
    }
}
