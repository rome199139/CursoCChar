using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(numeroAleatorio);
            //adivinarNumero();
            Console.WriteLine("El resultado es : " + buclefor());



        static void adivinarNumero()
            {
                int numeroVeces = 1;
                int cantidadMaxima = 5;
                int numeroUsuario = 0;
                Random numero = new Random();
                int numeroAleatorio = numero.Next(1, 100);
                Console.WriteLine("Por favor digite un numero entre el rango 1 a 100");
                Console.WriteLine("Recuerda que solo tiene (" + cantidadMaxima + ") intentos para adivinar el numero");
                try
                {
                    numeroUsuario = Int32.Parse(Console.ReadLine()); 
                }
                catch (Exception e)
                {
                    Console.WriteLine("se ha producido una excepction, se inicializa numero ingresado en cero");
                }
                while (numeroAleatorio != numeroUsuario)
                {
                    cantidadMaxima--;
                    if (numeroAleatorio > numeroUsuario) numeroUsuario = numeroAleatorioMayor(cantidadMaxima, numeroUsuario);
                    if (numeroAleatorio < numeroUsuario) numeroUsuario = numeroAleatorioMenor(cantidadMaxima, numeroUsuario);
                    numeroVeces++;
                    if (cantidadMaxima == 0) numeroUsuario = numeroAleatorio;
                   
                }
                if (numeroVeces > 5 || cantidadMaxima == 0) Console.WriteLine("Perdiste: el numero aleatorio era (" + numeroAleatorio + ")");                    
                else Console.WriteLine("Felicitaciones adivinase el numero aleatorio (" + numeroAleatorio + ") y lo hiciste en (" + numeroVeces + ") intentos");
            }
        }

        private static int numeroAleatorioMenor(int cantidadMaxima, int numeroUsuario)
        {
            Console.WriteLine("El numero aleatorio es menor que el numero (" + numeroUsuario + ") ingresado por usted");
            Console.WriteLine("Te quedan (" + cantidadMaxima + ") intentos");
            Console.WriteLine("Por favor digite un nuevo numero menor a : " + numeroUsuario);
            numeroUsuario = Int32.Parse(Console.ReadLine());
            return numeroUsuario;
        }

        private static int numeroAleatorioMayor(int cantidadMaxima, int numeroUsuario)
        {
            Console.WriteLine("El numero aleatorio es mayor que el numero (" + numeroUsuario + ") ingresado por usted");
            Console.WriteLine("Te quedan (" + cantidadMaxima + ") intentos");
            Console.WriteLine("Por favor digite un nuevo numero mayor a : " + numeroUsuario);
            numeroUsuario = Int32.Parse(Console.ReadLine());
            return numeroUsuario;
        }
    
        private static int buclefor()
        {
            Console.WriteLine("Por favor digite un nuevo numero a : " );
            int valor = Int32.Parse(Console.ReadLine());
            for (int i=0; i < 10; i++)
            {
                valor = valor * 2;
                int j = i + 1;
                Console.WriteLine("En la iteracion : " + j + " el valor es : " + valor);
            }
            return valor;
        }
    }


}
