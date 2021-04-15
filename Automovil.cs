using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_LAB_Transporte
{
    class Automovil : Transporte
    {
        string Avanzar()
        {
            return $"$Soy un automovil que avanzo con {pasajeros} pasajeros.";
        }
    }
}
