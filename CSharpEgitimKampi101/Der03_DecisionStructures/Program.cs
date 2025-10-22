using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Der03_DecisionStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region decision(if/else) structures

            //string password;

            //Console.Write("Please enter password: ");
            //password = Console.ReadLine();

            //if(password == "123456789"){
            //    Console.WriteLine("Your password is correct!");
            //}
            //else{
            //    Console.WriteLine("Your password is incorrect!");
            //}

            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler doğrulanamadı");
            //}

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3;
            //double average;
            //string message;

            //Console.Write("Enter exam1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter exam2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter exam3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //message = "Not ortalaması 0-100 arası olmalı!!!";

            //if(average >= 0 && average < 50)
            //{
            //    message = "Sınavdan kaldınız...";
            //    Console.WriteLine("Ortalama: " + average);
            //}
            //if(average >= 50 && average < 70)
            //{
            //    message = "Sonuç CC";
            //    Console.WriteLine("Ortalama: " + average);
            //}
            //if (average >= 70 && average < 85)
            //{
            //    message = "Sonuç BB";
            //    Console.WriteLine("Ortalama: " + average);
            //}
            //if (average >= 85 && average < 100)
            //{
            //    message = "Sonuç AA, tebrikler...";
            //    Console.WriteLine("Ortalama: " + average);
            //}

            //Console.WriteLine(message); 

            //string city;
            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();

            //if(city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if(username != "admin")
            //{
            //    Console.WriteLine("You are not the admin");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome admin!");
            //}

            #endregion

            #region Mod işlemleri

            //int value = 26;
            //int result = value % 5;

            //Console.WriteLine(result);

            //int value1, value2;

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //value1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //value2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(value1 + " % " + value2 + " = " + value1 % value2);

            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine(number + " is even");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is odd");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları

            //Console.Write("Enter a char(G for Galatasaray, F for Fenerbahçe, B for Beşiktaş):");
            //char team = char.Parse(Console.ReadLine());

            //if(team == 'F' || team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'G' || team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'B' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış karakter girdiniz...");
            //}

            #endregion

            #region Örnek proje uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();

            //string choice;

            //Console.Write("Lütfen detayını görmek istediğiniz menüyü seçin: ");
            //choice = Console.ReadLine();

            //if(choice == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Köri soslu tavuk");
            //    Console.WriteLine("2- Makarna");
            //    Console.WriteLine("3- Kızartma Tabağı");
            //    Console.WriteLine("4- Kuru fasulye");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");

            //}
            //else if(choice == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Tavuk Çorbası");
            //    Console.WriteLine("3- Ezogelin Çorbası");
            //    Console.WriteLine("4- Yoğurt Çorbası");
            //    Console.WriteLine("5- Kelle paça");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");

            //}
            //else if (choice == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Akdeniz pizza");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");

            //}
            //else if (choice == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Coca Cola");
            //    Console.WriteLine("2- Fanta");
            //    Console.WriteLine("3- Sprite");
            //    Console.WriteLine("4- RedBull");
            //    Console.WriteLine("5- Ayran");
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");

            //}
            //else if (choice == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1- Tiramisu");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Helva");
            //    Console.WriteLine("4- Kadayıf");
            //    Console.WriteLine("5- Şekerpare");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış seçim yaptınız...");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Enter a month number[1-12]: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;

            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;

            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;

            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;

            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;

            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;

            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;

            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;

            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;

            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;

            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;

            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;

            //    default:
            //        Console.WriteLine("Yanlış sayı girdiniz...");
            //        break;
            //}   

            #endregion

            #region Hesap Makinesi

            //int choice,number1, number2;
            //Console.WriteLine("**** Hesap Makinesi ****");
            //Console.WriteLine("1- Bölme işlemi");
            //Console.WriteLine("2- Çarpma işlemi");
            //Console.WriteLine("3- Toplama işlemi");
            //Console.WriteLine("4- Çıkarma işlemi");
            //Console.Write("?: ");
            //choice = int.Parse(Console.ReadLine());
            
            //switch(choice)
            //{
            //    case 1:
            //        Console.Write("Bölünen sayıyı giriniz: ");
            //        number1 = int.Parse(Console.ReadLine());
            //        Console.Write("Bölen sayıyı giriniz: ");
            //        number2 = int.Parse(Console.ReadLine());

            //        if(number2 == 0)
            //        {
            //            Console.WriteLine("Bölen sayı " + number2 + " olamaz");
            //            break;
            //        }

            //        Console.WriteLine("Sonuç: " + (double)number1 / number2);
            //        break;

            //    case 2:
            //        Console.Write("number1'ı giriniz: ");
            //        number1 = int.Parse(Console.ReadLine());
            //        Console.Write("number2'ı giriniz: ");
            //        number2 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Sonuç: " + number1 * number2);
            //        break;

            //    case 3:
            //        Console.WriteLine("Format: number1 - number2");
            //        Console.Write("number1'ı giriniz: ");
            //        number1 = int.Parse(Console.ReadLine());
            //        Console.Write("number2'ı giriniz: ");
            //        number2 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Sonuç: " + (number1 - number2));
            //        break;

            //    case 4:
            //        Console.Write("number1'ı giriniz: ");
            //        number1 = int.Parse(Console.ReadLine());
            //        Console.Write("number2'ı giriniz: ");
            //        number2 = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Sonuç: " + number1 + number2);
            //        break;

            //    default:
            //        Console.WriteLine("Yanlış tercih yaptınız...");
            //        break;  
            //}
            
            #endregion

            Console.Read();
        }
    }
}
