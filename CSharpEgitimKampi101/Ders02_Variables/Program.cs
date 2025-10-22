using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables

            // Koddaki "." console da ki "," oluyor!

            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 15.50;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Fiyatı: " + applePrice + " Tl");
            //Console.WriteLine("---- Portakal Fiyatı: " + orangePrice + " Tl");
            //Console.WriteLine("---- Çilek Fiyatı: " + strawberryPrice + " Tl");
            //Console.WriteLine("---- Patates Fiyatı: " + potatoPrice + " Tl");
            //Console.WriteLine("---- Domates  Fiyatı: " + tomatoPrice + " Tl");
            //Console.WriteLine();

            //double appleWeight, orangeWeight, strawberryWeight, potatoWeight, tomatoWeight; // in kg

            //appleWeight = 1.245;
            //orangeWeight = 2.650;
            //strawberryWeight = 0.750;
            //potatoWeight = 4.859;
            //tomatoWeight = 3.745;

            //double appleTotalPrice = applePrice * appleWeight;
            //double orangeTotalPrice = orangePrice * orangeWeight;
            //double strawberryTotalPrice = strawberryPrice * strawberryWeight;
            //double potatoTotalPrice = potatoPrice * potatoWeight;
            //double tomatoTotalPrice = tomatoPrice * tomatoWeight;

            //Console.WriteLine("**** Alışveriş Listesi ****");
            //Console.WriteLine();
            //Console.WriteLine("---- Elma: " + appleWeight + " kg x " + applePrice + " Tl = " + appleTotalPrice + " Tl");
            //Console.WriteLine("---- Portakal: " + orangeWeight + " kg x " + orangePrice + " Tl = " + orangeTotalPrice + " Tl");
            //Console.WriteLine("---- Çilek: " + strawberryWeight + " kg x " + strawberryPrice + " Tl = " + strawberryTotalPrice + " Tl");
            //Console.WriteLine("---- Patates: " + potatoWeight + " kg x " + potatoPrice + " Tl = " + potatoTotalPrice + " Tl");
            //Console.WriteLine("---- Domates: " + tomatoWeight + " kg x " + tomatoPrice + " Tl = " + tomatoTotalPrice + " Tl");
            //Console.WriteLine();

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("**** Toplam Tutar: " + totalPrice + " Tl ****");


            #endregion

            #region Char Variables

            // char değişkenler 'char' ile tanımlanır.

            //char symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Input from keyboard for strings

            //Console.WriteLine("***** C# Hava Yolları Yolcu Bilgisi ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity,
            //     passengerIdentityNumber, passengerAge;

            //Console.Write("Please enter passenger name: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Please enter passenger surname: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Please enter passenger district: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Please enter passenger city: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Please enter passenger age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Please enter passenger identity number: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Name: " + passengerName);
            //Console.WriteLine("Surname: " + passengerSurname);
            //Console.WriteLine("District: " + passengerDistrict);
            //Console.WriteLine("City: " + passengerCity);
            //Console.WriteLine("Age: " + passengerAge);
            //Console.WriteLine("ID: " + passengerIdentityNumber);
            //Console.WriteLine("-------------------");

            #endregion

            #region Input from keyboard for integers

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı adetini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye adetini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = tvCount * tvPrice + shoesCount * shoesPrice + chairCount * chairPrice + 
            //    computerCount * computerPrice;

            //Console.WriteLine("Total prize: " + totalPrice);

            #endregion

            #region Input from keyboard for floats

            //double exam1, exam2, exam3, result;

            //Console.Write("Please enter exam1 grade: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter exam2 grade: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter exam3 grade: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Result: " + result);

            #endregion

            #region Input from keyboard for chars

            //char gender;

            //Console.Write("Enter your gender: ");
            //gender = char.Parse(Console.ReadLine()); // 1 Karakter girmen lazım!

            //Console.WriteLine("Your gender is: " + gender);

            #endregion

            Console.Read();
        }
    }
}
