using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WWEB_API_PROYECTO.Models
{
    [MetadataType(typeof(Validacion_Shippers.MetaData))]
    public partial class Validacion_Shippers
    {


        sealed class MetaData
        {
            [Required]
            public string ShipperID;
            public string CompanyName;
        }
    }
}






