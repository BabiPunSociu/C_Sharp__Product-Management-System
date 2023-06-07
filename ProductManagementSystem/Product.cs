using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }                 // 0 < Price <= 100
        public int rate { get; set; }                   // store points which users vote the product, 1 - 5

        public Product() { }
        public Product(string name, string description, double price, int rate)
        {
            Name = name;
            Description = description;
            Price = price;
            this.rate = rate;
        }

        public void setInfo()
        {
            Console.Write("Nhap name: ");
            Name = Console.ReadLine();
            Console.Write("\nNhap description: ");
            Description = Console.ReadLine();
            do
            {
                Console.Write("\nNhap price: ");
                Price = Convert.ToDouble(Console.ReadLine());
            }while(Price < 0 || Price > 100);

            do
            {
                Console.Write("\nNhap rate: ");
                rate = Convert.ToInt32(Console.ReadLine());
            }while (rate < 0 || rate > 5);
        }

        public void showRate()
        {
            for(int i=1;i<=5;i++)
            {
                Console.Write(i<=rate?"*":" ");
            }    
        }
        public void ViewInfo()
        {
            Console.Write($"{Name.PadLeft(20)}|{Description.PadLeft(30)}|{Price,5}|"); showRate();
        }
    }
}
