using ADONETEF.MyMigration;
using ADONETEF.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADONETEF.MyMigration
{
    public class InsertDataIntoProducts
    {
        public void InsertIntoProducts()
        {
            try
            {
                using (var context = new EntityContext())
                {
                    var product = new Product();
                    //{
                    //    ProductName = "Phone"   
                    //};

                    Console.WriteLine("Enter the ProductName:");
                    product.ProductName = Console.ReadLine();
                    context.Productss.Add(product);
                    context.SaveChanges();
                    Console.WriteLine("Records successfully installed into products table.....");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
