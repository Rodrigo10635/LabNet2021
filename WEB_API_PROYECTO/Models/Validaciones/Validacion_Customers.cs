using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WWEB_API_PROYECTO.Models
{
    [MetadataType(typeof(Customers.MetaData))]
    public partial class Customers
    {


        sealed class MetaData
        {
            [Required]
            public string CompanyName;
            public string CustomerID;
        }
    }
}