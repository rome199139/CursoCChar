using System;

namespace InterfacesAbstractasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           // IFigura f = new IFigura();
            Circulo c = new Circulo();
            IFigura f1 = c;
            f1.Dibujar();
            IRenderizador r = c;
            r.Dibujar();

            Linea l = new Linea();

            IFigura f = c;
            f = l;

            f.Dibujar();
           
            l.Dibujar();
        }

        static void CalcularArea(IFigura figura)
        {
            if(figura is Circulo)
            {
                figura.Dibujar();
            }
            else if(figura is Linea)
            {
                figura.Dibujar();
            }
        }
    }
}
