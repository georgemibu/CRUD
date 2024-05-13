using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.modelos
{
    internal class Cliente
    {

        public string Id
        {
            /* Forma de hacerlo 1
            get { return Nombre; }
            set { nombre = value; }*/
            get;
            set;
        }
        public string Nombre
        {
            /* Forma de hacerlo 1
            get { return Nombre; }
            set { nombre = value; }*/
            get;
            set;
        }

        public string Apellido
        {
            get;
            set;
        }
        public string Telefono { get; set; }

        public string TarjetaCredito { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

    }
}
