using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüleri
            // Döngüler 1+2+3+4+5+6
            // 3+3=6+4=10+5=15+6=21

            // For(x;y;z)
            // x: başlangıç
            // y: bitiş
            // z: artış, azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //    Console.WriteLine("C# Eğitim Kampı");

            //for(int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i <= 50; i += 3)
            //{ 
            //    Console.WriteLine(i);
            //} 

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet: " + i );
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //int total = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //int total = 0;
            //for(int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("+");
            //Console.WriteLine("----");
            //Console.WriteLine(total);

            //int count = 0;

            //for(int i = 1; i <= 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("----\n" + count);

            //1-2-4-8-16-32...
            //Bir bakteri her saat sonu kendini 2 ye bölerek çoğaltıyor

            //int bakterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bakterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda: " + bakterium);
            //}




            #endregion

            #region While Döngüleri

            // Şart sağlandığı sürece bu işlemleri yap!

            /* 
                while(koşul){
            
                    # Do that
                }
            */

            //int i = 1;

            //while(i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while(i <= 10)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while(i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);





            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.


            //Console.Write("Enter a number(Positive): ");
            //int number = int.Parse(Console.ReadLine());
            //int result = 0;

            //while (number > 0)
            //{
            //    result += number % 10;
            //    number /= 10;
            //}

            //Console.WriteLine(result);

            #endregion

            Console.Read();
        }
    }
}
