using Práctica_EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Práctica_EF.Entities;
using Practica_EF.MVC.Models;


namespace Practica_EF.MVC.Controllers
{
    public class CustomersController : Controller
    {

        Customers_Logic logic = new Customers_Logic(); 

        // GET: Customers
        public ActionResult Index()
        {

            List<Customers> Customers = logic.Getall();

            List<CustomersView> customersViews = Customers.Select(s => new CustomersView
            {

                Id = s.CustomerID,
                CompanyName = s.CompanyName,

            }).ToList();

            return View(customersViews);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CustomersView customersView)
        {

            try
            {

                var customer_Entity = new Customers
                {
                    CustomerID = customersView.Id,
                    CompanyName = customersView.CompanyName
                };

                logic.Add(customer_Entity);

                return RedirectToAction("Index");

            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }

        }


        public ActionResult Delete(string id)
        {
            try
            {
                logic.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }
            
        }
        [HttpGet]
        public ActionResult Update(string id, string companyname)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(CustomersView CsutomerView)
        {

            try
            {
                var CustomerEntity = new Customers
                {
                    CustomerID = CsutomerView.Id,
                    CompanyName = CsutomerView.CompanyName,


                };
                logic.Update(CustomerEntity);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult vista()
        {
            Response.Redirect("https://localhost:44311/Api/ApiView");
            return View();
        }

    }
}