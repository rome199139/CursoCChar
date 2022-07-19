using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MultimediaFile mFile = new MultimediaFile("12/12/2018", "12/05/2022", "nuevo archivo multimedia", "video"); 
            DynamicFile dFile = new DynamicFile("22/12/2021", "12/07/2023", "nuevo archivo dinamico", "video");
            StaticFile sFile = new StaticFile("02/02/2022", "12/12/2023", "nuevo archivo estatico", "texto");

            mFile.DesplegarInformacion();
            dFile.DesplegarInformacion();
            sFile.DesplegarInformacion();

            Console.ReadLine();

            
        }
    }
}
