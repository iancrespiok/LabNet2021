using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_LAB_Transporte
{
    public abstract class Transporte
    {
        int pasajeros;

        public abstract string Avanzar();

        public abstract string Detenerse();
    }
}
