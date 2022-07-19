using System;

namespace Condicionales
{
    class Program
    {
        string pase = "no";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //media();
            //edadPersona();
            meses();

            // condicionaIfparte2();

            //pruebaCondicion();
        }

       /* static void pruebaCondicion()
        {
            var mc = new Program();
            Console.WriteLine("Introduzca su edad..");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Tiene pase para conducir.. Si - No");
                mc.pase = Console.ReadLine();
            }
            if (mc.pase=="Si")
            {
                Console.WriteLine(mc.pase);
                Console.WriteLine("Usted puede conducir vehiculos");
            }
            else
            {
                Console.WriteLine("Usted no puede conducir vehiculos");
            }
                        
        }  
       */

        static void condicionaIfparte2()
        {
            Console.WriteLine("Introduzca su edad..");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("Usted no puede conducir vehiculos");
            }
            else
            {
                Console.WriteLine("Tiene pase para conducir.. Si - No");
                string pase = Console.ReadLine();
                int valida = String.Compare(pase, "si", true);
                if (valida == 0)
                {
                    Console.WriteLine("Usted puede conducir vehiculos");
                }
                else
                {
                    Console.WriteLine("Usted no puede conducir vehiculos");
                }
            }
        }

        static void media() {
            Console.WriteLine("Introduzca Nota primer parcial");
            double parcial1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca Nota segundo parcial");
            double parcial2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca Nota tercer parcial");
            double parcial3 = Int32.Parse(Console.ReadLine());
            double media = (parcial1 + parcial2 + parcial3) / 3;
            if (media >= 30)
            {
                Console.WriteLine("Su nota medias es: " + media);
            }
            else
            {
                Console.WriteLine("Perdio mi materia, vuelva pronto vecino....!");
            }
        }

        static void edadPersona()
        {
            Console.WriteLine("Introduzca su edad..");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("Su edad es " + edad + " y por lo tanto usted es un niño");
            }
            else if (edad <= 30)
            {
                Console.WriteLine("Su edad es " + edad + " y por lo tanto usted es aun joven");
            }
            else if (edad <= 60)
            {
                Console.WriteLine("Su edad es " + edad + " y por lo tanto usted es ya mayor");
            }
            else
            {
                Console.WriteLine("Su edad es " + edad + " y por lo tanto usted es ya tercera edad");
            }
        }

        static void meses()
        {
            Console.WriteLine("Introduzca el numero del mes de nacimiento..");
            int mesNacimiento = Int32.Parse(Console.ReadLine());

            switch (mesNacimiento)
            {
                case 1:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Enero");
                    break;
                case 2:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Febrero");
                    break;
                case 3:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Marzo");
                    break;
                case 4:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Abril");
                    break;
                case 5:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Mayo");
                    break;
                case 6:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Junio");
                    break;
                case 7:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Julio");
                    break;
                case 8:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Agosto");
                    break;
                case 9:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Octubre");
                    break;
                case 11:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Usted nacio en el mes " + mesNacimiento + " que corresponde al mes de Diciembre");
                    break;
                default:
                    Console.WriteLine("El mes digitado " + mesNacimiento + " No corresponde ah un mes .. vuelve a intentarlo ...!");
                    break;

            }
        }
    }
}

    

