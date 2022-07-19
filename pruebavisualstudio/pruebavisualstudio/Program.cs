using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebavisualstudio
{
    class Program
    {
        private const string Value = "Hola Mundo";

        static void Main(string[] args)
        {
            mensajeEnPantalla();
        }

    }

    private int sumanumero(int num1, int num2)
    {
        int resultado = num1 + num2;
        return resultado;

    }

    static void mensajeEnPantalla()
    {
        Console.WriteLine("Este es el mensade en pantalla!");
    }
}
