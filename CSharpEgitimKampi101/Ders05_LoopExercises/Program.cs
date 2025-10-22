using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders05_LoopExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt alta 10 tane yıldız

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız

            //for (int i = 0; i < 10; i++)
            //    Console.Write("* ");

            #endregion

            #region Alt alta 10 tane yıldız oluştur ve her satırda 10 yıldız olsun (10x10)

            //for (int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine("");
            //}

            #endregion

            #region Dik Üçgen oluşturma, hipotenüs yönü farketmez(Tümü)

            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("");
            //// Bir de tam tersi şekilde
            //Console.WriteLine("");

            //for (int i = 10; 1 <= i; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("");
            //// Bir de tam tersi şekilde
            //Console.WriteLine("");

            //for (int i = 10; 1 <= i; i--)
            //{
            //    for (int j = 0; j < 10 - i; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine("");
            //}

            //Console.WriteLine("");
            //// Bir de tam tersi şekilde
            //Console.WriteLine("");

            //for (int i = 10; 1 <= i; i--)
            //{
            //    for (int j = 0; j < i - 1; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    for (int j = 0; j < 11 - i; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine("");
            //}

            #endregion

            #region Baklava dilimi

            //int asterix = 1;
            //Console.Write("Enter the size of dimond(odd number plase): ");

            //int size = int.Parse(Console.ReadLine());
            //int space = size / 2; // should start with 5, not 6

            //for (int i = 0; i < size; i++)
            //{
            //    // print leading spaces
            //    for (int j = 0; j < space; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    // print stars
            //    for (int j = 0; j < asterix; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();

            //    // update counters
            //    if (i < size/2)  // top half
            //    {
            //        asterix += 2;
            //        space--;
            //    }
            //    else        // bottom half
            //    {
            //        asterix -= 2;
            //        space++;
            //    }
            //}

            #endregion

            #region Yan üçgen

            //Console.Write("Enter n: ");
            //int n = int.Parse(Console.ReadLine());

            //int asterix = 1;
            //int space = n - 1;

            //for(int i = 0; i < 2*n - 1; i++)
            //{
            //    for(int j = 0; j < asterix; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    for(int j = 0; j < space; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    Console.WriteLine();

            //    if(i < (2*n - 1)/2)
            //    {
            //        asterix++;
            //        space--;
            //    }
            //    else
            //    {
            //        asterix--;
            //        space++;
            //    }
            //}

            #endregion

            #region Piramit with bottom number

            //Console.Write("Enter the bottom of the pyramid(odd number please): ");
            //int bottom = int.Parse(Console.ReadLine());
            //int asterix = 1;
            //int space = (bottom - 1) / 2;


            //for (int i = 0; i < (int)((bottom/2) + 1); i++)
            //{
            //    for(int j = 0; j < space; j++)
            //    {
            //        Console.Write("  ");
            //    }

            //    for(int j = 0; j < asterix; j++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();

            //    asterix += 2;
            //    space--;
            //}


            #endregion

            #region Ters Piramit with row number

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                // Spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }

                // Asterixes
                for (int j = 2*(n - i) - 1; j > 0; j--)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
            #endregion

            Console.Read();
        }
    }
}
