using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_tip_dönüşümleri_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            sbyte b = 30;
            short c = 18;
            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            //Expilicit Conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:"+t);

            float w = 10.3f;
            byte v=(byte)w;
            Console.WriteLine("v:" + v);


            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy" + yy );

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam= sayi1+ sayi2;
            Console.WriteLine(Toplam);

            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1= Int32.Parse(metin1);
            Console.WriteLine(rakam1);
        }
    }
}
