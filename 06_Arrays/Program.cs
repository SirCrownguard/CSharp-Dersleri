using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Green";
            //colors[2] = "Blue";
            //colors[3] = "Yellow";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[] { "Ankara", "İstanbul", "İzmir" };

            //Console.WriteLine(cities[0]);

            //int[] numbers = new int[] { 1, 2, 67, 4 };

            //Console.WriteLine(numbers[2]);

            //string[] cities = { "Ankara", "İstanbul", "İzmir" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listemele

            //string[] colors = { "Red", "Green", "Blue", "Yellow" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 21, 52, 325, 74, 235, 325, 523, 5 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 2)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] characters = { 'a', 'b', 'c', 'd', 'e', '/', '-' };

            //for (int i = 0; i < characters.Length; i++)
            //{
            //    Console.WriteLine(characters[i]);
            //}

            //int[] myArray = { 45, 743, 124, 421, 412, 745, 214, 42, 21, 8, 34, 5};

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Veli", "Deli", "Mehmet", "Ayşe", "Fatma" };
            //Console.WriteLine("Dizideki eleman sayısı: " + persons.Length);

            //int[] numbers = { 45, 12, 52, 94, 3456, 74235, 523, 3624, 634, 634, 346 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "Ali", "Veli", "Deli", "Mehmet", "Ayşe", "Fatma" };
            //int index=Array.IndexOf(customers, "Deli");
            //Console.WriteLine("Index: " + index);

            //int[] numbers = { 45, 12, 52, 94, 3456, 74235, 523, 3624, 634, 634, 346 };
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());

            #endregion

            #region Kullanıcıdan Değer Alma ve Diziye Atama

            //string[] students = new string[5];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.Write($"Öğrenci {i + 1}. adını giriniz: ");
            //    students[i] = Console.ReadLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"Öğrenci {i + 1}. adı: {students[i]}");
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Çift Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Tek Sayılar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("--------------------------------");

            #endregion
        }
    }
}
