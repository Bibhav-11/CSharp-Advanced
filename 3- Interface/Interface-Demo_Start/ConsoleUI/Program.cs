using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we were to add new product say, DigitalProductModel, then it would not be possible in this case. This is the case where interface is crucial.

            //Interface is IMPLEMENTED. Class is INHERITED.
            //We can implement multiple interfaces in same class. We cannot inherit multiple classes.

            //SOLID principles make good use of interface.
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if(prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For {digital.Title}, you have {digital.DownloadsLeft} downloads left");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@IAmTimCorey.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football" });
            output.Add(new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new DigitalProductModel { Title = "Fifa 21" });
            output.Add(new PhysicalProductModel { Title = "MouseGaming" });

            return output;
        }
    }
}
