using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer customer2 = new Customer
            {
                ID = 110,
                Name = "Pam",
                Gender = "Male"

            };

            Customer customer3 = new Customer
            {
                ID = 119,
                Name = "John",
                Gender = "Male"
            };

            Customer customer4 = new Customer
            {
                ID = 104,
                Name = "Mary",
                 Gender = "Female"
            };

            Customer customer5 = new Customer
            {
                ID = 105,
                Name = "Suse",
                Gender = "Female"
            };



            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);


            //Customer c1 = queueCustomers.Dequeue();
            //Console.WriteLine(c1.Name);
            //Console.WriteLine("Count is " + queueCustomers.Count);

            //Customer c2 = queueCustomers.Dequeue();
            //Console.WriteLine(c2.Name);
            //Console.WriteLine("Count is " + queueCustomers.Count);


            //Customer c3 = queueCustomers.Dequeue();
            //Console.WriteLine(c3.Name);
            //Console.WriteLine("Count is " + queueCustomers.Count);

            //Customer c4 = queueCustomers.Dequeue();
            //Console.WriteLine(c4.Name);
            //Console.WriteLine("Count is " + queueCustomers.Count);


            //Customer c5 = queueCustomers.Dequeue();
            //Console.WriteLine(c5.Name);
            //Console.WriteLine("Count is " + queueCustomers.Count);


            Console.WriteLine();
            Console.WriteLine("--------------------------Peek--------------------");

            Customer c11 = queueCustomers.Peek();
            Console.WriteLine(c11.Name);
            Console.WriteLine("Count is " + queueCustomers.Count);

            Customer c21 = queueCustomers.Peek();
            Console.WriteLine(c21.Name);
            Console.WriteLine("Count is " + queueCustomers.Count);


            Customer c31 = queueCustomers.Peek();
            Console.WriteLine(c31.Name);
            Console.WriteLine("Count is " + queueCustomers.Count);

            Customer c41 = queueCustomers.Peek();
            Console.WriteLine(c41.Name);
            Console.WriteLine("Count is " + queueCustomers.Count);


            Customer c51 = queueCustomers.Peek();
            Console.WriteLine(c51.Name);
            Console.WriteLine("Count is " + queueCustomers.Count);



            Console.ReadLine();


        }
    }


    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}
