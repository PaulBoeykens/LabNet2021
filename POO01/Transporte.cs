using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
   public abstract class Transporte
    {
        private int pasajeros;
        private string serie;
        public int getPasajeros()
        {
            return pasajeros;
        }
        public string getSerie()
        {
            return serie;
        }
        public Transporte (int pasajeros, string serie)
        {
            this.pasajeros = pasajeros;
            this.serie = serie;
        }
        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
