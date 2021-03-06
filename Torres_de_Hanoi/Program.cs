using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            // Keep the console window open in debug mode.
            Console.WriteLine("Bienvenido al juego de Hanoi, ¿Cuantos discos vas a utilizar?");
            int numDiscos = 0;
            while (numDiscos <= 0)
            {
                numDiscos = Convert.ToInt32(Console.ReadLine());
                if (numDiscos <= 0)
                {
                    Console.WriteLine("Introduce un numero valido, debe ser mayor que 0");
                }
            }
            int resolverNum = Convert.ToInt32(Math.Pow(2, numDiscos) - 1);
            Console.WriteLine("El numero de movimientos dada la formula matemática (2^n)-1 => " + resolverNum);
            Pila pilaIni = new Pila();
            Boolean isPila = pilaIni.rellenarPila(numDiscos);
            Pila pilaAux = new Pila();
            Pila pilaFin = new Pila();
            Console.WriteLine("El numero de movimientos segun el algoritmo iterativo -> " + Hanoi.algoritmoIterativo(numDiscos, pilaIni, pilaAux, pilaFin));
            Console.WriteLine("El numero de movimientos segun el algoritmo recursivo -> " + Hanoi.algoritmoRecursivoHanoi(numDiscos, pilaIni, pilaAux, pilaFin));
            Console.WriteLine("Pulse un botón para finalizar el juego");
            Console.ReadLine();

        }
    }
}
