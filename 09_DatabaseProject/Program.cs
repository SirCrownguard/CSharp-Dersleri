using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veri Tabanlı Ürün-Kategori Projesi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine();
            Console.WriteLine("1 - Kategoriler");
            Console.WriteLine("2 - Ürünler");
            Console.WriteLine("3 - Siparişler");
            Console.WriteLine("4 - Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz ürünün numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection(@"Data Source=Ertuğrul\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            connection.Close();







        }
    }
}
