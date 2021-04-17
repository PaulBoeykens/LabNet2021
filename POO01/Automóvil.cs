using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
    public class Automovil : Transporte
    {
        public Automovil (int pasajeros, string serie) : base( pasajeros, serie)
        {
        }
        public override string Avanzar()
        {
            return $"El {getSerie()} avanza  con un total de {getPasajeros()} pasajeros.";
        }
        public override string Detenerse()
        {
            return $"No se detendrá hasta finalizar el viaje porque tiene el tanque lleno de nafta.";
        }
    }
}
