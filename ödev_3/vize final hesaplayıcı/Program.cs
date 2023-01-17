using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ad_soyad = new string[5];
            int[] vize = new int[5];
            int[] final = new int[5];
            int[] sonuc = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("öğrencinin adını ve soyadını yazın");
                ad_soyad[i] = Console.ReadLine();
                Console.WriteLine("vize notunu giriniz");
                vize[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("final notunu giriniz");
                final[i] = Convert.ToInt32(Console.ReadLine());
                sonuc[i] = Convert.ToInt32(vize[i] * 40 / 100 + final[i] * 70 / 100);
            }
            for(int i = 0; i <= 4; i++)
            {
                if (sonuc[i] >= 95 && sonuc[i] <= 100)
                {
                    Console.WriteLine("not değeriniz : A1 Başarılı");
                }
                else if (sonuc[i] >= 90 && sonuc[i] <= 94)
                {
                    Console.WriteLine("not değeriniz : A2 Başarılı");
                }
                else if (sonuc[i] >= 85 && sonuc[i] <= 89)
                {
                    Console.WriteLine("not değeriniz : A3 Başarılı");
                }
                else if (sonuc[i] >= 80 && sonuc[i] <= 84)
                {
                    Console.WriteLine("not değeriniz : B1 Başarılı");
                }
                else if (sonuc[i] >= 75 && sonuc[i] <= 79)
                {
                    Console.WriteLine("not değeriniz : B2 Başarılı");
                }
                else if (sonuc[i] >= 70 && sonuc[i] <= 74)
                {
                    Console.WriteLine("not değeriniz : B3 Başarılı");
                }
                else if (sonuc[i] >= 65 && sonuc[i] <= 69)
                {
                    Console.WriteLine("not değeriniz : C1 Başarılı");
                }
                else if (sonuc[i] >= 60 && sonuc[i] <= 64)
                {
                    Console.WriteLine("not değeriniz : C2 Başarılı");
                }
                else if (sonuc[i] >= 55 && sonuc[i] <= 59)
                {
                    Console.WriteLine("not değeriniz : D1 Şartlı geçer");
                }
                else
                {
                    Console.WriteLine("not değeriniz : f1 Başarısız");
                }
                Console.WriteLine("********************************************");
            }
            Console.ReadLine();

        }
    }
}
