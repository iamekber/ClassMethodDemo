using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class Customers
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer() { };

            customer1.Id = 1;
            customer1.customerName = "Emre";
            customer1.customerSurname = "Topal";

            customer customer2 = new customer() { };

            customer2.Id = 2;
            customer2.customerName = "Ahmet";
            customer2.customerSurname = "Ak";

            customer customer3 = new customer() { };

            customer3.Id = 3;
            customer3.customerName = "Veli";
            customer3.customerSurname = "Kaya";

            customer[] musteriler = new customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);

            customerManager.MusteriListeleme(musteriler);

            customerManager.CustomerDel(customer1);
            customerManager.CustomerDel(customer2);
            customerManager.CustomerDel(customer3);
        }
    }
}
