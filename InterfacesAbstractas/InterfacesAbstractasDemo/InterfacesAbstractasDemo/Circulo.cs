using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractasDemo
{
    class HijaCirculo : Circulo
    {

    }
    
    //sealed - sellar clase

    class Circulo : FiguraBase, IFigura, IRenderizador
    {
        int radio;

        void IFigura.Dibujar()
        {
            throw new NotImplementedException();
        }

        void IRenderizador.Dibujar()
        {
            throw new NotImplementedException();
        }
        public int Calcular(int x, int y)
        {
            throw new NotImplementedException();
        }

        public double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public void Renderizar()
        {
            throw new NotImplementedException();
        }

        public override void ObtenerTipo()
        {
            throw new NotImplementedException();
        }
    }
}
