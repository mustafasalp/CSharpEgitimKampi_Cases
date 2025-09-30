using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loops

            // Foreach (1;2;3;4) -> 4 Parametre alır.
            // Foreach (DeğişkenTürü; DeğişkenAdı; In; Liste, Koleksiyon veya dizinin adı) 

            //string[] cities = { "milano", "roma", "istanbul", "ankara", "izmir", "bursa" };

            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10395 };

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10395 };

            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10395 };

            //int total = 0;

            //foreach(int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "MERHABA";

            //foreach(char @char in word) // You can define C# keyword variable by using @ at the beginning, for ex: "@int"
            //{                           // This is called "verbatim identifier"
            //    Console.WriteLine(@char);        
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            // Console.WriteLine("****** C# Eğitim Kampı Sınav Uygulaması ******");
            // Console.WriteLine("\n");

            // // Sınıftaki öğrenci sayısını alma
            // Console.WriteLine("---------------------------------------");
            // Console.Write("Sınıfınızda kaç öğrenci var: ");
            // int studentCount = int.Parse(Console.ReadLine());
            // Console.WriteLine("---------------------------------------");

            // // Öğrenci notları ve isimlerini saklayacak diziler oluşturma
            // string[] studentNames = new string[studentCount];
            // double[] studentExamAverages = new double[studentCount];
                
            // for(int i = 0; i < studentCount; i++)
            // {
            //     Console.Write($"{i + 1}. öğrenci ismini giriniz: ");
            //     studentNames[i] = Console.ReadLine();

            //     double total = 0;

            //     for(int j = 0; j < 3; j++)
            //     {
            //         Console.Write($"{studentNames[i]} öğrencinin {j+1}. notunu giriniz: ");
            //         double grade = double.Parse(Console.ReadLine());

            //         total += grade;
            //     }

            //     studentExamAverages[i] = total / 3;
            // }

            // // Öğrencilerin ortalama sonuçlarına göre geçip geçmediklerine karar veriyoruz

            // Console.WriteLine("******** Öğrencilerin Verileri ********");
            // Console.WriteLine();
            
            // string[] failOrSucces = new string[studentCount];

            // for(int i = 0; i < studentCount; i++)
            // {
            //     if (studentExamAverages[i] >= 55)
            //     {
            //         failOrSucces[i] = "Geçti";
            //     }
            //     else
            //     {
            //         failOrSucces[i] = "Kaldı";
            //     }
            //     Console.WriteLine("---------------------------------------");
            //     Console.WriteLine($"{studentNames[i]} adlı öğrenci {studentExamAverages[i]:F1} sınav ortalamasıyla: {failOrSucces[i]}");
            // }

            // Console.WriteLine("---------------------------------------");
            #endregion

            Console.Read();
        }
    }
}
