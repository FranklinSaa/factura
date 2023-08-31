using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factura.Modelo
{
    internal class Factura
    {
        private int n_factura;
        private string ced_cliente;
        private string fecha;
        private string total;

        public Factura (){ }

        public int N_factura { get => n_factura; set => n_factura = value; }
        public string Ced_cliente { get => ced_cliente; set => ced_cliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Total { get => total; set => total = value; }
    }
}
