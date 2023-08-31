using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Modelo
{
    internal class Det_factura
    {
        private int num_factura;
        private string cod_factura;
        private string Precio;
        private string stock;
        public Det_factura()
        { }

        public int Num_factura { get => num_factura; set => num_factura = value; }
        public string Cod_factura { get => cod_factura; set => cod_factura = value; }
        public string Precio1 { get => Precio; set => Precio = value; }
        public string Stock { get => stock; set => stock = value; }
    }
}
