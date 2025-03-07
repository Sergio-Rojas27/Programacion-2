using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadora_Simulator_V2___Sergio_Rojas
{
    public class Lavadora
    {
        //Constuctor
        public bool encendido { get; set; }
        public string cicloDeLavado { get; set; }
        public int tiempoDelCiclo { get; set; }

        // Metodos
        public void Encender()
        {
            encendido = true;
        }
        public void Apagar()
        {
            encendido = false;
        }
    }
}
