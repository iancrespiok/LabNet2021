using System;
using System.Collections.Generic;

namespace Ejercicio_POO_LAB_Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Lista de Transportes:");
            List<Transporte> lista = new List<Transporte>();
            lista.Add(new Avion(100,1));
            lista.Add(new Avion(200,2));
            lista.Add(new Avion(300,3));
            lista.Add(new Avion(400,4));
            lista.Add(new Avion(500,5));

            lista.Add(new Automovil(2,1));
            lista.Add(new Automovil(1,2));
            lista.Add(new Automovil(6,3));
            lista.Add(new Automovil(3,4));
            lista.Add(new Automovil(2,5));

            lista.ForEach(Print);
                     
        }

        private static void Print(Transporte obj)
        {
            obj.Print();
        }
    }
}
