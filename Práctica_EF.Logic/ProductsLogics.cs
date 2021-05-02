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

    }
}
