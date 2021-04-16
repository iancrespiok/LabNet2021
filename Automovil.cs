﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_POO_LAB_Transporte
{
    public class Automovil : Transporte
    {
        public Automovil (int pasajeros, int id) : base(pasajeros, id)
        {

        }
        public override string Avanzar()
        {
            return $"Soy un automovil que avanzo con {pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"Soy un automovil que avanzo con {pasajeros} pasajeros.";
        }

        public override void Print()
        {
            Console.WriteLine($"Automovil {id}: {pasajeros} pasajeros.");
        }

    }
}
