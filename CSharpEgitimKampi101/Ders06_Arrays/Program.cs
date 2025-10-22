using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06_Arrays
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            #region Temel Dizi örnekleri

            // 2,4,6,8,10
            // sarı,kırmızı,mavi,beyaz
            // adana,ankara,istanbul,bursa
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Berlin";
            //cities[3] = "Paris";
            //cities[4] = "Lyon";

            //Console.WriteLine(cities[5]); // 5 numaralı index bulunmuyor

            //int[] numbers = new int[10];

            //int → 0
            //double → 0.0
            //bool → false  
            //struct → tüm field’ları kendi default değerine set edilir.
            //Reference types(string, class, object) → null atanır.

            // "C# da garbage value yoktur tüm arraylar güvenli bir şekilde default value ile başlar!!!

            //numbers[0] = 50;
            //numbers[1] = 62;
            //numbers[2] = 64;
            //numbers[3] = 12;
            //numbers[4] = 14;
            //numbers[5] = 98;

            //numbers[8] = 48;

            //Console.WriteLine(numbers[6]);


            //string[] s = new string[5];

            //s[1] = "Mustafa";

            //Console.WriteLine(s[2]); // NULL

            //string[] cities = { "Milano", "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "lacivert", "asker yeşili"};

            //for(int i = 0; i < colors.Length; i++)
            //    Console.WriteLine(colors[i]);

            //int[] numbers = { 4, 8, 12, 16, 20, 24, 28, 63, 49, 39 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //        Console.WriteLine(numbers[i]);
            //}

            //char[] symbols = { 'm', 'u', 's', 't', 'a', 'f', 'a' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.Write(symbols[i]);
            //}

            //int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int max = numbers[0];

            //for(int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}

            //Console.WriteLine(max);

            #endregion

            #region Array Methods 

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length); // length of the array

            //int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //Array.Sort(numbers);

            //for(int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);

            //int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);

            //string[] customers = { "ali", "buse", "ayşe", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");

            //Console.WriteLine(customers[index] + " should be equal to: " + "merve");

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 32 , 46 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "\nDizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri girin: ");
            //    cities[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = new int[10];

            //int total = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{i + 1}. sayiyi giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //    total += numbers[i];
            //}

            //Console.WriteLine($"Girilen sayıların toplamı: {total}");

            #endregion


            #region Çift-Tek sayı örneği

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 18, 19, 110 };

            Console.WriteLine("Çift sayılar: ");

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine("-> " + numbers[i]);
            }

            Console.WriteLine("------------");
            Console.WriteLine("\nTek Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                    Console.WriteLine("-> " + numbers[i]);
            }

            #endregion

            Console.Read();
        }
    }
}
