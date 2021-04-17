using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
    public class Avion : Transporte
    {
        public Avion(int pasajeros, string serie) : base(pasajeros, serie)
        {
        }
        public override string Avanzar()
        {
            return string.Format("El {0} avanza con un total de {1} pasajeros.", getSerie(),getPasajeros());
        }
        public override string Detenerse()
        {
            return $"No se detendrá hasta finalizar el viaje porque no tiene vocina!";
        }
    }
}
