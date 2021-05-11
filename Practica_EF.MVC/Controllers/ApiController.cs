using Newtonsoft.Json.Linq;
using Practica_EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Practica_EF.MVC.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public async Task<ActionResult> ApiView()
        {
            Calculator calcu = new Calculator();
            List<Calculator> lista = new List<Calculator>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://love-calculator.p.rapidapi.com/getPercentage?fname=John&sname=Alice"),
                Headers =
                {
                    { "x-rapidapi-key", "c8ce62263bmsh57dcd7ed798ebf3p100bf9jsne8eebce594b1" },
                    { "x-rapidapi-host", "love-calculator.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                JObject jObject = JObject.Parse(body);

                calcu.fname= jObject["fname"].ToString();
                calcu.percentage = jObject["percentage"].ToString();
                calcu.result = jObject["result"].ToString();
                calcu.sname = jObject["sname"].ToString();

            }
            lista.Add(calcu);
            return View(lista);
        }
    }
}