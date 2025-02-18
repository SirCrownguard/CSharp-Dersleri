using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1) Çorbalar");
            //Console.WriteLine("2) Diğer Çorbalar");
            //Console.WriteLine("3) Diğer Diğer Çorbalar");
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Test";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, district, city;

            //customerName = "İSİM";
            //customerSurname = "SOYISIM";
            //customerEmail = "SDFLSLGD@GMAİLDATCOM";
            //customerPhone = "1111";
            //district = "diskrit?";
            //city = "şehir";

            //Console.WriteLine(" rezervasyon kartı");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("mail adres " + customerEmail);
            //Console.WriteLine("diskrit " + district);
            //Console.WriteLine("şehir " + city);

            //customerName = "Ayşegül";
            //Console.WriteLine(customerName);

            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 50;
            int lemonadePrice = 50;

            Console.WriteLine("---- test menü *****");
            Console.WriteLine();

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 3;
            pizzaCount = 3;
            lemonadeCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            Console.WriteLine("hmg tutarı:" + totalHamburgerPrice + "TL");


            #endregion

            Console.Read();
        }
    }
}




//Yazdırma Komutları