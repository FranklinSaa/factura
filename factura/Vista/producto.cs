using factura.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Modelo
{
    public partial class producto : Form
    {
        Ctl_producto ctl_producto = new Ctl_producto();
        public producto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btag_Click(object sender, EventArgs e)
        {
            int pos = ctl_producto.buscar_producto (txtcedula.Text.Trim());
            Cliente user = new Cliente();
            {
                user.Cedula = txtcedula.Text;
                user.Nombre = txtnombre.Text;
                user.Apellido = txtapellido.Text;
            }
            ctl_cliente.editar_cliente(pos, user);
            MessageBox.Show("USUARIO ACTUALIZADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK);
            ctl_cliente.Mostrar_Tabla(vista);
            limpiar();
        }
    }
}
