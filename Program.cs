using System;
using System.Collections.Generic;
using System.Linq;



namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
             byte b = 5;     // 1 Byte
             sbyte s = 5;    // 1 Byte 

            short s1 = 5;    // 2 Byte
            ushort s2 = 5;   // 2 Byte


            Int16 i16 = 2;   // 2 Byte
            int i = 2;       // 4 Byte
            Int32 i32 = 2;   // 4 Byte
            Int64 i64 = 2;   // 8 Byte
            

            uint u = 2;      // 4 Byte
            long l = 2;      // 4 Byte
            ulong r = 2;     // 8 Byte

            // Reel Sayılar
            
            float f = 2;      // 4 Byte
            double d = 2;     // 8 Byte
            decimal c = 2;                      // 16 Byte
                
            char e = 'e';                       // 2 Byte
            string str = "Melih Özaslan";      // Sınırsız
            Console.WriteLine(str);



            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 5.5;

            // String İfadeler 
            string str1 = string.Empty;
            str1 = "Osman Melih Özaslan";
            string ad = "Osman Melih";
            string soyad = "ÖZASLAN";
            string tamisim = ad + " " + soyad;
            Console.WriteLine(tamisim);


            // İnteger Tanımlama Şekilleri 
            int integer1 = 65;
            int integer2 = 85;
            int integer3 = integer1 * integer2;

            Console.WriteLine(integer3);

            // boolen
            bool bool1 = 10>4;
            Console.WriteLine(bool1);

            // Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);                   //Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);                       // Çıktısı 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);                       // Çıktısı 40

            // DateTime 

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);

























        }
    }
}
