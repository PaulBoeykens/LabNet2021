using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO02
{
   public class Logic
    {
        public static void Nombre()
        {                               
                DateTime? dateNull = null;
                string date = dateNull.Value.ToString("MM/yy");           
        }

        public static void ThrowCustomeException()
        {
            throw new Exception();
        }
    }
}
