using Business.CCS;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryProductDal;
using System;

namespace ConsoleUI
{
    class Program
    {
        //Restful --> HTTP --> TCP
        //HTTP Protokol : Bir kaynağa ulaşmak için izlediğimiz yol.
        static void Main(string[] args)
        {
          // ProductTest();
           // CategoryTest();
            //Data Transformation Object
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategroyDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            var result = productManager.GetProductDetails();
            if(result.Success==true)
            {
                foreach (var p   in result.Data)
                {
                    Console.WriteLine(p.ProductName + " " + p.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);  
            }

        }
    }
}
