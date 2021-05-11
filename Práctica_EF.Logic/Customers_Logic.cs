using Práctica_EF.Data;
using Práctica_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_EF.Logic
{
    public class Customers_Logic : Base_Logic
    {


        public List<Customers> Getall()
        {

            return context.Customers.ToList();

        }



        public void Add(Customers newCustomers)

        {
            context.Customers.Add(newCustomers);

            context.SaveChanges();
        }



        public void Delete(string id)
        {


            var customer_a_eliminar = context.Customers.Find(id); //

            context.Customers.Remove(customer_a_eliminar);

            context.SaveChanges();

        }




        public void Update(Customers customers)
        {

            var customersUpdate = context.Customers.Find(customers.CustomerID);

            customersUpdate.CustomerID = customers.CustomerID;
            customersUpdate.CompanyName = customers.CompanyName;
            customersUpdate.Address = customers.Address;
            customersUpdate.City = customers.City;

            context.SaveChanges();

        }

        
    }
}