using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali");
            //    Console.WriteLine("Veli");
            //    Console.WriteLine("Deli");
            //    Console.WriteLine("Mehmet");
            //}

            //CustomerList();

            #endregion

            #region Geriye Değer Döndürmeyen Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("müsteri");

            void CustomerCard(string name, string surname, int age)
            {
                Console.Write("Adı: " + name);
                Console.Write("Soyadı: " + surname);
                Console.Write("Yaşı: " + age);
            }

            CustomerCard();

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
