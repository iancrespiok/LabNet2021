using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_LAB_Transporte
{
    class Avion : Transporte
    {
        public Avion(int pasajeros, int id) : base(pasajeros, id)
        {

        }
        public override string Avanzar()
        {
            return $"Soy un avion que vuela con {pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"Soy un automovil que aterriza con {pasajeros} pasajeros.";
        }

        public override void Print()
        {
            Console.WriteLine($"Avion {id}: {pasajeros} pasajeros.");
        }

    }
}
