using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO02
{
   public class CustomeException : Exception
    {
        public CustomeException() : base("Mensaje de error de la CustomeException")
        {

        }
    }
}
