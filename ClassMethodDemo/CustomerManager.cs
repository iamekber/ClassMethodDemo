using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        
        public void CustomerAdd(customer Customer)
        {
            Console.WriteLine("Müşteri Adı Soyadı : " + Customer.customerName + " " + Customer.customerSurname);
            Console.WriteLine("-------------------------------");
        }

        public void MusteriListeleme(customer[] Customers)
        {
            foreach (var Customer in Customers)
            {
                Console.WriteLine("Müşteri Id : " + Customer.Id);
                Console.WriteLine("Müşteri Ad : " + Customer.customerName);
                Console.WriteLine("Müşteri Soyad : " + Customer.customerSurname);
                Console.WriteLine("--------------------");
            }
        }

        public void CustomerDel(customer Customer)
        {
            Console.WriteLine(Customer.customerName + " " + Customer.customerSurname + " isimli müşteri silinmiştir.");
        }
       
    }
}
