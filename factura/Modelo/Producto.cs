using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Modelo
{
    internal class Producto
    {
        private string cod;
        private string nombre;
        private string stock;
        public Producto() { }

        public string Cod { get => cod; set => cod = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Stock { get => stock; set => stock = value; }
    }
}
