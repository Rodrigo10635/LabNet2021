using Práctica_EF.Data;
using Práctica_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_EF.Logic
{
    public class ProductsLogics : Base_Logic
    {
      

        public List<Products>Getall()
        {

            return context.Products.ToList();

        }

        ////EJERCICIO 2
        //public List<Products> SinStock() //method syntax
        //{
        //    return context.Products.Where(p => p.UnitsInStock == 0).ToList();
        //}

        
        //public List<Products> SinStock2() //query Syntax
        //{
        //    var query = from producto in context.Products
        //                where producto.UnitsInStock == 0
        //                select producto;
        //    return query.ToList();
        //}

        
        ////EJERCICIO 3

        //public List<Products> Productos_con_stock() //query Syntax
        //{
        //    var query = from producto in context.Products
        //                where (producto.UnitsInStock != 0) && (producto.UnitPrice>3)
        //                select producto;
        //    return query.ToList();
        //}

        //public List<Products> Productos_con_stock1() //method syntax
        //{
        //    return context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice>3).ToList();
        //}

        //public List<Products> asdasd() //method syntax
        //{
        //    var consulta = context.Products.FirstOrDefault(x => x.ProductID == 789);
        //    List<Products> Lista = new List<Products>();
        //    Lista.Add(consulta);
        //    return Lista;
        //}
        






    }
}
