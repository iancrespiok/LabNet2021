using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_LAB_Transporte
{
    public abstract class Transporte
    {
        public Transporte(int pasajeros, int id)
        {
            this.pasajeros = pasajeros;
            this.id = id;
        }

        public int pasajeros { get; set; }
        public int id { get; set; }

        public abstract string Avanzar();

        public abstract string Detenerse();

        public abstract void Print();
    }
}
