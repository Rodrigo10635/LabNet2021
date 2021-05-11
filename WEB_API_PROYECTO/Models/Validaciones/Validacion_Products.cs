using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WWEB_API_PROYECTO.Models
{
    [MetadataType(typeof(Validacion_Products.MetaData))]
    public partial class Validacion_Products
    {
        sealed class MetaData
        {
            [Required]
            public int ProductID;
            public string ProductName;
        }


    }
}