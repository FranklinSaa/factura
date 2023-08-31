using factura.Modelo;
using factura.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura
{
    public partial class FORM : Form
    {
        public FORM()
        {
            InitializeComponent();
        }

        private void FORM_Load(object sender, EventArgs e)
        {
            


    }

        private void btcli_Click(object sender, EventArgs e)
        {
            cliente for_cliente = new cliente();
            for_cliente.Show();
        }

        private void btpro_Click(object sender, EventArgs e)
        {
            producto for_producto = new producto();
            for_producto.Show();
        }

        private void btfac_Click(object sender, EventArgs e)
        {

        }
    }
}
