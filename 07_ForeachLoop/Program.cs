using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa", "Antalya" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 21, 52, 325, 74, 235, 325, 523, 5 };

            //foreach(int number in numbers)
            //{
            //    if (number % 3 == 2)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 21, 52, 325, 74, 235, 325, 523, 5 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //string word = "Hello World";

            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("Sınav Sistemi");
            Console.WriteLine();
            Console.WriteLine("*************");

            Console.WriteLine("-----"); // 30 taneye ne gerek var hocam :(
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----");

            string[] studentName = new string [studentCount];
            double[] studentExamAvg = new double[studentCount];



            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adı: ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} öğrencinin {j + 1}. sınav notu: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                studentExamAvg[i] = totalExamResult / 3;

            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} öğrencisinin sınav ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} öğrencisi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} öğrencisi kaldı.");
                }
            }

            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion

            #region
            #endregion
        }
    }
}
