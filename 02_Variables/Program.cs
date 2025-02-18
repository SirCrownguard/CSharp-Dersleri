using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("Fiyat Listesi");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberPrice, potato, tomato;

            //applePrice = 1.85;
            //orangePrice = 52.54;
            //strawberPrice = 51.214;
            //potato = 58.1;
            //tomato = 12.63;

            //Console.WriteLine("Elma birim fiyatı " + applePrice);
            //Console.WriteLine("Portakal birim fiyatı " + orangePrice);
            //Console.WriteLine(strawberPrice);
            //Console.WriteLine(potato);
            //Console.WriteLine(tomato);

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 5.821;
            //orangeGram = 5.211;
            //strawGram = 6.832;
            //potatoGram = 9.6321;
            //tomatoGram = 1.2542;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * appleGram;
            //double stawberryTotalPrice = strawberPrice * appleGram;
            //double potatoTotalPrice = potato * appleGram;
            //double tomatoTotalPrice = tomato * appleGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj; " + appleGram + " - Toplam Fiyat: " + appleTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Orange - " + "Birim Fiyat: " + orangePrice+ " - Gramaj; " + orangeGram+ " - Toplam Fiyat: " + orangeTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + strawberPrice + " - Gramaj; " + strawGram + " - Toplam Fiyat: " + stawberryTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + potato + " - Gramaj; " + potatoGram+ " - Toplam Fiyat: " + potatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + tomato + " - Gramaj; " + tomatoGram+ " - Toplam Fiyat: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + stawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice + orangeTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("--- " + passengerName + " " + passengerSurname + " " + passengerAge + " " + passengerIdentityNumber + " " + passengerDistrict + " " + passengerCity + " ---");

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 5000;
            //chairPrice = 200;
            //tvPrice = 3000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Ayakkabı Adedi: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar Adedi: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye Adedi: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Televizyon Adedi: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalprice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalprice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Ortalama: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;

            Console.Write("Cinsiyet (E/K): ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçilen cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
