using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız yazdırma

            //for (int i = 1; i < 10; i++) {
            //    Console.WriteLine("*");
            //}
            //Console.ReadLine();

            #endregion

            #region Yan yana 10 tane yıldız yazdırma

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.ReadLine();

            #endregion

            #region Alt alta ve yan yana 10 tane yıldız yazdırma

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            //Console.ReadLine();

            #endregion

            #region Dik üçgen oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters dik üçgen oluşturma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yarım baklava

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
            }

            //Valla hocam burda kafa uctu biraz.
            //Bir de böle böle yaptım, 3 gündür adam akıllı müsait olamadım.
            //Koptum biraz burada, atladım burayı.

            #endregion
        }
    }
}
