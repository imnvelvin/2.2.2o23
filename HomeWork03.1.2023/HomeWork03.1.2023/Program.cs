using System;

namespace HomeWork03._1._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Product Pc1 = new Product
            {
                Category = "Pc2",
                Price = 2700,
                ProductNumber = "M02"
            };

            Product phone = new Product
            {
                Category = "Phone",
                Price = 500,
                ProductNumber = "P23"
            };

            try
            {
                store.AddProduct(Pc1);

                store.AddProduct(phone);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());



        }   } 
   
