using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem
{
    class Shop
    {
        public List<Product> ProductList = new List<Product>();    // store list of products in the shop
        public void AddProduct()         // ask user entering information about new product and add the product to ProductList
        {
            Product product = new Product();
            product.setInfo();
            ProductList.Add(product);
            Console.WriteLine("Add Product Done...");
        }
        public void RemoveProduct()      // ask user entering a product name and delete the product
        {
            Console.Write("\nNhap name product remove: ");
            string nameProductRemove = Console.ReadLine();

            for(int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Name.Equals(nameProductRemove))
                {
                    ProductList.RemoveAt(i);
                }    
            }    
            Console.WriteLine("Remove Product " + nameProductRemove + " Done...");
        }
        public void Display() // iterate the Product List, call ViewInfo() of a Product, calculate average point of Product and display the information to screen.
        {
            Console.WriteLine();
            foreach (Product product in ProductList)
            {
                product.ViewInfo();
            }    
        }
        public void SearchProduct() // ask user entering 2 numbers, after that search and display information of products that their prices between them.
        {
            Console.Write("Nhap price thap nhat: ");
            double priceMin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap price cao nhat: ");
            double priceMax = Convert.ToDouble(Console.ReadLine());

            foreach(Product product in ProductList)
            {
                if (product.Price >= priceMin && product.Price <= priceMax)
                    product.ViewInfo();
            }    
        }
        
        public void SortProductByName()
        {
            ProductList.OrderBy(p => p.Name).ToList();      // Linq
            Console.WriteLine("Sort product by name Done ...");
        }

        public void SortProductByPice()
        {
            ProductList.OrderBy(p => p.Price).ToList();     // Linq
            Console.WriteLine("Sort product by price Done ...");
        }

        public void SortProductByRate()
        {
            ProductList.OrderBy(p => p.rate).ToList();      // Linq
            Console.WriteLine("Sort product by rate Done ...");
        }
    }
}
