using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Demo.MVC.Models
{
    public class ApiView
    {
               
            [Required]
          public DateTime Fecha { get; set; }
            [Required]
          public double Venta { get; set; }
            [Required]
          public double Compra { get; set; }
        
    }
}