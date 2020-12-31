using ADONETEF.MyMigration;
using System;

namespace ADONETEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //new InsertDataIntoOrders().InsertIntoOrders();
            //new InsertDataIntoProducts().InsertIntoProducts();
            //new UpdateDetails().UpdateProduct(1,"Camera");
            // new UpdateDetails().UpdateOrder(3, "MI Note7","Noida");
            new PrintOrderDetails().PrintOrders();
            // new PrintProductDetails().PrintProducts();
        }
    }
}
