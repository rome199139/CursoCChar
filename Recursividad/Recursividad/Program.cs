using System;

namespace Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            //countdown(10);
            //int numFact = 10;
            //Console.WriteLine("El factorial de : " + numFact + " es : "+ factorialRecursion(numFact));
            hanoi(6, 1, 3, 2);
            //factorialRecursion(5);
            //f_sumador(5, 8);
            // Console.WriteLine("La suma de dos numeros es " + f_sumador(5, 8));
        }

        static void countdown (int number)
        {
            Console.WriteLine("El numero en que voy es " + number);
            if (number > 0)
            {
                number = number - 1;
                countdown(number);
                Console.WriteLine("Vuelvo a la iteracion " + number);
            }
            else
            {
                Console.WriteLine("el contador ha llegado a " + number + " BOOM...!!! ");
            }
        }

        static int factorialRecursion(int number)
        {
            int iteracion = number;
            if (number > 1)
            {
                number = number * factorialRecursion(number - 1);
                Console.WriteLine("Voy en la iteracion : " + iteracion + " y el valor calculado hasta el momento es : " + number);
                iteracion--;
            }            
            return number;
        }

        static void hanoi(int discos, int origen, int destino, int auxiliar)
        {
            if (discos > 0)
            {
                discos--;
                hanoi(discos, origen, auxiliar, destino);
                Console.WriteLine("Disco de la posicion : " + origen + " a la posicion : " + destino);
                hanoi(discos, auxiliar, destino, origen);                                
            }
         }
    }

        
}
