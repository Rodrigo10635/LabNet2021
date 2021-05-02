using Práctica_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_EF.Logic
{
    public class Shippers_Logic:Base_Logic
    {
         public List<Shippers> Getall() 
        {

            return context.Shippers.ToList();

        }




        public int Add(Shippers newShipper) 

        {
            context.Shippers.Add(newShipper);

            context.SaveChanges();

            return newShipper.ShipperID;
        }


        public void Delete(int id)
        {
            
                
                var shipper_a_eliminar = context.Shippers.Find(id); //
                context.Shippers.Remove(shipper_a_eliminar);
                context.SaveChanges();

        }



        
        public void Update(Shippers shipper)
        {

            var shipperUpdate = context.Shippers.Find(shipper.ShipperID);
            
            shipperUpdate.ShipperID = shipper.ShipperID;
            
            shipperUpdate.CompanyName = shipper.CompanyName;
            
            shipperUpdate.Phone = shipper.Phone;
            
            context.SaveChanges();

        }
    }
}
