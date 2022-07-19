using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class MultimediaFile
    {
        string fechaCreacion;
        string fechaModificacion;
        string nombre;
        string tipoElemento;

        public MultimediaFile(string _fechaCreacion, string _fechaModificacion, string _nombre, string _tipoElemento)
        {
            fechaCreacion = _fechaCreacion;
            fechaModificacion = _fechaModificacion;
            nombre = _nombre;
            tipoElemento = _tipoElemento;
        }

        public void DesplegarInformacion()
        {
            string informacion = fechaCreacion + " " + fechaModificacion + " " + nombre + " " + tipoElemento;
            Console.WriteLine(informacion);
        }

    }
}
