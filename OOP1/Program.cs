using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Table";
            product1.CategoryId = 2;
            product1.UnitPrice = 120;
            product1.UnitInStock = 5;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Pencil", UnitPrice = 12, UnitInStock = 30 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
