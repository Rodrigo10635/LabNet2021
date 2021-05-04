using PRACTICA_LINQ.Data;
using PRACTICA_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_LINQ.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new NorthwindContext();

            var EJERCICIO_1 = context.Customers; 

            foreach (var item in EJERCICIO_1)
            {
                Console.WriteLine($"{item.CustomerID}-{item.CompanyName}-{item.Address}-{item.City}-{item.Country}-{item.Phone}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_2 = context.Products.Where(p => p.UnitsInStock == 0); 

            foreach (var item in EJERCICIO_2)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}-{item.UnitsInStock}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_3 = from producto in context.Products //OK
                         where (producto.UnitsInStock != 0) && (producto.UnitPrice > 3)
                         select producto;

            foreach (var item in EJERCICIO_3)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}-{item.UnitsInStock}");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_4 = from clientes in context.Customers //OK
                               where clientes.Region == "WA"
                               select clientes;

            foreach (var item in EJERCICIO_4)
            {
                Console.WriteLine($"{item.CustomerID}-{item.CompanyName}-{item.Address}-{item.City}-{item.Country}-{item.Phone}");
            }
           

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_5 = context.Products.Where(p => p.ProductID == 789).FirstOrDefault();

            if (EJERCICIO_5 != null)
            {
                Console.WriteLine($"{EJERCICIO_5.ProductName}");
            }
            else
                Console.WriteLine("El valor es nulo");


            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_6 = context.Products;

            foreach (var item in EJERCICIO_6)
            {
                Console.WriteLine(item.ProductName.ToLower());
            }

            foreach (var item in EJERCICIO_6)
            {
                Console.WriteLine(item.ProductName.ToUpper());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            DateTime fecha = DateTime.Parse("1/1/1997");
            var EJERCICIO_7 = context.Customers.Join(context.Orders,

                cl => cl.CustomerID,
                ord => ord.CustomerID,
                (cl, ord) => new
                {
                    cl.CustomerID,
                    ord.OrderDate,
                    cl.Region
                }).Where(cl => cl.Region == "WA" && cl.OrderDate > fecha);

            foreach (var item in EJERCICIO_7)
            {
                Console.WriteLine($"{item.CustomerID}-{item.OrderDate}-{item.Region}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_8 = context.Customers.Where(C => C.Region == "WA").Take(3); //OK


            foreach (var item in EJERCICIO_8)
            {
                Console.WriteLine($"{item.CustomerID}-{item.CompanyName}-{item.Address}-{item.City}-{item.Country}-{item.Phone}");
            }
           

            
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_9 = from productos in context.Products
                              orderby productos.ProductName
                              select productos;
           
            foreach (var item in EJERCICIO_9)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}-{item.UnitsInStock}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_10 = from productos in context.Products
                               orderby productos.UnitsInStock descending
                               select productos;

            foreach (var item in EJERCICIO_10)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}-{item.UnitsInStock}");

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_11 = context.Products.Join(context.Categories,
                sc => sc.CategoryID,
                soc => soc.CategoryID,
                (sc, soc) => new
                {
                    sc.ProductID,
                    soc.CategoryName
                }).GroupBy(g => g.CategoryName).ToList();

         

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_12 = context.Products.First();


            Console.WriteLine($"el nombre del primer producto es {EJERCICIO_12.ProductName}");
            

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            var EJERCICIO_13 = from p in context.Orders.GroupBy(p => p.CustomerID) 
                          select new
                          {
                              count = p.Count(),
                              p.FirstOrDefault().CustomerID,
                          };

            


            foreach (var item in EJERCICIO_13)
            {
                Console.WriteLine($"{item.CustomerID } { item.count}");
            }

            Console.ReadLine();










        }
    }
}
