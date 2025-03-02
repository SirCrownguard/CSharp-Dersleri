using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Enter the capital of Turkey: ");
            //capital = Console.ReadLine();

            //Console.Write("Enter the country of Ankara: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Turkey")
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5) {
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Enter the first exam result: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second exam result: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the third exam result: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //if (average > 0 & average <= 50)
            //{
            //    result = "Failed";
            //}
            //else if (average > 50 & average <= 70)
            //{
            //    result = "Medium";
            //}
            //else if (average > 70 & average <= 100)
            //{
            //    result = "Passed";
            //}
            //else
            //{
            //    result = "Invalid";
            //}

            //if (result == "Invalid")
            //{
            //    Console.WriteLine("Invalid average");
            //}
            //else
            //{
            //    Console.WriteLine("Result: " + result);
            //    Console.WriteLine("Average: " + average);
            //}

            //string city;
            //Console.Write("Lütfen bir şehir adı giriniz: ");
            //city = Console.ReadLine();

            //if (city == "ankara" | city == "istanbul" | city == "izmir")
            //{
            //    Console.WriteLine("Bu şehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Bu şehir mevcut değil.");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı doğru");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("Sonuç: " + result);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;

            //Console.Write("Lütfen bir takım adı giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz takım adı");
            //}

            #endregion

            #region Örnek Uygulama

            //Console.WriteLine("-----------------------");
            //Console.Write("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("1. Tavuk Menü");
            //Console.WriteLine("2. Et Menü");
            //Console.WriteLine("3. Balık Menü");
            //Console.WriteLine("4. Çorba Menü");
            //Console.WriteLine("5. Tatlı Menü");
            //Console.WriteLine("-----------------------");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü numarasını girin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("Tavuk Menü");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("Tavuk Menü içeriği: ");
            //    Console.WriteLine("1. Tavuk");
            //    Console.WriteLine("2. Pilav");
            //    Console.WriteLine("3. Salata");
            //    Console.WriteLine("4. İçecek");
            //    Console.WriteLine("-----------------------");
            //}

            //else if (menuItem == "2")
            //{
            //    Console.WriteLine("Et Menü");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("Et Menü içeriği: ");
            //    Console.WriteLine("1. Et");
            //    Console.WriteLine("2. Pilav");
            //    Console.WriteLine("3. Salata");
            //    Console.WriteLine("4. İçecek");
            //    Console.WriteLine("-----------------------");
            //}

            //else if (menuItem == "3")
            //{
            //    Console.WriteLine("Balık Menü");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("Balık Menü içeriği: ");
            //    Console.WriteLine("1. Balık");
            //    Console.WriteLine("2. Pilav");
            //    Console.WriteLine("3. Salata");
            //    Console.WriteLine("4. İçecek");
            //    Console.WriteLine("-----------------------");
            //}

            //else if (menuItem == "4")
            //{
            //    Console.WriteLine("Çorba Menü");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("Çorba Menü içeriği: ");
            //    Console.WriteLine("1. Çorba");
            //    Console.WriteLine("2. Ekmek");
            //    Console.WriteLine("3. Salata");
            //    Console.WriteLine("4. İçecek");
            //    Console.WriteLine("-----------------------");
            //}

            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Tatlı Menü");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("Tatlı Menü içeriği: ");
            //    Console.WriteLine("1. Tatlı");
            //    Console.WriteLine("2. Kadayıf");
            //    Console.WriteLine("3. İrmik Helvası");
            //    Console.WriteLine("4. İçecek");
            //    Console.WriteLine("-----------------------");
            //}

            //else
            //{
            //    Console.WriteLine("Geçersiz menü numarası");

            #endregion

            #region Switch Case

            //Console.Write("Lütfen bir ay giriniz: ");
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
            //        Console.WriteLine("Geçersiz ay numarası");
            //        break;
            //}

            #endregion

            #region Switch Case Örnek Uygulama

            //int number1, number2, result;
            //char symbol;
            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen işlem sembolünü giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}

            #endregion
        }
    }
}