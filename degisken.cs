using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger = 2;
            string degisken = null;

            byte b = 5;
            sbyte c = 6;
            short s = 7;      // 2byte yer kaplar (-+) 32768 arasında değerleri alır
            ushort us = 7;    //2byte yer kapla 0 ile 65365 arasında değer alır

            Int16 i16 = 2;    //2byte yer kaplar
            int i = 8;        //4byte yer kaplar
            Int32 i32 = 9;    //4byte yer kaplar
            Int64 i64 = 4;    //8byte yer kaplar
            uint ui = 7;      //4byte yer kaplar
            long l = 8;       //8byte
            ulong ul = 9;     //8byte

            //REEL SAYILAR
            float f= 10;       //4byte
            double d = 11;     //8byte
            decimal de = 12;   //16byte  

            char ch= 'A';       //2byte yer kaplar tek bir ifade alır
            string y = "Yakup"; //Sınırsız 

            bool b1 = false;
            bool b2 = true;

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            string str1=string.Empty;
            str1 = "Yakup KARA";
            string ad = "Yakup";
            string soyad = "KARA";
            string tamIsım = ad + " " + soyad;
            Console.WriteLine(tamIsım);

            int integer1 = 4;
            int integer2 = 5;
            int integer3 = integer1 *integer2;
            Console.WriteLine(integer3);

            //boolean
            bool bool1 = 12<7;

            string string1 = "20";
            int int20 = 20;
            string yenideger =string1+int20.ToString();
            Console.WriteLine(yenideger);               //2020 yazar

            int int21 = int20 + Convert.ToInt32(int20); 
            Console.WriteLine(int21);                   //40 yazar

            string datetime= DateTime.Now.ToString("dd.MM.yyyy");
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


             








            Console.ReadLine();
        }
    }
}
