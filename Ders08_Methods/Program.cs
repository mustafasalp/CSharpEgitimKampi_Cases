using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //Console.WriteLine("Selam");

            // "WriteLine" here is a method.
            // Methods include a purple cube in their info session.

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("İbrahim Turan");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;

            //    int z = x + y;

            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Void Methods with string parameters

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet YILDIZ");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mustafa Salih", "ALP");

            #endregion

            #region Void Methods with int parameters

            //void Sum(int n1, int n2, int n3)
            //{
            //    Console.WriteLine($"Sum of numbers: {n1 + n2 + n3}");
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Methods which returns value

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Mustafa Salih";
            //    string surname = "ALP";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Methods which returns string value and takes a parameter

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " " + "Başkent: " + capital + " " + 
            //                                                    "Bayrak renkleri: " + flagColor;
            //    return cardInfo;
            //}

            //Console.Write("Ülke adını giriniz: ");
            //string ülkeİsmi = Console.ReadLine();
            //Console.Write("Başkent adını giriniz: ");
            //string başkent = Console.ReadLine();
            //Console.Write("Bayrağın içerdiği renkleri giriniz: ");
            //string bayrakRengi = Console.ReadLine();

            //string result = CountryCard(ülkeİsmi, başkent, bayrakRengi);
            //Console.WriteLine(result);
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı ve Beyaz"));

            #endregion

            #region Methods which returns int value and takes a parameter

            //int Sum(int number1, int number2)
            //{
            //    return number1 + number2;
            //}

            //Console.WriteLine(Sum(1, 2));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string studentName, int exam1, int exam2, int exam3)
            {
                double totalGrade = (double)(exam1 + exam2 + exam3) / 3;
                if(totalGrade >= 50)
                {
                    return $"{studentName} isimli öğrenci sınavda başarılı oldu, ortalaması: {totalGrade:F2}";
                }
                else
                {
                    return $"{studentName} isimli öğrenci sınavda başarısız oldu, ortalaması: {totalGrade:F2}";
                }
            }

            Console.WriteLine(ExamResult("Mustafa ALP", 12, 31, 53));
            Console.WriteLine(ExamResult("Zeynep ALP", 21, 45, 93));

            #endregion

            Console.Read();
        }
    }
}
