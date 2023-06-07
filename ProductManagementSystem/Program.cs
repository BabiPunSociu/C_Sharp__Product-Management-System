using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal class Program
    {
        static void showMenu()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("================== MENU ==================");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Remove product by name");
            Console.WriteLine("3. Display product list");
            Console.WriteLine("4. Search product follow ranger_price");
            Console.WriteLine("5. Sort product by NAME");
            Console.WriteLine("6. Sort product by PRICE");
            Console.WriteLine("7. Sort product by RATE");
            Console.WriteLine("0. Exit");
        }

        static int nhapChucNang()
        {
            int n;
            do
            {
                Console.Write("\nChuc nang ban chon la: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0 || n > 7);
            return n;
        }

        static void Main(string[] args)
        {
            Shop shop = new Shop();

            int chucNang, luaChon = 1;
            do
            {
                showMenu();
                chucNang = nhapChucNang();
                switch (chucNang)
                {
                    case 0:
                        Console.WriteLine("Ket thuc. Bye...");
                        luaChon = 0;
                        break;
                    case 1:
                        Console.WriteLine("Chuc nang 1. Add new product:");
                        shop.AddProduct();
                        break;
                    case 2:
                        Console.WriteLine("Chuc nang 2. Remove product by name:");
                        shop.RemoveProduct();
                        break;
                    case 3:
                        Console.WriteLine("Chuc nang 3. Display product list");
                        shop.Display();
                        break;
                    case 4:
                        Console.WriteLine("Chuc nang 4. Search product follow price");
                        shop.SearchProduct();
                        break;
                    case 5:
                        Console.WriteLine("Chuc nang 5. Sort product by name:");
                        shop.SortProductByName();
                        break;
                    case 6:
                        Console.WriteLine("Chuc nang 6. Sort product by price:");
                        shop.SortProductByPice();
                        break;
                    case 7:
                        Console.WriteLine("Chuc nang 7. Sort product by rate:");
                        shop.SortProductByRate();
                        break;
                }
            } while (luaChon != 0);
        }
    }
}
