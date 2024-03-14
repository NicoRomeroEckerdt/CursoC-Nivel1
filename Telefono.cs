using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POOPractica
{
    internal class Telefono
    {
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }

        private int codigoOperador;

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value < 4 && value > 0)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }
        // CONSTRUCTOR

        public Telefono (string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        //metodos
        public string Llamar()
        {
            return "Realizando llamada";
        }
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }

    }
}
